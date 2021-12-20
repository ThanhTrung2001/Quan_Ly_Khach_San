using BUS;
using DTO;
using Quan_Ly_Khach_San.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Aspose.Words;
using Aspose.Words.Tables;
using ThuVienWinform.Report.AsposeWordExtension;

namespace Quan_Ly_Khach_San
{
    public partial class Statistic_Form : Form
    {
        public Statistic_Form()
        {
            InitializeComponent();
        }

        #region Supplier
        public void LoadSupplier()
        {
            this.SupplierNameCb.Items.Clear();
            List<DaiLy> list = DaiLy_BUS.SupplierList();
            if (list == null) list = new List<DaiLy>();

            this.SupplierNameCb.DataSource = list;

            this.SupplierNameCb.ValueMember = "MaDL";
            this.SupplierNameCb.DisplayMember = "TenDL";

            if (list != null)
            {
                //this.SupplierNameCb.SelectedIndex = 0;
            }
        }

        #endregion

        #region Food Request
        private void RequestFoodLoad()
        {
            BillLoad();
            this.FListRequestDGV.DataSource = new List<MonAn>();

            this.TotalPriceFoodTxb.Text = "0";
            this.ReturnMoneyTxb.Text = "0";

            this.SearchTextTxt.Text = "";

            this.StatusCbb.SelectedIndex = 0;
        }

        private void BillLoad()
        {
            List<HoaDonMonAn> foodList = HoaDonMonAn_BUS.BillPendingList();
            if (foodList == null) foodList = new List<HoaDonMonAn>();
            this.CustomerFoodDGV.DataSource = foodList;
        }

        private void CustomerFoodDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string dsID = CustomerFoodDGV.Rows[e.RowIndex].Cells["maDSMA"].Value.ToString();

            List<MonAn> foodList = ChiTietDanhSachMonAn_BUS.FoodList(dsID);
            if (foodList == null) foodList = new List<MonAn>();
            this.FListRequestDGV.DataSource = foodList;

            this.TotalPriceFoodTxb.Text = CustomerFoodDGV.Rows[e.RowIndex].Cells["tongTien"].Value.ToString();
        }

        private void ReceiveMoneyTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ReceiveMoneyTxb_TextChanged(object sender, EventArgs e)
        {
            if (this.ReturnMoneyTxb.Text == "") return;

            double receive = Double.Parse(this.ReceiveMoneyTxb.Text);
            double total = Double.Parse(this.TotalPriceFoodTxb.Text);
            double re = receive - total;

            if (re < 0)
                this.ReturnMoneyTxb.Text = "Not enough";
            else
                this.ReturnMoneyTxb.Text = re.ToString();
        }

        private void ConfirmRequest_Click(object sender, EventArgs e)
        {
            if (this.ReturnMoneyTxb.Text == "" || this.ReturnMoneyTxb.Text == "0")
                return;
            if (this.CustomerFoodDGV.SelectedRows.Count <= 0)
                return;

            HoaDonMonAn bill = new HoaDonMonAn();
            bill.NgayLap = DateTime.Now.ToString();
            bill.MaDSMA = this.CustomerFoodDGV.SelectedRows[0].Cells["maDSMA"].Value.ToString();
            bill.TienNhan = Double.Parse(this.ReturnMoneyTxb.Text);
            bill.TienThua = Double.Parse(this.ReceiveMoneyTxb.Text);
            bill.MaTinhTrang = "Co";

            if (HoaDonMonAn_BUS.UpdateBillPaid(bill))
            {
                RequestFoodLoad();
            }
        }


        List<HoaDonMonAn> foodList;
        private void UpdateDataGrid()
        {
            int status = this.StatusCbb.SelectedIndex;
            string searchText = this.SearchTextTxt.Text;

            if (status == 0)
            {
                foodList = HoaDonMonAn_BUS.BillPendingListWithCustomerID(searchText);
                this.ConfirmRequest.Enabled = true;
            }

            if (status == 1)
            {
                foodList = HoaDonMonAn_BUS.BillListWithCustomerID(searchText);
                this.ConfirmRequest.Enabled = false;
            }

            if (foodList == null) foodList = new List<HoaDonMonAn>();

            this.CustomerFoodDGV.DataSource = foodList;
        }

        private void SearchTextTxt_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void StatusCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        #endregion

