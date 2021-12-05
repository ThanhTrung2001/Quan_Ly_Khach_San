using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Quan_Ly_Khach_San.GUI
{
    public partial class Add_Supplier_Form : Form
    {
        public Add_Supplier_Form()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (this.SupplierNameTxb.Text == "" ||
                this.SupplierAddressTxb.Text == "" ||
                this.SupplierEmailTxb.Text == "" ||
                this.SupplierPhoneNumberxb.Text == "")
            {
                MessageBox.Show("Please enter full information");
                return;
            }

            DaiLy daiLy = new DaiLy();
            daiLy.MaDL = "S" + getRandomID();
            daiLy.TenDL = this.SupplierNameTxb.Text;
            daiLy.DiaChi = this.SupplierAddressTxb.Text;
            daiLy.SDT1 = this.SupplierPhoneNumberxb.Text;
            daiLy.Email = this.SupplierEmailTxb.Text;
            if (this.SupplierNoteText.Text == "")
                daiLy.GhiChu = "none";
            else
                daiLy.GhiChu = this.SupplierNoteText.Text;

            if (DaiLy_BUS.AddNewSupplier(daiLy))
            {
                this.Clear();
                MessageBox.Show("Add new supplier successfully");
            }
        }

        private void Clear()
        {
            this.SupplierNameTxb.Clear();
            this.SupplierAddressTxb.Clear();
            this.SupplierPhoneNumberxb.Clear();
            this.SupplierEmailTxb.Clear();
            this.SupplierNoteText.Clear();
        }

        private string getRandomID()
        {
            return String.Format("{0:d8}", (DateTime.Now.Ticks / 10) % 1000000000);
        }

        private void SupplierPhoneNumberxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (this.SupplierPhoneNumberxb.Text.Length > 10 && !Char.IsControl(e.KeyChar)) e.Handled = true;
            }
        }

        private void Add_Supplier_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            return;
        }
    }
}
