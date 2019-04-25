using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Management;
using System.Security;

namespace ikb1.remoteinfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ipBox.Text = "10.30.125.1";
            GetWMIClasses();
        }

        ManagementScope PCscope;
        string ip = "1.1.1.1";

        class WMIInfo
        {
            public string Win32;
            public string Win32Name;
            public Dictionary<string, string> Names;
        }

        private void InfoWMI(List<WMIInfo> names, ManagementScope scope)
        {
            outputBox.AppendText(Environment.NewLine);
            foreach (var n in names)
            {
                string n1 = string.Join(",", n.Names.Select(x => x.Value));
                outputBox.AppendText(n.Win32Name + "\n");
                ObjectQuery query = new ObjectQuery($"SELECT {n1} FROM {n.Win32}");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject m in queryCollection)
                {
                    foreach (var i in n.Names)
                    {
                        if (m[i.Value] != null) outputBox.AppendText(i.Key + ": " + Result(m, i.Value) + "\n");
                    }
                }
            }
        }

        private string Result(ManagementObject m, string value)
        {
            if (value == "Size" || value == "Capacity" || value == "FreeSpace" || value == "AdapterRAM") return ConvertToGB(m, value);
            return m[value].ToString();
        }

        private string ConvertToGB(ManagementObject m, string value) => Math.Round(System.Convert.ToDouble(m[value]) / 1024 / 1024 / 1024, 2).ToString() + " Gb";

        private void connectBtn_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void Connect()
        {
            outputBox.Clear();
            ip = ipBox.Text.Replace(",", ".");
            ConnectionOptions options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                EnablePrivileges = true,
                Username = userBox.Text
            };
            SecureString securepassword = new SecureString();
            foreach (char c in passBox.Text)
            {
                securepassword.AppendChar(c);
            }
            options.SecurePassword = securepassword;
            PCscope = new ManagementScope($"\\\\{ip}\\root\\cimv2", options);
            try
            {
                PCscope.Connect();
                outputBox.AppendText("Подключено к " + ip);
                statuslabel.Text = "Подключено";
                statuslabel.ForeColor = System.Drawing.Color.Green;
                connectBtn.Enabled = false;
                disconnectBtn.Enabled = true;
                wmiBox.Enabled = true;
                CmdBox.Enabled = true;
            }
            catch (Exception ex)
            {
                outputBox.AppendText("Не удалось подключиться: " + ex.Message);
            }
            securepassword.Dispose();
        }

        private void GetInfo()
        {
            List<WMIInfo> names = new List<WMIInfo>();
            Dictionary<string, string> Nm = new Dictionary<string, string>();
            foreach (var pr in propsBox.CheckedItems) Nm.Add(pr.ToString(), pr.ToString());
            names.Add(new WMIInfo
            {
                Win32Name = wmiclass.SelectedItem.ToString(),
                Win32 = wmiclass.SelectedItem.ToString(),
                Names = Nm
            });
            InfoWMI(names, PCscope);
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            PCscope = null;
            disconnectBtn.Enabled = false;
            connectBtn.Enabled = true;
            statuslabel.Text = "Отключено";
            statuslabel.ForeColor = System.Drawing.Color.Red;
            wmiBox.Enabled = false;
            CmdBox.Enabled = false;
        }

        private void GetWMIClasses()
        {
            wmiclass.Items.Clear();
            using (ManagementObjectSearcher moSearcher = new ManagementObjectSearcher("SELECT * FROM meta_class"))
            {
                foreach (ManagementObject mo in moSearcher.Get())
                {
                    if (mo.ClassPath.ClassName.StartsWith("Win32_")) wmiclass.Items.Add(mo.ClassPath.ClassName);
                }
            }
        }

        private void wmiclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            propsBox.Items.Clear();
            PrintPropertiesOfWmiClass("root\\cimv2", wmiclass.SelectedItem.ToString());
            wmiCmdList.Items.Clear();
            GetExecutes(PCscope, wmiclass.SelectedItem.ToString());
        }

        private void PrintPropertiesOfWmiClass(string namespaceName, string wmiClassName)
        {
            wmiclass.Enabled = false;
            ManagementPath managementPath = new ManagementPath();
            managementPath.Path = namespaceName;
            ManagementScope managementScope = new ManagementScope(managementPath);
            ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM " + wmiClassName);
            ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            ManagementObjectCollection objectCollection = objectSearcher.Get();
            foreach (ManagementObject managementObject in objectCollection)
            {
                PropertyDataCollection props = managementObject.Properties;
                foreach (PropertyData prop in props)
                    propsBox.Items.Add(prop.Name);
            }
            wmiclass.Enabled = true;
        }

        private void GetExecutes(ManagementScope scope, string wmiClassName)
        {
            wmiclass.Enabled = false;
            var wmiProcess = new ManagementClass(scope, new ManagementPath(wmiClassName), new ObjectGetOptions());
            if (wmiProcess.Methods.Count != 0 || wmiProcess.Methods != null)
            {                
                foreach (var m in wmiProcess.Methods)
                    wmiCmdList.Items.Add(m.Name);                
            }
            wmiclass.Enabled = true;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog log = new SaveFileDialog();
            log.Filter = "Text files(*.txt)|*.txt";
            if (log.ShowDialog() == DialogResult.OK)
            {
                try { outputBox.SaveFile(log.FileName); }
                catch (Exception ex) { outputBox.AppendText(Environment.NewLine + "Ошибка сохранения файла: " + ex.Message); }
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
        }

        private void wmiCmdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmiclass.Enabled = false;
            testOutput.Clear();
            var wmiProcess = new ManagementClass(PCscope, new ManagementPath(wmiclass.SelectedItem.ToString()), new ObjectGetOptions());
            foreach (var m in wmiProcess.Methods)
            {
                if (m.Name == wmiCmdList.SelectedItem.ToString() && m.InParameters != null && m.InParameters.Properties != null)
                {
                    foreach (var pr in m.InParameters.Properties)
                        testOutput.AppendText(pr.Name + Environment.NewLine);
                }
            }
            wmiclass.Enabled = true;
        }
    }
}
