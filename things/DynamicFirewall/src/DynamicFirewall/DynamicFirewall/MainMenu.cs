using System;
using System.IO;
using System.Net;
using System.Timers;
using System.Windows.Forms;

using NetFwTypeLib;

namespace DynamicFirewall
{
    public partial class MainMenu : Form
    {
        private string ruleName = "DYNAMIC_FIREWALL_RULES";
        readonly System.Timers.Timer updateTimer = new System.Timers.Timer();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (File.Exists("addresses.txt"))
                AddressTextBox.Text = File.ReadAllText("addresses.txt");

            updateTimer.Elapsed += new ElapsedEventHandler(UpdateFirewall);
            updateTimer.Interval = 20000;
            updateTimer.Enabled = true;
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("addresses.txt", AddressTextBox.Text);

/*            DeleteFirewallRule(ruleName);*/
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            UpdateFirewall(null, null);
        }

        private string GetIPAddresses(string[] rawAddresses)
        {
            string addressesFormatted = "";

            foreach (string addressRaw in rawAddresses)
            {
                try
                {
                    IPAddress[] addresses = Dns.GetHostAddresses(addressRaw);
                    foreach (IPAddress address in addresses)
                    {
                        addressesFormatted += address + ",";
                        Console.WriteLine($"Got address: " + address);
                    }
                }
                catch
                {
                    continue;
                }
            }

            addressesFormatted = addressesFormatted.Substring(0, addressesFormatted.Length - 1);

            Console.WriteLine($"Formatted Addresses: " + addressesFormatted);

            return addressesFormatted;
        }

        private void UpdateFirewallRules(string addresses)
        {
            DeleteFirewallRule(ruleName);

            Console.WriteLine($"Deleted rule: " + ruleName);

            Type type = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            dynamic fwPolicy2 = Activator.CreateInstance(type);

            INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));

            firewallRule.Name = ruleName;
            firewallRule.Description = "Block outbound traffic to " + addresses;
            firewallRule.RemoteAddresses = addresses;
            firewallRule.InterfaceTypes = "All";
            firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            firewallRule.Enabled = true;

            fwPolicy2.Rules.Add(firewallRule);

            Console.WriteLine($"Created new rule: " + firewallRule);
        }

        private void DeleteFirewallRule(string ruleName)
        {
            Type type = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            dynamic fwPolicy2 = Activator.CreateInstance(type);

            try
            {
                // retrieve the Rules collection
                INetFwRules rules = fwPolicy2.Rules;

                // iterate through the rules to find the one with the specified name
                foreach (INetFwRule rule in rules)
                {
                    if (rule.Name == ruleName)
                    {
                        // remove the rule
                        rules.Remove(rule.Name);
                        break;
                    }
                }
            }
            catch
            {

            }
        }

        private void AutoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateTimer.Enabled = AutoCheckBox.Checked;
        }

        private void UpdateFirewall(object source, ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now);
            Invoke((MethodInvoker)delegate
                {
                    string[] rawAddresses = AddressTextBox.Text.Split('\n');
                    string addresses = GetIPAddresses(rawAddresses);
                    UpdateFirewallRules(addresses);
                });
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }
    }
}