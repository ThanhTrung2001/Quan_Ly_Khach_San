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
            LoadRisk();
            Room101ColorLoad();
            Room102ColorLoad();
            Room103ColorLoad();
            Room104ColorLoad();
            Room105ColorLoad();
            Room106ColorLoad();

            Room201ColorLoad();
            Room202ColorLoad();
            Room203ColorLoad();
            Room204ColorLoad();
            Room205ColorLoad();
            Room206ColorLoad();

            Room301ColorLoad();
            Room302ColorLoad();
            Room303ColorLoad();
            Room304ColorLoad();

            Room401ColorLoad();
            Room402ColorLoad();
            Room403ColorLoad();
            Room404ColorLoad();
        }

        #region Room

        #region ColorRoom
        //Tang 1

        void Room101ColorLoad()
        {
            if(Phong_BUS.CheckEmptyHired("P101"))
            {
                p101.BackColor = Color.LightGreen;
            } else
            {
                p101.BackColor = Color.LightSalmon;
            }
        }
        void Room102ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P102"))
            {
                p102.BackColor = Color.LightGreen;
            }
            else
            {
                p102.BackColor = Color.LightSalmon;
            }
        }
        void Room103ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P103"))
            {
                p103.BackColor = Color.LightGreen;
            }
            else
            {
                p103.BackColor = Color.LightSalmon;
            }
        }
        void Room104ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P104"))
            {
                p104.BackColor = Color.LightGreen;
            }
            else
            {
                p104.BackColor = Color.LightSalmon;
            }
        }
        void Room105ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P105"))
            {
                p105.BackColor = Color.LightGreen;
            }
            else
            {
                p105.BackColor = Color.LightSalmon;
            }
        }
        void Room106ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P106"))
            {
                p106.BackColor = Color.LightGreen;
            }
            else
            {
                p106.BackColor = Color.LightSalmon;
            }
        }

        // Tang 2
        void Room201ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P201"))
            {
                p201.BackColor = Color.LightGreen;
            }
            else
            {
                p201.BackColor = Color.LightSalmon;
            }
        }

        void Room202ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P202"))
            {
                p202.BackColor = Color.LightGreen;
            }
            else
            {
                p202.BackColor = Color.LightSalmon;
            }
        }
        void Room203ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P203"))
            {
                p203.BackColor = Color.LightGreen;
            }
            else
            {
                p203.BackColor = Color.LightSalmon;
            }
        }
        void Room204ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P204"))
            {
                p204.BackColor = Color.LightGreen;
            }
            else
            {
                p204.BackColor = Color.LightSalmon;
            }
        }
        void Room205ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P205"))
            {
                p205.BackColor = Color.LightGreen;
            }
            else
            {
                p205.BackColor = Color.LightSalmon;
            }
        }
        void Room206ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P206"))
            {
                p206.BackColor = Color.LightGreen;
            }
            else
            {
                p206.BackColor = Color.LightSalmon;
            }
        }

        //Tang 3

        void Room301ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P301"))
            {
                p301.BackColor = Color.LightGreen;
            }
            else
            {
                p301.BackColor = Color.LightSalmon;
            }
        }
        void Room302ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P302"))
            {
                p302.BackColor = Color.LightGreen;
            }
            else
            {
                p302.BackColor = Color.LightSalmon;
            }
        }
        void Room303ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P303"))
            {
                p303.BackColor = Color.LightGreen;
            }
            else
            {
                p303.BackColor = Color.LightSalmon;
            }
        }
        void Room304ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P304"))
            {
                p304.BackColor = Color.LightGreen;
            }
            else
            {
                p304.BackColor = Color.LightSalmon;
            }
        }

        //Tang 4

        void Room401ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P401"))
            {
                p401.BackColor = Color.LightGreen;
            }
            else
            {
                p401.BackColor = Color.LightSalmon;
            }
        }
        void Room402ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P402"))
            {
                p402.BackColor = Color.LightGreen;
            }
            else
            {
                p402.BackColor = Color.LightSalmon;
            }
        }
        void Room403ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P403"))
            {
                p403.BackColor = Color.LightGreen;
            }
            else
            {
                p403.BackColor = Color.LightSalmon;
            }
        }
        void Room404ColorLoad()
        {
            if (Phong_BUS.CheckEmptyHired("P404"))
            {
                p404.BackColor = Color.LightGreen;
            }
            else
            {
                p404.BackColor = Color.LightSalmon;
            }
        }

        #endregion


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

            //
            if (ClassPublic.NavigationVar == "Room")
            {
                this.CustomerSelect.Text = ClassPublic.Customerid;
                ClassPublic.NavigationVar = "";
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
                hoaDon.Checkin = DateTime.Now.ToString();
                hoaDon.Checkout = DateTime.Now.AddDays(int.Parse(numberDayUpDown.Value.ToString())).ToString();
                hoaDon.MaKH = this.CustomerSelect.Text;
                hoaDon.MaPhong = RoomTxb.Text;
                hoaDon.SoNgayO = int.Parse(numberDayUpDown.Value.ToString());
                hoaDon.TongTien = Double.Parse(this.RoomPriceTxb.Text) * hoaDon.SoNgayO;
                hoaDon.TienNhan = 0.0;
                hoaDon.TienThua = 0.0;
                hoaDon.MaTinhTrang = "Pe";

                if (HoaDonPhong_BUS.AddNewBill(hoaDon))
                {   
                    HoaDonPhong_BUS.UpdateRoom(RoomTxb.Text);
                    MessageBox.Show("Successfully. Click 'OK' to continue !");
                    BillLoad();

                    ShowRoom(RoomTxb.Text);
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

        private void RoomBillDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = RoomBillDgv.CurrentRow.Index;
            this.roomBillId.Text = RoomBillDgv.Rows[i].Cells[0].Value.ToString();
            this.checkInDate.Text = RoomBillDgv.Rows[i].Cells[1].Value.ToString();
            this.checkOutDate.Text = RoomBillDgv.Rows[i].Cells[2].Value.ToString();
            this.customerId.Text = RoomBillDgv.Rows[i].Cells[4].Value.ToString();
            this.roomId.Text = RoomBillDgv.Rows[i].Cells[5].Value.ToString();
            this.dayNumber.Text = RoomBillDgv.Rows[i].Cells[6].Value.ToString();
            this.totalPriceTxb.Text = RoomBillDgv.Rows[i].Cells[7].Value.ToString();
        }

        private void LoadRisk()
        {
            List<RuiRo> riskList = RuiRo_BUS.RiskList();
            if (riskList == null) riskList = new List<RuiRo>();
            this.riskDgv.DataSource = riskList;
        }

        private void riskDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = riskDgv.CurrentRow.Index;
            this.risk.Text = riskDgv.Rows[i].Cells[0].Value.ToString();
            this.refundTxb.Text = riskDgv.Rows[i].Cells[2].Value.ToString();

            double refund = Double.Parse(this.refundTxb.Text);
            double total = Double.Parse(this.totalPriceTxb.Text);
            double re = total - refund;

            this.totalPriceTxb.Text = re.ToString();
        }

        private void receiveTxb_TextChanged(object sender, EventArgs e)
        {
            if (this.receiveTxb.Text == "") return;

            double receive = Double.Parse(this.receiveTxb.Text);
            double total = Double.Parse(this.totalPriceTxb.Text);
            double re = receive - total;

            if (re < 0)
                this.returnTxb.Text = "Not enough";
            else
                this.returnTxb.Text = re.ToString();
        }

        private void ConfirmRequestBtn_Click(object sender, EventArgs e)
        {
            if(receiveTxb.Text == "")
            {
                MessageBox.Show("Not enought Money !");
            }      
            else if (returnTxb.Text == "Not enough")
            {
                MessageBox.Show("Not enought Money !");
            }
            else
            {
                HoaDonPhong hoaDonPhong = new HoaDonPhong();
                hoaDonPhong.MaHoaDon = this.roomBillId.Text;
                hoaDonPhong.TongTien = double.Parse(this.totalPriceTxb.Text);
                hoaDonPhong.MaRR = this.risk.Text;
                hoaDonPhong.SoTienHoan = double.Parse(this.refundTxb.Text);
                hoaDonPhong.TienNhan = double.Parse(this.receiveTxb.Text);
                hoaDonPhong.TienThua = double.Parse(this.returnTxb.Text);
                hoaDonPhong.GhiChu = this.noteRoomBill.Text;
                hoaDonPhong.MaTinhTrang = "Co";

                if (HoaDonPhong_BUS.UpdateRoomBill(hoaDonPhong))
                {
                    HoaDonPhong_BUS.UpdateRoomAfter(roomId.Text);
                    MessageBox.Show("Payment completed");
                    BillLoad();

                    roomBillId.Text = "";
                    customerId.Text = "";
                    roomId.Text = "";
                    dayNumber.Text = "";
                    risk.Text = "";
                    refundTxb.Text = "";
                    totalPriceTxb.Text = "";
                    receiveTxb.Text = "";
                    returnTxb.Text = "";
                    noteRoomBill.Text = "";
                }
            }          
        }
        
        private void CancelRequestBtn_Click(object sender, EventArgs e)
        {
            roomBillId.Text = "";
            customerId.Text = "";
            roomId.Text = "";
            dayNumber.Text = "";
            risk.Text = "";
            refundTxb.Text = "";
            totalPriceTxb.Text = "";
            receiveTxb.Text = "";
            returnTxb.Text = "";
            noteRoomBill.Text = "";
        }
        #endregion

        private void Search()
        {
            List<HoaDonPhong> list;
            string searchString = this.searchPending.Text;
            if (searchString == "")
            {
                list = HoaDonPhong_BUS.RoomBillPendingList();
            }
            else
            {
                list = HoaDonPhong_BUS.SearchedHoaDonPhong(searchString);
            }

            if (list == null) list = new List<HoaDonPhong>();

            RoomBillDgv.DataSource = list;
        }

        private void searchPending_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
