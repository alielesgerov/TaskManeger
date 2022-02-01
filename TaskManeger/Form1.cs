using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManeger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] process;

        public void GetAllProcess()
        {
            process= Process.GetProcesses()
                .OrderBy(p => p.ProcessName)
                .ToArray();
            PrcList.Items.Clear();
            foreach (Process p in process)
            {
                PrcList.Items.Add($"{p.ProcessName} - {p.Id}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void BtnEndTask_Click(object sender, EventArgs e)
        {
            try
            {
                process[PrcList.SelectedIndex].Kill();
                GetAllProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnStartPrc_Click(object sender, EventArgs e)
        {
           using(RunTask runTask = new RunTask())
           {
                if(runTask.ShowDialog() == DialogResult.OK)
                    GetAllProcess();
           }
        }

        private void blackListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BlackList blackList = new BlackList())
            {
                if (blackList.ShowDialog()==DialogResult.OK)
                    GetAllProcess();
            }
        }
    }
}
