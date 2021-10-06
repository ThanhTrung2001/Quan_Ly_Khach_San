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
    public partial class Room_Service_Form : Form
    {
        public Room_Service_Form()
        {
            InitializeComponent();
        }

        private void Room_Service_Form_Load(object sender, EventArgs e)
        {
            CustomerLoad();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            Add_Customer_Form add = new Add_Customer_Form();
            add.ShowDialog();
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            Add_Customer_Form add = new Add_Customer_Form();
            add.ShowDialog();
        }

        private void p101_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "101";
            TypeTxb.Text = "Single";
            RoomPriceTxb.Text = "2000";
        }

        private void p102_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "102";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "2000";
        }

        private void p103_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "103";
            TypeTxb.Text = "Single";
            RoomPriceTxb.Text = "2000";
        }

        private void p104_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "104";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "5000";
        }

        private void p105_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "105";
            TypeTxb.Text = "Single";
            RoomPriceTxb.Text = "5000";
        }

        private void p106_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "106";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "5000";
        }

        private void p201_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "201";
            TypeTxb.Text = "Single";
            RoomPriceTxb.Text = "3200";
        }

        private void p202_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "202";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "7000";
        }

        private void p203_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "203";
            TypeTxb.Text = "Single";
            RoomPriceTxb.Text = "3200";
        }

        private void p204_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "204";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "7000";
        }

        private void p205_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "205";
            TypeTxb.Text = "Single";
            RoomPriceTxb.Text = "3200";
        }

        private void p206_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "204";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "7000";
        }

        private void p301_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "301";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "9000";
        }

        private void p302_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "302";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "9000";
        }

        private void p303_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "303";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "9000";
        }

        private void p304_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "304";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "9000";
        }

        private void p401_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "401";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "12500";
        }

        private void p402_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "402";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "12500";
        }

        private void p403_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "403";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "12500";
        }

        private void p404_Click(object sender, EventArgs e)
        {
            RoomTxb.Text = "404";
            TypeTxb.Text = "Double";
            RoomPriceTxb.Text = "12500";
        }

        private void CustomerLoad()
        {
            this.CustomerSelect.Items.Clear();
            List<KhachHang> list = KhachHang_BUS.CustomerList();
            if (list == null) return;
            this.CustomerSelect.ValueMember = "maKH";
            this.CustomerSelect.DisplayMember = "maKH";

            foreach (KhachHang khachHang in list)
            {
                this.CustomerSelect.Items.Add(khachHang);
            }
        }
    }
}
