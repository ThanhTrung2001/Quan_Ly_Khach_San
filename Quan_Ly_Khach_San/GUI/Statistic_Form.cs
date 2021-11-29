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
    public partial class Statistic_Form : Form
    {
        public Statistic_Form()
        {
            InitializeComponent();
        }

        #region Supplier
        private void LoadSupplier()
        {
            this.SupplierNameCb.Items.Clear();
            List<DaiLy> list = DaiLy_BUS.SupplierList();
            if (list == null) list = new List<DaiLy>();

            DaiLy dly = new DaiLy();
            dly.MaDL = "all";
            dly.TenDL = "All";
            list.Insert(0, dly);

            this.SupplierNameCb.DataSource = list;

            this.SupplierNameCb.ValueMember = "MaDL";
            this.SupplierNameCb.DisplayMember = "TenDL";

            this.SupplierNameCb.SelectedIndex = 0;
        }

        #endregion

        #region Food Request
        private void RequestFoodLoad()
        {
            BillLoad();
            this.FListRequestDGV.DataSource = new List<MonAn>();

            this.TotalPriceFoodTxb.Text = "0";
            this.ReceiveMoneyTxb.Text = "0";

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
            if (this.ReceiveMoneyTxb.Text == "") return;

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
            if (this.ReceiveMoneyTxb.Text == "" || this.ReceiveMoneyTxb.Text == "0")
                return;
            if (this.CustomerFoodDGV.SelectedRows.Count <= 0)
                return;

            HoaDonMonAn bill = new HoaDonMonAn();
            bill.NgayLap = DateTime.Now.ToString();
            bill.MaDSMA = this.CustomerFoodDGV.SelectedRows[0].Cells["maDSMA"].Value.ToString();
            bill.TienNhan = Double.Parse(this.ReceiveMoneyTxb.Text);
            bill.TienThua = Double.Parse(this.ReturnMoneyTxb.Text);
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
            TypeLoad();
            UnitLoad();
            SuggestionLoad();
            GLoad();
        }

        private void SuggestionLoad()
        {
            List<NguyenLieu> list = NguyenLieu_BUS.IngredientList();
            if (list == null) return;
            AutoCompleteStringCollection l = new AutoCompleteStringCollection();
            foreach (NguyenLieu nl in list)
            {
                l.Add(nl.MaNL);
            }

            this.IngredientIDtxt.AutoCompleteCustomSource = l;
        }

        private void IngredientIDtxt_TextChanged(object sender, EventArgs e)
        {
            string id = this.IngredientIDtxt.Text;
            NguyenLieu nl = NguyenLieu_BUS.IngredientWithID(id);
            if (nl == null)
            {
                this.IngredientNametxt.Text = "";
                return;
            }

            this.IngredientNametxt.Text = nl.TenNL;
            this.IngredientStyletxt.SelectedValue = nl.MaLoaiNL;
            this.IngredientUnittxt.SelectedValue = nl.MaDVT;
        }

        private void TypeLoad()
        {
            List<LoaiNguyenLieu> list = LoaiNguyenLieu_BUS.IngredientTypeList();
            if (list == null) return;

            this.IngredientStyletxt.DataSource = list;
            this.IngredientStyletxt.DisplayMember = "TLoaiNguyenLieu";
            this.IngredientStyletxt.ValueMember = "maLoaiNL";

        }

        private void UnitLoad()
        {
            List<DonViTinh> list = DonViTinh_BUS.MeasureList();
            if (list == null) return;

            this.IngredientUnittxt.DataSource = list;
            this.IngredientUnittxt.DisplayMember = "DVT";
            this.IngredientUnittxt.ValueMember = "maDVT";
        }

        private void IngredientAmounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void IngredientPricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void IngredientAddbtn_Click(object sender, EventArgs e)
        {
            if (this.IngredientAmounttxt.Text == "" || this.IngredientPricetxt.Text == "" || this.IngredientNametxt.Text == "")
            {
                MessageBox.Show("Enter fully informations");
                return;
            }
            string id = this.IngredientIDtxt.Text;

            if (NguyenLieu_BUS.IngredientWithID(this.IngredientIDtxt.Text) == null)
                id = AddNewIngredient();

            if (IList == null) IList = new List<ChiTietDanhSachNguyenLieu>();

            ChiTietDanhSachNguyenLieu ct = new ChiTietDanhSachNguyenLieu();
            ct.MaChiTiet = "D" + getRandomID();
            ct.MaDSNL = "";
            ct.MaNL = id;
            ct.TenNL = this.IngredientNametxt.Text;
            ct.SoLuong = int.Parse(this.IngredientAmounttxt.Text);
            ct.MaDVT = this.IngredientUnittxt.SelectedValue.ToString();
            ct.Gia = Double.Parse(this.IngredientPricetxt.Text);
            ct.ThanhTien = ct.Gia * ct.SoLuong;

            IList.Add(ct);
            var bindingList = new BindingList<ChiTietDanhSachNguyenLieu>(IList);
            this.MaterialImportDGV.DataSource = bindingList;

            AgentTotal();

            resetIngredient();
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

        private string AddNewIngredient()
        {
            NguyenLieu nl = new NguyenLieu();
            if (this.IngredientIDtxt.Text != "")
                nl.MaNL = this.IngredientIDtxt.Text;
            else
                nl.MaNL = "I" + getRandomID();
            nl.TenNL = this.IngredientNametxt.Text;
            nl.MaLoaiNL = this.IngredientStyletxt.SelectedValue.ToString();
            nl.MaDVT = this.IngredientUnittxt.SelectedValue.ToString();
            nl.SoLuong = 0;

            if (NguyenLieu_BUS.AddNewIngredient(nl))
            {
                //IngredientLoad();
                return nl.MaNL;
            }

            return "";
        }

        private void SupplierPhoneTxb_TextChanged(object sender, EventArgs e)
        {
            GLoad();
        }

        private void GLoad()
        {
            string id = this.SupplierPhoneTxb.Text;
            List<PhieuThanhToan> list = PhieuThanhToan_BUS.AgentList(id);
            if (list == null) list = new List<PhieuThanhToan>();

            this.RequestImportDGV.DataSource = list;
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            DeleteI();

        }

        private void DeleteI()
        {
            try
            {
                IList.RemoveAt(this.MaterialImportDGV.SelectedRows[0].Index);
                var bindingList = new BindingList<ChiTietDanhSachNguyenLieu>(IList);
                this.MaterialImportDGV.DataSource = bindingList;

                AgentTotal();
            }
            catch
            {
                return;
            }
        }

        private void resetIngredient()
        {
            this.IngredientIDtxt.Text = "";
            this.IngredientNametxt.Text = "";
            this.IngredientAmounttxt.Text = "";
            this.IngredientPricetxt.Text = "";
        }

        private void ConfirmRequestBtn_Click(object sender, EventArgs e)
        {
            if (this.SupplierNameCb.Text == "" || IList.Count == 0)
            {
                MessageBox.Show("Enter Agent ID");
                return;
            }
            string listID = "L" + getRandomID();


            foreach (ChiTietDanhSachNguyenLieu nl in IList)
            {
                nl.MaDSNL = listID;
                if (ChiTietDanhSachNguyenLieu_BUS.AddNewIngredientListDetail(nl))
                    //RecommentText();
                    Console.WriteLine(nl);
            }

            PhieuThanhToan p = new PhieuThanhToan();
            p.MaPhieu = "F" + getRandomID();
            p.MaDL = this.SupplierNameCb.Text;
            p.NgayLap = DateTime.Now.ToString();
            p.MaDSNL = listID;
            p.TongTien = Double.Parse(this.totaltxt.Text);
            p.MaTrangThai = "Co";
            if (this.NoteSupplierTxb.Text == "")
                p.GhiChu = "none";
            else p.GhiChu = this.NoteSupplierTxb.Text;

            if (PhieuThanhToan_BUS.AddNewAgent(p))
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

            GLoad();
        }

        private void CancelRequestBtn_Click(object sender, EventArgs e)
        {
            IList.Clear();
            var bindingList = new BindingList<ChiTietDanhSachNguyenLieu>(IList);
            this.MaterialImportDGV.DataSource = bindingList;
        }

        private void MaterialImportDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteI();
        }

        private void RequestImportDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = this.RequestImportDGV.SelectedRows[0].Cells["ListID"].Value.ToString();
            IList = ChiTietDanhSachNguyenLieu_BUS.IngredientList(id);
            var bindingList = new BindingList<ChiTietDanhSachNguyenLieu>(IList);
            this.MaterialImportDGV.DataSource = bindingList;
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
            this.CheckInDate.Text = BillRoomDgv.Rows[i].Cells[1].Value.ToString();
            this.CheckOutDate.Text = BillRoomDgv.Rows[i].Cells[2].Value.ToString();
            this.CustomerCodeTxb.Text = BillRoomDgv.Rows[i].Cells[4].Value.ToString();
            this.RoomIDTxb.Text = BillRoomDgv.Rows[i].Cells[5].Value.ToString();
            this.DaysTxb.Text = BillRoomDgv.Rows[i].Cells[6].Value.ToString();
            this.TotalPriceTxb.Text = BillRoomDgv.Rows[i].Cells[7].Value.ToString();
            this.ReceiveTxb.Text = BillRoomDgv.Rows[i].Cells[8].Value.ToString();
            this.ReturnTxb.Text = BillRoomDgv.Rows[i].Cells[9].Value.ToString();
        }
    }
}
