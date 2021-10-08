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

        private void ShowRoom(string idPhong)
        {
            Phong phong = Phong_BUS.RoomList(idPhong);
            if (phong == null)
            {
                this.RoomTxb.Text = "";
                return;
            }
            this.RoomTxb.Text = phong.MaPhong;
            this.TypeTxb.Text = phong.LoaiPhong;
            this.StatusTxb.Text = phong.TinhTrang;
            this.RoomPriceTxb.Text = phong.Gia.ToString();
        }

        private void p101_Click(object sender, EventArgs e)
        {
            ShowRoom("P101");
        }

        private void p102_Click(object sender, EventArgs e)
        {
            ShowRoom("P102");
        }

        private void p103_Click(object sender, EventArgs e)
        {
            ShowRoom("P103");
        }

        private void p104_Click(object sender, EventArgs e)
        {
            ShowRoom("P104");
        }

        private void p105_Click(object sender, EventArgs e)
        {
            ShowRoom("P105");
        }

        private void p106_Click(object sender, EventArgs e)
        {
            ShowRoom("P106");
        }

        private void p201_Click(object sender, EventArgs e)
        {
            ShowRoom("P201");
        }

        private void p202_Click(object sender, EventArgs e)
        {
            ShowRoom("P202");
        }

        private void p203_Click(object sender, EventArgs e)
        {
            ShowRoom("P203");
        }

        private void p204_Click(object sender, EventArgs e)
        {
            ShowRoom("P204");
        }

        private void p205_Click(object sender, EventArgs e)
        {
            ShowRoom("P205");
        }

        private void p206_Click(object sender, EventArgs e)
        {
            ShowRoom("P206");
        }

        private void p301_Click(object sender, EventArgs e)
        {
            ShowRoom("P301");
        }

        private void p302_Click(object sender, EventArgs e)
        {
            ShowRoom("P302");
        }

        private void p303_Click(object sender, EventArgs e)
        {
            ShowRoom("P303");
        }

        private void p304_Click(object sender, EventArgs e)
        {
            ShowRoom("P304");
        }

        private void p401_Click(object sender, EventArgs e)
        {
            ShowRoom("P401");
        }

        private void p402_Click(object sender, EventArgs e)
        {
            ShowRoom("P402");
        }

        private void p403_Click(object sender, EventArgs e)
        {
            ShowRoom("P403");
        }

        private void p404_Click(object sender, EventArgs e)
        {
            ShowRoom("P404");
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
