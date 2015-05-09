using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace lab1
{
    public partial class FormTaskManager : Form
    {
        public FormTaskManager()
        {
            InitializeComponent();
            treeView1.Nodes.Add("Processes");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.BeginUpdate();
            treeView1.Nodes[0].Nodes.Clear();

            var allProcesses = Process.GetProcesses().OrderBy(x => x.ProcessName).ToArray();
            treeView1.Nodes[0].Text = "Processes (" + allProcesses.Length + ")";

            foreach (var process in allProcesses)
            {
                var processThreads = process.Threads;

                var nodeProcess = new TreeNode(string.Format("{0} [ID - {1}] priority: {4} ({2} threads) by {3}  {5}KB",
                    process.ProcessName, process.Id, processThreads.Count, GetProcessOwner(process.Id),
                    process.BasePriority, process.WorkingSet64 / 1024));

                foreach (ProcessThread thread in processThreads)
                {
                    nodeProcess.Nodes.Add(string.Format("{0} - {1}", thread.Id, thread.ThreadState));
                }
                treeView1.Nodes[0].Nodes.Add(nodeProcess);
            }
            treeView1.Nodes[0].Expand();
            treeView1.EndUpdate();
        }

        private void FormTaskManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                button1.PerformClick();
            }
        }

        private void FormTaskManager_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private static string GetProcessOwner(int processId)
        {
            string query = "Select * From Win32_Process Where ProcessID = " + processId;

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            using (ManagementObjectCollection processList = searcher.Get())
            foreach (ManagementObject obj in processList)
            {
                string[] argList = { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0)
                {
                    return argList[0];
                }
            }
            return "NO OWNER";
        }
    }
}