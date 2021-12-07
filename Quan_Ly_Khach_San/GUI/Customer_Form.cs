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
    public partial class Customer_Form : Form
    {
        public Customer_Form()
        {
            InitializeComponent();
        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            reset();
        }

        private void reset()
        {
            this.CustomerIdentityTxb.Text = "";
            this.CustomerNameTxb.Text = "";
            this.CustomerPhonetxb.Text = "";
            this.CustomerIdentityTxb.Text = "";
            this.CustomerAddress.Text = "";
            this.CustomerNoteTxb.Text = "";
        }

        private void LoadCustomer()
        {
            List<KhachHang> customerList = KhachHang_BUS.CustomerList();
            if (customerList == null) customerList = new List<KhachHang>();
            this.CustomerGrid.DataSource = customerList;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if(this.CustomerNameTxb.Text == "" || this.CustomerIdentityTxb.Text == "")
            {
                MessageBox.Show("Enter customer name and customer indentify numbers");
                return;
            }

            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = this.CustomerIdentityTxb.Text;
            khachHang.TenKhachHang = this.CustomerNameTxb.Text.ToUpper();
            khachHang.SDT = this.CustomerPhonetxb.Text;
            khachHang.CMND = this.CustomerIdentityTxb.Text;
            khachHang.DiaChi = this.CustomerAddress.Text;
            khachHang.GhiChu = this.CustomerNoteTxb.Text;

            List<KhachHang> list = KhachHang_BUS.SearchedCustomer(khachHang.MaKH);

            if ( list == null)
            {
                if (KhachHang_BUS.AddNewCustomer(khachHang)) 
                    MessageBox.Show("Added new customer");
            }
            else
            {
                if (KhachHang_BUS.UpdateCustomer(khachHang))
                {
                    MessageBox.Show("Updated customer");
                }
            }

            Customer_Form_Load(null, null); 
}


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string maKH = this.CustomerIdentityTxb.Text;
            if(maKH == "")
            {
                MessageBox.Show("Enter Identify number");
                return;
            }

            if (KhachHang_BUS.DeleteCustomer(maKH))
            {
                MessageBox.Show("Deleted");
                Customer_Form_Load(null, null);
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }


        private void Search()
        {
            List<KhachHang> list;
            string searchString = this.SearchTxb.Text;
            if (searchString == "")
            {
                list = KhachHang_BUS.CustomerList();
            } else
            {
                list = KhachHang_BUS.SearchedCustomer(searchString);
            }

            if (list == null) list = new List<KhachHang>();

            CustomerGrid.DataSource = list;
        }

        private void SearchTxb_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void CustomerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get id Customer
            ClassPublic.Customerid = CustomerGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            //
            this.CustomerNameTxb.Text = CustomerGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.CustomerPhonetxb.Text = CustomerGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.CustomerIdentityTxb.Text = CustomerGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.CustomerAddress.Text = CustomerGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.CustomerNoteTxb.Text = CustomerGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void CustomerPhonetxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            } else
            {
                if (this.CustomerPhonetxb.Text.Length > 10 && !Char.IsControl(e.KeyChar)) e.Handled = true;
            }
        }

        private void CustomerIdentityTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FoodNavigationBtn_Click(object sender, EventArgs e)
        {
            ClassPublic.NavigationVar = "Food";
            MessageBox.Show("Apply Success. Please go to Food Form");
        }

        private void RoomNavigationBtn_Click(object sender, EventArgs e)
        {
            ClassPublic.NavigationVar = "Room";
            MessageBox.Show("Apply Success. Please go to Room Form");
        }

        private void ServiceNavigationBtn_Click(object sender, EventArgs e)
        {
            ClassPublic.NavigationVar = "Service";
            MessageBox.Show("Apply Success. Please go to Service Form");
        }
    }
}
