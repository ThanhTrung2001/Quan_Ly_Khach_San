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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            //
        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {
            ParentPanel.Controls.Clear();
            Room_Service_Form form = new Room_Service_Form();
            form.TopLevel = false;
            ParentPanel.Controls.Add(form);
            form.Show();
        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {
            ParentPanel.Controls.Clear();
            Food_Form form1 = new Food_Form();
            form1.TopLevel = false;
            ParentPanel.Controls.Add(form1);
            form1.Show();
           
        }

        private void RiskBtn_Click(object sender, EventArgs e)
        {
            ParentPanel.Controls.Clear();
            Risk_Form form2 = new Risk_Form();
            form2.TopLevel = false;
            ParentPanel.Controls.Add(form2);
            form2.Show();
           
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            ParentPanel.Controls.Clear();
            Customer_Form form3 = new Customer_Form();
            form3.TopLevel = false;
            ParentPanel.Controls.Add(form3);
            form3.Show();
          
        }

        private void StatisticBtn_Click(object sender, EventArgs e)
        {
            ParentPanel.Controls.Clear();
            Statistic_Form form4 = new Statistic_Form();
            form4.TopLevel = false;
            ParentPanel.Controls.Add(form4);
            form4.Show();
           
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to log out?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Login form = new Login();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to exit program?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            } 
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }
    }
}
