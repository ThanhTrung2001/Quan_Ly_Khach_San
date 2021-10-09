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
            BillLoad();
        }

        #region Room
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

        private void RoomRequestBtn_Click(object sender, EventArgs e)
        {
            if(RoomTxb.Text == "" || CustomerSelect.Text == "")
            {
                MessageBox.Show("Fill full information !");
            }
            else if(StatusTxb.Text == "Hired")
            {
                MessageBox.Show("Room is hired !");
            } else
            {


                HoaDonPhong hoaDon = new HoaDonPhong();
                hoaDon.MaHoaDon = "R" + getRandomID();
                //hoaDon.NgayLap = DateTime.Now.ToString();
                //hoaDon.Checkin = checkInDpk.Value.ToString();
                //hoaDon.Checkout = checkOutDpk.Value.ToString();
                hoaDon.MaKH = this.CustomerSelect.Text;
                hoaDon.MaPhong = RoomTxb.Text;
                hoaDon.TongTien = Double.Parse(this.RoomPriceTxb.Text);
                hoaDon.TienNhan = 0.0;
                hoaDon.TienThua = 0.0;
                hoaDon.MaTinhTrang = "Pe";

                if (HoaDonPhong_BUS.AddNewBill(hoaDon))
                {
                    HoaDonPhong_BUS.UpdateRoom(RoomTxb.Text);
                    MessageBox.Show("Successfully. Click 'OK' to continue !");
                    BillLoad();
                }
            }
        }

        private string getRandomID()
        {
            return String.Format("{0:d8}", (DateTime.Now.Ticks / 10) % 1000000000);
        }
        #endregion

        #region Request
        private void BillLoad()
        {
            List<HoaDonPhong> roomBillList = HoaDonPhong_BUS.RoomBillPendingList();
            if (roomBillList == null) roomBillList = new List<HoaDonPhong>();
            this.RoomBillDgv.DataSource = roomBillList;
        }
        #endregion
    }
}
