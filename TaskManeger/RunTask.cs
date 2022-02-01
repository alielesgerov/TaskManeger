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
using System.Threading;


namespace TaskManeger
{
    public partial class RunTask : Form
    {
        public RunTask()
        {
            InitializeComponent();
        }
        

        private void BtnRun_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo = new ProcessStartInfo(textBox1.Text);
                    process.Start();
                    
                    if(BlackListItems.BList.Contains(textBox1.Text))
                    {
                        Thread.Sleep(3000);
                        process.Kill();
                        throw new Exception("This process blacklisted");
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
