using BUS;
using DTO;
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
    public partial class Add_Customer_Form : Form
    {
        public Add_Customer_Form()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (this.CustomerNameTxb.Text == "" || this.CustomerIdentityTxb.Text == "")
            {
                MessageBox.Show("Enter customer name and customer indentify numbers");
                return;
            }

            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = this.CustomerIdentityTxb.Text;
            khachHang.TenKhachHang = this.CustomerNameTxb.Text.ToUpper();
            khachHang.SDT = this.CustomerPhoneNumberTxb.Text;
            khachHang.CMND = this.CustomerIdentityTxb.Text;
            khachHang.DiaChi = this.CustomerAddress.Text;
            khachHang.GhiChu = this.CustomerNote.Text;

            if (KhachHang_BUS.AddNewCustomer(khachHang))
            {
                MessageBox.Show("Added new customer");
                this.Close();
                return;
            }

            MessageBox.Show("Something went wrong");
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerPhoneNumberTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (this.CustomerPhoneNumberTxb.Text.Length > 10 && !Char.IsControl(e.KeyChar)) e.Handled = true;
            }
        }

        private void CustomerIdentityTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
