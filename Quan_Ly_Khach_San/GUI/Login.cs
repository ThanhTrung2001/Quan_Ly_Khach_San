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
    public partial class Login : Form
    {
        public int role;
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UserNameTxb.Text == "thukho" && PasswordTxb.Text == "123456")
            {
                role =4;
                Home form = new Home(role);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else if (UserNameTxb.Text == "daubep" && PasswordTxb.Text == "123456")
            {
                role = 3;
                Home form = new Home(role);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else if (UserNameTxb.Text == "letan" && PasswordTxb.Text == "123456")
            {
                role = 2;
                Home form = new Home(role);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else if (UserNameTxb.Text == "ketoan" && PasswordTxb.Text == "123456")
            {
                role = 1;
                Home form = new Home(role);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else if (UserNameTxb.Text == "giamdoc" && PasswordTxb.Text == "admin")
            {
                role = 0;
                Home form = new Home(role);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            /*Home form = new Home();
            this.Hide();
            form.ShowDialog();
            this.Close();*/
        }
    }
}
