using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void RoomMangaeBtn_Click(object sender, EventArgs e)
        {
            PanelParent.Controls.Clear();
            Room_Manage child = new Room_Manage() { TopLevel = false, TopMost = true };
            PanelParent.Controls.Add(child);
            child.Show();
        }
        private void KitchenManageBtn_Click(object sender, EventArgs e)
        {
            PanelParent.Controls.Clear();
            Storage_Manage child = new Storage_Manage() { TopLevel = false, TopMost = true };
            PanelParent.Controls.Add(child);
            child.Show();
        }

        private void ServicesManageBtn_Click(object sender, EventArgs e)
        {
            PanelParent.Controls.Clear();
            Services_Manage child = new Services_Manage() { TopLevel = false, TopMost = true };
            PanelParent.Controls.Add(child);
            child.Show();
        }

        private void RiskManageBtn_Click(object sender, EventArgs e)
        {
            PanelParent.Controls.Clear();
            Risk_Manage child = new Risk_Manage() { TopLevel = false, TopMost = true };
            PanelParent.Controls.Add(child);
            child.Show();
        }

        private void StatisticManageBtn_Click(object sender, EventArgs e)
        {
            PanelParent.Controls.Clear();
            Statistic_Manage child = new Statistic_Manage() { TopLevel = false, TopMost = true };
            PanelParent.Controls.Add(child);
            child.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you want to log out ?" , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