        #region Paid Agent
        private List<ChiTietDanhSachNguyenLieu> IList;

        private void PaidLoad()
        {
            this.SupplierFindCBB.SelectedIndex = 1;
            //GLoad();
        }

        private void AgentTotal()
        {
            double total = 0;
            foreach (ChiTietDanhSachNguyenLieu nl in IList)
            {
                total += nl.ThanhTien;
            }

            this.totaltxt.Text = total.ToString();
        }



        private void MaterialImportDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ChiTietDanhSachNguyenLieu ct = new ChiTietDanhSachNguyenLieu();
                ct.MaDSNL = this.MaterialImportDGV.Rows[e.RowIndex].Cells["MaDSNL"].Value.ToString();
                ct.MaNL = this.MaterialImportDGV.Rows[e.RowIndex].Cells["MaNL"].Value.ToString();
                ct.Gia = Double.Parse(this.MaterialImportDGV.Rows[e.RowIndex].Cells["gia"].Value.ToString());
                ct.ThanhTien = ct.Gia * int.Parse(this.MaterialImportDGV.Rows[e.RowIndex].Cells["soLuong"].Value.ToString());
                if (ChiTietDanhSachNguyenLieu_BUS.UpdateList(ct))
                {
                    IList = ChiTietDanhSachNguyenLieu_BUS.IngredientList(ct.MaDSNL);
                    var bindingList = new BindingList<ChiTietDanhSachNguyenLieu>(IList);
                    this.MaterialImportDGV.DataSource = bindingList;
                    AgentTotal();
                    if (PhieuThanhToan_BUS.UpdateTotal(Double.Parse(this.totaltxt.Text), ct.MaDSNL))
                    {
                        GLoad();
                        Console.WriteLine(ct);
                    }
                }
            }
            catch
            {
                return;
            }
        }



        private void SupplierPhoneTxb_TextChanged(object sender, EventArgs e)
        {
            GLoad();
        }

        private void GLoad()
        {
            string id = this.SupplierPhoneTxb.Text;
            string tt = "";
            switch (this.SupplierFindCBB.SelectedIndex)
            {
                case 0:
                    tt = "";
                    break;
                case 1:
                    tt = "Pe";
                    break;
                case 2:
                    tt = "Co";
                    break;
                default:
                    tt = "";
                    break;
            }
            List<PhieuThanhToan> list = PhieuThanhToan_BUS.AgentList(id, tt);
            if (list == null) list = new List<PhieuThanhToan>();

            this.RequestImportDGV.DataSource = list;
        }

        private void SupplierFindCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GLoad();
        }

        private void ConfirmRequestBtn_Click(object sender, EventArgs e)
        {
            if (this.SupplierNameCb.Text == "" || IList.Count == 0)
            {
                MessageBox.Show("Enter Agent ID");
                return;
            }

            string mads = IList[0].MaDSNL;
            string madl = this.SupplierNameCb.SelectedValue.ToString();
            string note = "none";
            if (this.NoteSupplierTxb.Text != "")
                note = this.NoteSupplierTxb.Text;


            if (PhieuThanhToan_BUS.UpdateConfirm(madl, note, mads))
            {
                FReset();
                MessageBox.Show("Add successfully");
            }
        }

        private void FReset()
        {
            this.NoteSupplierTxb.Text = "";
            this.totaltxt.Text = "0";

            IList.Clear();
            var bindingList = new BindingList<ChiTietDanhSachNguyenLieu>(IList);
            this.MaterialImportDGV.DataSource = bindingList;
            this.ConfirmRequestBtn.Enabled = true;

            GLoad();
        }

        private void CancelRequestBtn_Click(object sender, EventArgs e)
        {
            IList.Clear();
            var bindingList = new BindingList<ChiTietDanhSachNguyenLieu>(IList);
            this.MaterialImportDGV.DataSource = bindingList;
        }


        private void RequestImportDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = this.RequestImportDGV.SelectedRows[0].Cells["ListID"].Value.ToString();
            IList = ChiTietDanhSachNguyenLieu_BUS.IngredientList(id);
            var bindingList = new BindingList<ChiTietDanhSachNguyenLieu>(IList);
            this.MaterialImportDGV.DataSource = bindingList;

            if (this.RequestImportDGV.SelectedRows[0].Cells["tt"].Value.ToString() == "Complete")
            {
                this.ConfirmRequestBtn.Enabled = false;
                this.MaterialImportDGV.Columns["gia"].ReadOnly = true;
            }
            else
            {
                this.ConfirmRequestBtn.Enabled = true;
                this.MaterialImportDGV.ReadOnly = false;
            }

            AgentTotal();
        }
        #endregion


        private string getRandomID()
        {
            return String.Format("{0:d8}", (DateTime.Now.Ticks / 10) % 1000000000);
        }

        private void Statistic_Form_Load(object sender, EventArgs e)
        {
            RequestFoodLoad();
            PaidLoad();
            BillRoomLoad();
            LoadSupplier();
            AllDailyLoad();
            AllMonthlyLoad();
            SearchFoodList();
            SearchServiceList();
            SearchList();
        }

        #region statistic day

        private void BillRoomLoad()
        {
            List<HoaDonPhong> roomBillList = HoaDonPhong_BUS.RoomBillCompletedList();
            if (roomBillList == null) roomBillList = new List<HoaDonPhong>();
            this.BillRoomDgv.DataSource = roomBillList;
        }

        #endregion

        private void BillRoomDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = BillRoomDgv.CurrentRow.Index;
            
        }

        private void DeleteSupplierBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            Add_Supplier_Form add_Ingredient_Form = new Add_Supplier_Form();
            add_Ingredient_Form.ShowDialog();
        }

        #region Daily Room

        private void siticoneRoundedDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SearchList();
        }

        private void SearchList()
        {
            string id = this.customerIDTxb.Text;
            if (id == null) id = "";
            List<HoaDonPhong> listDailyRoom = HoaDonPhong_BUS.RoomListWithDate(this.RoomDailyDateDTP.Value, id);
            if (listDailyRoom == null) listDailyRoom = new List<HoaDonPhong>();
            this.BillRoomDgv.DataSource = listDailyRoom;
            CaculateFun(listDailyRoom);
        }

        private void CaculateFun(List<HoaDonPhong> listDailyRoom)
        {
            double total = 0;
            double receive = 0;
            double returnMoney = 0;
            double riskRefun = 0; 

            foreach(HoaDonPhong bill in listDailyRoom)
            {
                total += bill.TongTien;
                receive += bill.TienNhan;
                returnMoney += bill.TienThua;
                riskRefun += bill.SoTienHoan;
            }

            this.TotalPriceTxt.Text = total.ToString();
            this.ReceiveTxt.Text = receive.ToString();
            this.ReturnTxt.Text = returnMoney.ToString();
            this.RiskRefurnTxt.Text = riskRefun.ToString();
        }

        private void customerIDTxb_TextChanged(object sender, EventArgs e)
        {
            SearchList();
        }

        #endregion
        #region Service Daily

        private void SearchServiceList()
        {
            string id = this.CustomerIDDailyTxt.Text;
            if (id == null) id = "";
            List<HoaDonDichVu> listDailyRoom = HoaDonDichVu_BUS.ServiceListWithDate(this.ServiceDailyDateTxt.Value, id);
            if (listDailyRoom == null) listDailyRoom = new List<HoaDonDichVu>();
            this.ServiceDailyDGV.DataSource = listDailyRoom;
            CaculateServiceFun(listDailyRoom);
        }

        private void CaculateServiceFun(List<HoaDonDichVu> listDailyRoom)
        {
            double total = 0;
            double receive = 0;
            double returnMoney = 0;
            double riskRefun = 0;

            foreach (HoaDonDichVu bill in listDailyRoom)
            {
                total += bill.TongTien;
                receive += bill.TienNhan;
                returnMoney += bill.TienThua;
                riskRefun += bill.SoTienHoan;
            }

            this.ServiceTotalDailyTxt.Text = total.ToString();
            this.ServiceReceiveDailyTxt.Text = receive.ToString();
            this.ServiceReturnDailyTxt.Text = returnMoney.ToString();
            this.ServiceReturnDailyTxt.Text = riskRefun.ToString();
        }

        private void ServiceDailyDateTxt_ValueChanged(object sender, EventArgs e)
        {
            SearchServiceList();
        }

        private void CustomerIDDailyTxt_TextChanged(object sender, EventArgs e)
        {
            SearchServiceList();
        }
        #endregion
        #region Food Daily
        private void SearchFoodList()
        {
            string id = this.FoodCustomerIDTxt.Text;
            if (id == null) id = "";
            List<HoaDonMonAn> listDailyRoom = HoaDonMonAn_BUS.FoodListWithDate(this.FoodDateDailyDP.Value, id);
            if (listDailyRoom == null) listDailyRoom = new List<HoaDonMonAn>();
            this.FoodDGV.DataSource = listDailyRoom;
            CaculateFoodFun(listDailyRoom);
        }

        private void CaculateFoodFun(List<HoaDonMonAn> listDailyRoom)
        {
            double total = 0;
            double receive = 0;
            double returnMoney = 0;
            double riskRefun = 0;

            foreach (HoaDonMonAn bill in listDailyRoom)
            {
                total += bill.TongTien;
                receive += bill.TienNhan;
                returnMoney += bill.TienThua;
                riskRefun += bill.SoTienHoan;
            }

            this.FoodTotalDailyTxt.Text = total.ToString();
            this.FoodReceiveDailyTxt.Text = receive.ToString();
            this.FoodReturnDailyTxt.Text = returnMoney.ToString();
            this.FoodReturnDailyTxt.Text = riskRefun.ToString();
        }

        private void FoodDateDailyDP_ValueChanged(object sender, EventArgs e)
        {
            SearchFoodList();
        }

        private void FoodCustomerIDTxt_TextChanged(object sender, EventArgs e)
        {
            SearchFoodList();
        }
        #endregion

        #region All Daily
        private void AllDailyLoad()
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

            this.chart1.Series[0].IsValueShownAsLabel = true;
            this.chart1.Series[1].IsValueShownAsLabel = true;
           

            this.chart1.Series[0].Points.AddXY("Room", RoomDaily()[0]);
            this.chart1.Series[1].Points.AddXY("Room", RoomDaily()[1]);

            this.chart1.Series[0].Points.AddXY("Food", FoodDaily()[0]);
            this.chart1.Series[1].Points.AddXY("Food", FoodDaily()[1]);

            this.chart1.Series[0].Points.AddXY("Service", ServiceDaily()[0]);
            this.chart1.Series[1].Points.AddXY("Service", ServiceDaily()[1]);

            this.chart1.Series[0].Points.AddXY("Today", RoomDaily()[0] + FoodDaily()[0] + ServiceDaily()[0]);
            this.chart1.Series[1].Points.AddXY("Today", RoomDaily()[1] + FoodDaily()[1] + ServiceDaily()[1]);


            this.CollectRoom.Text = RoomDaily()[2].ToString();
            this.PayRoom.Text = RoomDaily()[1].ToString();
            this.totalRoom.Text = RoomDaily()[0].ToString();

            this.CollectFood.Text = FoodDaily()[2].ToString();
            this.PayFood.Text = FoodDaily()[1].ToString();
            this.totalFood.Text = FoodDaily()[0].ToString();

            this.CollectService.Text = ServiceDaily()[2].ToString();
            this.PayService.Text = ServiceDaily()[1].ToString();
            this.totalService.Text = ServiceDaily()[0].ToString();

            this.TotalCollect.Text = (RoomDaily()[2] + FoodDaily()[2] + ServiceDaily()[2]).ToString();
            this.TotalPay.Text = (RoomDaily()[1] + FoodDaily()[1] + ServiceDaily()[1]).ToString();
            this.Totaltotal.Text = (RoomDaily()[0] + FoodDaily()[0] + ServiceDaily()[0]).ToString();

        }

        private List<double> RoomDaily()
        {
            List<double> roomDetail = new List<double>();
            double total = 0;
            double receive = 0;
            double returnMoney = 0;
            double risk = 0;
            List<HoaDonPhong> roomList = HoaDonPhong_BUS.RoomListWithDate(this.DateReportPicker.Value, "");
            if (roomList == null) roomList = new List<HoaDonPhong>();
            foreach(HoaDonPhong room in roomList)
            {
                total += room.TongTien;
                receive += room.TienNhan;
                returnMoney += room.TienThua;
            }
            roomDetail.Add(total);
            roomDetail.Add(returnMoney);
            roomDetail.Add(receive);
            return roomDetail;
        }

        private List<double> FoodDaily()
        {
            List<double> roomDetail = new List<double>();
            double total = 0;
            double receive = 0;
            double returnMoney = 0;
            //double risk = 0;
            List<HoaDonMonAn> roomList = HoaDonMonAn_BUS.FoodListWithDate(this.DateReportPicker.Value, "");
            if (roomList == null) roomList = new List<HoaDonMonAn>();
            foreach (HoaDonMonAn room in roomList)
            {
                total += room.TongTien;
                receive += room.TienNhan;
                returnMoney += room.TienThua;
            }
            roomDetail.Add(total);
            roomDetail.Add(returnMoney);
            roomDetail.Add(receive);
            return roomDetail;
        }

        private List<double> ServiceDaily()
        {
            List<double> roomDetail = new List<double>();
            double total = 0;
            double receive = 0;
            double returnMoney = 0;
            //double risk = 0;
            List<HoaDonDichVu> roomList = HoaDonDichVu_BUS.ServiceListWithDate(this.DateReportPicker.Value, "");
            if (roomList == null) roomList = new List<HoaDonDichVu>();
            foreach (HoaDonDichVu room in roomList)
            {
                total += room.TongTien;
                receive += room.TienNhan;
                returnMoney += room.TienThua;
            }
            roomDetail.Add(total);
            roomDetail.Add(returnMoney);
            roomDetail.Add(receive);
            return roomDetail;
        }

        private void DateReportPicker_ValueChanged(object sender, EventArgs e)
        {
            AllDailyLoad();
        }
        #endregion

        #region All Monthly
        private void AllMonthlyLoad()
        {
            this.chart2.Series[0].Points.Clear();
            this.chart2.Series[1].Points.Clear();

            this.chart2.Series[0].IsValueShownAsLabel = true;
            this.chart2.Series[1].IsValueShownAsLabel = true;


            this.chart2.Series[0].Points.AddXY("Room", RoomMonthly()[0]);
            this.chart2.Series[1].Points.AddXY("Room", RoomMonthly()[1]);

            this.chart2.Series[0].Points.AddXY("Food", FoodMonthly()[0]);
            this.chart2.Series[1].Points.AddXY("Food", FoodMonthly()[1]);

            this.chart2.Series[0].Points.AddXY("Service", ServiceMonthly()[0]);
            this.chart2.Series[1].Points.AddXY("Service", ServiceMonthly()[1]);

            this.chart2.Series[0].Points.AddXY("This Month", RoomMonthly()[0] + FoodMonthly()[0] + ServiceMonthly()[0]);
            this.chart2.Series[1].Points.AddXY("This Month", RoomMonthly()[1] + FoodMonthly()[1] + ServiceMonthly()[1]);


            this.receiveRoom.Text = RoomMonthly()[2].ToString();
            this.returnRoom.Text = RoomMonthly()[1].ToString();
            this.collectTotalRoom.Text = RoomMonthly()[0].ToString();

            this.receiveFood.Text = FoodMonthly()[2].ToString();
            this.returnFood.Text = FoodMonthly()[1].ToString();
            this.collectTotalFood.Text = FoodMonthly()[0].ToString();

            this.receiveService.Text = ServiceMonthly()[2].ToString();
            this.returnService.Text = ServiceMonthly()[1].ToString();
            this.collectTotalService.Text = ServiceMonthly()[0].ToString();

            this.receiveTotal.Text = (RoomMonthly()[2] + FoodMonthly()[2] + ServiceMonthly()[2]).ToString();
            this.returnTotal.Text = (RoomMonthly()[1] + FoodMonthly()[1] + ServiceMonthly()[1]).ToString();
            this.totalTotalTotal.Text = (RoomMonthly()[0] + FoodMonthly()[0] + ServiceMonthly()[0]).ToString();

        }

        private List<double> RoomMonthly()
        {
            List<double> roomDetail = new List<double>();
            double total = 0;
            double receive = 0;
            double returnMoney = 0;
            double risk = 0;
            List<HoaDonPhong> roomList = HoaDonPhong_BUS.RoomListWithMonth(this.PickMonth.Text, this.PickYear.Text, "");
            if (roomList == null) roomList = new List<HoaDonPhong>();
            foreach (HoaDonPhong room in roomList)
            {
                total += room.TongTien;
                receive += room.TienNhan;
                returnMoney += room.TienThua;
            }
            roomDetail.Add(total);
            roomDetail.Add(returnMoney);
            roomDetail.Add(receive);
            return roomDetail;
        }

        private List<double> FoodMonthly()
        {
            List<double> roomDetail = new List<double>();
            double total = 0;
            double receive = 0;
            double returnMoney = 0;
            //double risk = 0;
            List<HoaDonMonAn> roomList = HoaDonMonAn_BUS.FoodListWithMonth(this.PickMonth.Text, this.PickYear.Text, "");
            if (roomList == null) roomList = new List<HoaDonMonAn>();
            foreach (HoaDonMonAn room in roomList)
            {
                total += room.TongTien;
                receive += room.TienNhan;
                returnMoney += room.TienThua;
            }
            roomDetail.Add(total);
            roomDetail.Add(returnMoney);
            roomDetail.Add(receive);
            return roomDetail;
        }

        private List<double> ServiceMonthly()
        {
            List<double> roomDetail = new List<double>();
            double total = 0;
            double receive = 0;
            double returnMoney = 0;
            //double risk = 0;
            List<HoaDonDichVu> roomList = HoaDonDichVu_BUS.ServiceListWithMonth(this.PickMonth.Text, this.PickYear.Text, "");
            if (roomList == null) roomList = new List<HoaDonDichVu>();
            foreach (HoaDonDichVu room in roomList)
            {
                total += room.TongTien;
                receive += room.TienNhan;
                returnMoney += room.TienThua;
            }
            roomDetail.Add(total);
            roomDetail.Add(returnMoney);
            roomDetail.Add(receive);
            return roomDetail;
        }

        private void searchMonth_Click(object sender, EventArgs e)
        {
            AllMonthlyLoad();
        }

        #endregion

        private void printReportDay_Click(object sender, EventArgs e)
        {
            if (Totaltotal.Text != "")
            {
                Document baoCao = new Document("TemplateReport\\Report_Date.doc");

                baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { DateReportPicker.Value.ToString("MM/dd/yyyy") });//Value.ToString("dd/MM/yyyy")

                baoCao.MailMerge.Execute(new[] { "Room_Receive" }, new[] { CollectRoom.Text });
                baoCao.MailMerge.Execute(new[] { "Room_Return" }, new[] { PayRoom.Text });

                baoCao.MailMerge.Execute(new[] { "Service_Receive" }, new[] { CollectService.Text });
                baoCao.MailMerge.Execute(new[] { "Service_Return" }, new[] { PayService.Text });

                baoCao.MailMerge.Execute(new[] { "Food_Receive" }, new[] { CollectFood.Text });
                baoCao.MailMerge.Execute(new[] { "Food_Return" }, new[] { PayFood.Text });

                baoCao.MailMerge.Execute(new[] { "Total_Receive" }, new[] { TotalCollect.Text });
                baoCao.MailMerge.Execute(new[] { "Total_Return" }, new[] { TotalPay.Text });

                baoCao.MailMerge.Execute(new[] { "Total_Revenue" }, new[] { Totaltotal.Text });

                baoCao.SaveAndOpenFile("BaoCaoDay.doc");
            }
        }

        private void printReportMonth_Click(object sender, EventArgs e)
        {
            if (totalTotalTotal.Text != "")
            {
                Document baoCao = new Document("TemplateReport\\Report_Month.doc");

                baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { PickMonth.Text + "/" + PickYear.Text });//Value.ToString("dd/MM/yyyy")

                baoCao.MailMerge.Execute(new[] { "Room_Receive" }, new[] { receiveRoom.Text });
                baoCao.MailMerge.Execute(new[] { "Room_Return" }, new[] { returnRoom.Text });

                baoCao.MailMerge.Execute(new[] { "Service_Receive" }, new[] { receiveService.Text });
                baoCao.MailMerge.Execute(new[] { "Service_Return" }, new[] { returnService.Text });

                baoCao.MailMerge.Execute(new[] { "Food_Receive" }, new[] { receiveFood.Text });
                baoCao.MailMerge.Execute(new[] { "Food_Return" }, new[] { returnFood.Text });

                baoCao.MailMerge.Execute(new[] { "Total_Receive" }, new[] { receiveTotal.Text });
                baoCao.MailMerge.Execute(new[] { "Total_Return" }, new[] { returnTotal.Text });

                baoCao.MailMerge.Execute(new[] { "Total_Revenue" }, new[] { totalTotalTotal.Text });

                baoCao.SaveAndOpenFile("BaoCaoMonth.doc");
            }
        }

        private void printRoomBill_Click(object sender, EventArgs e)
        {
            if (customerIDTxb.Text != "")
            {
                Document baoCao = new Document("TemplateReport\\Bill_Payment.doc");

                baoCao.MailMerge.Execute(new[] { "TYPE_HOTEL" }, new[] { "ROOM" });

                baoCao.MailMerge.Execute(new[] { "date_bill" }, new[] { RoomDailyDateDTP.Value.ToString("MM/dd/yyyy") });

                baoCao.MailMerge.Execute(new[] { "member_id" }, new[] { customerIDTxb.Text });

                baoCao.MailMerge.Execute(new[] { "room" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "name" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "check_in" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "address" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "phone" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "days" }, new[] { " " });

                baoCao.MailMerge.Execute(new[] { "check_out" }, new[] { RoomDailyDateDTP.Value.ToString("MM/dd/yyyy") });

                baoCao.MailMerge.Execute(new[] { "total" }, new[] { TotalPriceTxt.Text });
                baoCao.MailMerge.Execute(new[] { "receive" }, new[] { ReceiveTxt.Text });
                baoCao.MailMerge.Execute(new[] { "return" }, new[] { ReturnTxt.Text + " (USD)" });

                baoCao.SaveAndOpenFile("HoaDonRoom.doc");
            }
        }

        private void printFoodBill_Click(object sender, EventArgs e)
        {
            if (FoodCustomerIDTxt.Text != "")
            {
                Document baoCao = new Document("TemplateReport\\Bill_Payment.doc");

                baoCao.MailMerge.Execute(new[] { "TYPE_HOTEL" }, new[] { "FOOD" });

                baoCao.MailMerge.Execute(new[] { "date_bill" }, new[] { FoodDateDailyDP.Value.ToString("MM/dd/yyyy") });

                baoCao.MailMerge.Execute(new[] { "member_id" }, new[] { FoodCustomerIDTxt.Text });

                baoCao.MailMerge.Execute(new[] { "room" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "name" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "check_in" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "address" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "phone" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "days" }, new[] { " " });

                baoCao.MailMerge.Execute(new[] { "check_out" }, new[] { FoodDateDailyDP.Value.ToString("MM/dd/yyyy") });

                baoCao.MailMerge.Execute(new[] { "total" }, new[] { FoodTotalDailyTxt.Text });
                baoCao.MailMerge.Execute(new[] { "receive" }, new[] { FoodReceiveDailyTxt.Text });
                baoCao.MailMerge.Execute(new[] { "return" }, new[] { FoodReturnDailyTxt.Text + " (USD)" });

                baoCao.SaveAndOpenFile("HoaDonFood.doc");
            }
        }

        private void printServiceBill_Click(object sender, EventArgs e)
        {
            if (CustomerIDDailyTxt.Text != "")
            {
                Document baoCao = new Document("TemplateReport\\Bill_Payment.doc");

                baoCao.MailMerge.Execute(new[] { "TYPE_HOTEL" }, new[] { "SERVICE" });

                baoCao.MailMerge.Execute(new[] { "date_bill" }, new[] { ServiceDailyDateTxt.Value.ToString("MM/dd/yyyy") });

                baoCao.MailMerge.Execute(new[] { "member_id" }, new[] { CustomerIDDailyTxt.Text });

                baoCao.MailMerge.Execute(new[] { "room" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "name" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "check_in" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "address" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "phone" }, new[] { " " });
                baoCao.MailMerge.Execute(new[] { "days" }, new[] { " " });

                baoCao.MailMerge.Execute(new[] { "check_out" }, new[] { ServiceDailyDateTxt.Value.ToString("MM/dd/yyyy") });

                baoCao.MailMerge.Execute(new[] { "total" }, new[] { ServiceTotalDailyTxt.Text });
                baoCao.MailMerge.Execute(new[] { "receive" }, new[] { ServiceReceiveDailyTxt.Text });
                baoCao.MailMerge.Execute(new[] { "return" }, new[] { ServiceReturnDailyTxt.Text + " (USD)" });

                baoCao.SaveAndOpenFile("HoaDonService.doc");
            }
        }

        
    }
}
