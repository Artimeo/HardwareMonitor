using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace HardwareMonitor
{
    public partial class HardwareMonitor : Form
    {
        private double RamAvailable, RamFree;

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        private static bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        public static String TrimSpaces(String s)
        {
            StringBuilder sb = new StringBuilder(s);

            TrimSpaces(sb);

            return sb.ToString();
        }

        public static void TrimSpaces(StringBuilder sb)
        {
            if (sb.Length == 0)
                return;

            // set [start] to first not-whitespace char or to sb.Length

            int start = 0;

            while (start < sb.Length)
            {
                if (Char.IsWhiteSpace(sb[start]))
                    start++;
                else
                    break;
            }

            // if [sb] has only whitespaces, then return empty string

            if (start == sb.Length)
            {
                sb.Length = 0;
                return;
            }

            // set [end] to last not-whitespace char

            int end = sb.Length - 1;

            while (end >= 0)
            {
                if (Char.IsWhiteSpace(sb[end]))
                    end--;
                else
                    break;
            }

            // compact string

            int dest = 0;
            bool previousIsWhitespace = false;

            for (int i = start; i <= end; i++)
            {
                if (Char.IsWhiteSpace(sb[i]))
                {
                    if (!previousIsWhitespace)
                    {
                        previousIsWhitespace = true;
                        sb[dest] = ' ';
                        dest++;
                    }
                }
                else
                {
                    previousIsWhitespace = false;
                    sb[dest] = sb[i];
                    dest++;
                }
            }

            sb.Length = dest;
        }

        private static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }


        public HardwareMonitor()
        {
            InitializeComponent();

            CpuProgressBar.Maximum = 100;
            CpuNameLabel.Text = TrimSpaces(GetHardwareInfo("Win32_Processor", "Name").Single());
            CpuCoresLabel.Text = "Ядер: " + GetHardwareInfo("Win32_Processor", "NumberOfCores").Single();

            RamAvailable = Double.Parse(GetHardwareInfo("Win32_OperatingSystem", "TotalVisibleMemorySize").Single()) / 1048576;
            RamFree = Double.Parse(GetHardwareInfo("Win32_OperatingSystem", "FreePhysicalMemory").Single()) / 1048576;
            RamAvailableLabel.Text = "Всего памяти: " + RamAvailable.ToString().Substring(0, 4) + " Гб";
            RamFreeLabel.Text = "Доступно памяти: " + RamFree.ToString().Substring(0, 4) + " Гб";
            RamProgressBar.Maximum = (int)(RamAvailable * 1024);
            RamProgressBar.Value = (int)(RamFree * 1024);
            RamProgressBar.Update();
         
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                long full, free;
                full = drive.TotalSize / 1073741824;
                free = drive.AvailableFreeSpace / 1073741824;
                DiskDataGridView.Rows.Add(drive.Name, full, free, (free * 100 / full));
            }
            DiskCountLabel.Text += drives.Count().ToString();

            GpuNameLabel.Text += GetHardwareInfo("Win32_VideoController", "Name").Single();
            GpuMemorylabel.Text += (long.Parse(GetHardwareInfo("Win32_VideoController", "AdapterRAM").Single()) / 1048576).ToString() + " Мб";
            GpuDriverVersionLabel.Text += GetHardwareInfo("Win32_VideoController", "DriverVersion").Single();
            GpuResolutionLabel.Text += System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width.ToString() + "x" + System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height.ToString();

            if (IsConnectedToInternet())
            {
                InternetCheckBox.Text = "Подключен к интернету";
                InternetCheckBox.Checked = true;
            } else {
                InternetCheckBox.Text = "Нет подключения";
                InternetCheckBox.Checked = false;
            }

            ComputernameLabel.Text += System.Environment.MachineName;
            UsernameLabel.Text += System.Environment.UserName;
            OperatingSystemLabel.Text += GetHardwareInfo("Win32_OperatingSystem", "Caption").Single();
            OperatingSystemVersionLabel.Text += System.Environment.OSVersion.VersionString;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CpuProgressBar.Value = (int)CpuPerformanceCounter.NextValue();
            CpuLoadLabel.Text = CpuProgressBar.Value.ToString() + " %";
        }

        private void InternetRefreshButton_Click(object sender, EventArgs e)
        {
            if (IsConnectedToInternet())
            {
                InternetCheckBox.Text = "Подключен к интернету";
                InternetCheckBox.Checked = true;
            } else {
                InternetCheckBox.Text = "Нет подключения";
                InternetCheckBox.Checked = false;
            }
        }

        private void RamRefreshButton_Click(object sender, EventArgs e)
        {
            RamAvailable = Double.Parse(GetHardwareInfo("Win32_OperatingSystem", "TotalVisibleMemorySize").Single()) / 1048576;
            RamFree = Double.Parse(GetHardwareInfo("Win32_OperatingSystem", "FreePhysicalMemory").Single()) / 1048576;

            RamAvailableLabel.Text = "Всего памяти: " + RamAvailable.ToString().Substring(0, 4) + " Гб";
            RamFreeLabel.Text = "Доступно памяти: " + RamFree.ToString().Substring(0, 4) + " Гб";
            RamProgressBar.Maximum = (int)(RamAvailable * 1024);
            RamProgressBar.Value = (int)(RamFree * 1024);
            RamProgressBar.Update();
        }
    }
    
}
