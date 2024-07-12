using System;
using System.IO;
using System.Diagnostics;

namespace BulkMediaTrimmer
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a directory\n-> ");
            string directory = Console.ReadLine().Replace("\n", "");

            Console.Write("Enter the trim length\n->");
            int.TryParse(Console.ReadLine(), out int length);

            string[] files = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);

            Directory.CreateDirectory("output");
            CloneDirectory(directory);

            float totalSeconds = 0;

            string progressText = "";

            for (int i = 0; i < files.Length; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                string extension = Path.GetExtension(files[i]);
                string outputFile = $"output\\{files[i].Substring(directory.Length - Path.GetFileName(directory).Length)}";

                if (!File.Exists(outputFile))
                {
                    string arguments = $"-sseof -{length} -y -i \"{files[i]}\" -c copy \"{outputFile}\"";
                    StartProcess("ffmpeg", arguments, progressText, true, false);

                    FileInfo inputFileInfo = new FileInfo(files[i]);
                    DateTime lastCreated = File.GetCreationTime(files[i]);
                    DateTime lastModified = inputFileInfo.LastWriteTime;
                    DateTime lastAccessed = inputFileInfo.LastAccessTime;

                    File.SetCreationTime(outputFile, lastCreated);
                    File.SetLastWriteTime(outputFile, lastModified);
                    File.SetLastAccessTime(outputFile, lastAccessed);
                }
                else
                {
                    Console.WriteLine($"Skipping file: {outputFile} (already exists)");
                }

                stopwatch.Stop();

                totalSeconds += stopwatch.Elapsed.Milliseconds / 1000.0f;

                float total = (totalSeconds / (i + 1)) * (files.Length - (i + 1));

                int hours = (int)(total / 3600);
                int minutes = (int)((total % 3600) / 60);
                int seconds = (int)(total % 60);
                string time = $"{hours:D2}:{minutes:D2}:{seconds:D2}";

                progressText = $"{(i + 1)}/{files.Length} - {(((float)(i + 1) / files.Length) * 100).ToString("0.00")}% - {time}";
            }

            Console.Title = progressText;

            Console.WriteLine("DONE!");
            Console.ReadKey();
        }

        private static void StartProcess(string processName, string arguments, string windowTitle, bool displayOutput, bool pauseOutput)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "cmd.exe";
            processInfo.Arguments = (pauseOutput ? "/k " : "/c ") + " title " + windowTitle + " & " + processName + " " + arguments;
            processInfo.CreateNoWindow = !displayOutput;
            processInfo.UseShellExecute = false;

            Process process = new Process();
            process.StartInfo = processInfo;
            process.Start();
            process.WaitForExit();
        }

        private static void CloneDirectory(string directory)
        {
            string fromPathFolderName = Path.GetFileName(directory);
            int fromPathLength = directory.Length;

            DirectoryInfo directoryInfo = new DirectoryInfo(directory);

            foreach (DirectoryInfo folder in directoryInfo.GetDirectories("*", SearchOption.AllDirectories))
            {
                string relativePath = folder.FullName.Substring(fromPathLength + 1);
                Directory.CreateDirectory($"output\\{fromPathFolderName}\\{relativePath}");
            }
        }
    }
}