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
            if (UserNameTxb.Text == "thukho")
            {
                if (PasswordTxb.Text == "123456")
                {
                    role = 4;
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK);
                    Home form = new Home(role);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You type the wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (UserNameTxb.Text == "daubep")
            {
                if (PasswordTxb.Text == "123456")
                {
                    role = 3;
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK);
                    Home form = new Home(role);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You type the wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (UserNameTxb.Text == "letan")
            {
                if (PasswordTxb.Text == "123456")
                {
                    role = 2;
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK);
                    Home form = new Home(role);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You type the wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (UserNameTxb.Text == "ketoan")
            {
                if (PasswordTxb.Text == "123456")
                {
                    role = 1;
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK);
                    Home form = new Home(role);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You type the wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (UserNameTxb.Text == "giamdoc")
            {
                if (PasswordTxb.Text == "admin")
                {
                    role = 0;
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK);
                    Home form = new Home(role);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You type the wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (UserNameTxb.Text == "")
            {
                if (PasswordTxb.Text != "")
                {
                    MessageBox.Show("You must type UserName!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("UserName & Password are null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You type the wrong UserName!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*Home form = new Home();
            this.Hide();
            form.ShowDialog();
            this.Close();*/
        }
    }
}
