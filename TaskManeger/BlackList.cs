using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManeger
{
    public partial class BlackList : Form
    {
        public BlackList()
        {
            InitializeComponent();
        }
        

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                 BlackListItems.BList.RemoveAt(BlckList.SelectedIndex);
                GetBlackList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetBlackList()
        {
            BlckList.Items.Clear();
            foreach (var bl in BlackListItems.BList)
            {
                BlckList.Items.Add(bl);
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtBoxItem.Text))
                {
                    BlackListItems.BList.Add(TxtBoxItem.Text);
                    TxtBoxItem.Clear();
                    GetBlackList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
