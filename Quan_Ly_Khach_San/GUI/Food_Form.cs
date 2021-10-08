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
    public partial class Food_Form : Form
    {
        public Food_Form()
        {
            InitializeComponent();
        }

        private void Food_Form_Load(object sender, EventArgs e)
        {
            MenuFormLoad();
            RequestFoodLoad();
            StorageLoad();
            PaidLoad();
        }

        #region Menu

        private string foodName = "";
        private string foodType = "";
        private List<MonAn> selectedFoodList;

        private void MenuFormLoad()
        {
            FoodGridLoad();
            TypeCbbLoad();
            CustomerLoad();
        }

        private void FoodGridLoad()
        {
            List<MonAn> foodList = MonAn_BUS.FoodList();
            if (foodList == null) foodList = new List<MonAn>();
            this.MenuFoodDGV.DataSource = foodList;
        }

        private void TypeCbbLoad()
        {
            this.FoodTypeCb.Items.Clear();
            List<LoaiMonAn> list = LoaiMonAn_BUS.FoodTypeList();
            if (list == null) list = new List<LoaiMonAn>();

            LoaiMonAn lma = new LoaiMonAn();
            lma.MaLoaiMonAn = "all";
            lma.TLoaiMonAn = "All";
            list.Insert(0, lma);

            this.FoodTypeCb.DataSource = list;

            this.FoodTypeCb.ValueMember = "MaLoaiMonAn";
            this.FoodTypeCb.DisplayMember = "TLoaiMonAn";

            this.FoodTypeCb.SelectedIndex = 0;
        }

        private void CustomerLoad()
        {
            this.CustomerPickCb.Items.Clear();
            List<KhachHang> list = KhachHang_BUS.CustomerList();
            if (list == null) return;
            this.CustomerPickCb.ValueMember = "maKH";
            this.CustomerPickCb.DisplayMember = "maKH";

            foreach (KhachHang khachHang in list)
            {
                this.CustomerPickCb.Items.Add(khachHang);
            }
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            Add_Customer_Form add = new Add_Customer_Form();
            add.ShowDialog();
        }


        private void SearchFood_TextChanged(object sender, EventArgs e)
        {
            foodName = SearchFood.Text;
            List<MonAn> list = MonAn_BUS.FoodListWithSearch(foodName, foodType);
            if (list == null) list = new List<MonAn>();
            this.MenuFoodDGV.DataSource = list;
        }

        private void FoodTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foodType = FoodTypeCb.SelectedValue.ToString();
                List<MonAn> list = MonAn_BUS.FoodListWithSearch(foodName, foodType);
                if (list == null) list = new List<MonAn>();
                this.MenuFoodDGV.DataSource = list;
            }
            catch
            {
                return;
            }
        }


        private void AddSelectedList(MonAn selectedFood)
        {
            double total = 0;
            if (selectedFoodList == null)
            {
                selectedFoodList = new List<MonAn>();

            }

            selectedFoodList.Add(selectedFood);

            var bindingList = new BindingList<MonAn>(selectedFoodList);
            this.ListFoodRequestDGV.DataSource = bindingList;

            foreach (MonAn ma in selectedFoodList)
            {
                total += ma.Gia;
            }

            this.TotalPrice.Text = total.ToString();
        }


        private void MenuFoodDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MonAn selectedFood = MenuFoodDGV.Rows[e.RowIndex].DataBoundItem as MonAn;
                AddSelectedList(selectedFood);
            }
            catch
            {
                MessageBox.Show("Add failed");
                return;
            }
        }

        private void SubFoodBtn_Click(object sender, EventArgs e)
        {
            if (this.FoodNumberTxb.Text == "1") return;

            this.FoodNumberTxb.Text = (int.Parse(FoodNumberTxb.Text) - 1).ToString();
        }


        private void PlusFoodBtn_Click(object sender, EventArgs e)
        {
            this.FoodNumberTxb.Text = (int.Parse(FoodNumberTxb.Text) + 1).ToString();

        }

        private void AddToListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = int.Parse(FoodNumberTxb.Text);
                MonAn monAn = MenuFoodDGV.SelectedRows[0].DataBoundItem as MonAn;

                for (int i = 0; i < amount; i++)
                {
                    AddSelectedList(monAn);
                }
            }
            catch
            {
                MessageBox.Show("Add failed");
                return;
            }
        }

        private void DeleteInListBtn_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void ListFoodRequestDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteRow();
        }

        private void DeleteRow()
        {
            try
            {
                double total = 0;
                selectedFoodList.RemoveAt(ListFoodRequestDGV.SelectedRows[0].Index);

                var bindingList = new BindingList<MonAn>(selectedFoodList);
                this.ListFoodRequestDGV.DataSource = bindingList;

                foreach (MonAn ma in selectedFoodList)
                {
                    total += ma.Gia;
                }

                this.TotalPrice.Text = total.ToString();
            }
            catch
            {
                return;
            }
        }

        private void RequestFoodBtn_Click(object sender, EventArgs e)
        {
            string listId = "L" + getRandomID();
            if (this.selectedFoodList == null || this.selectedFoodList.Count == 0 || CustomerPickCb.Text == "") return;

            var requestList = selectedFoodList.GroupBy(i => i);

            foreach (var g in requestList)
            {
                MonAn ma = g.Key;
                int amount = g.Count();

                ChiTietDanhSachMonAn chiTiet = new ChiTietDanhSachMonAn();
                chiTiet.MaChiTiet = "L" + getRandomID();
                chiTiet.MaDSMA = listId;
                chiTiet.MaMonAn = ma.MaMonAn;
                chiTiet.TenMonAn = ma.TenMonAn;
                chiTiet.SoLuong = amount;
                chiTiet.MaDVT = ma.MaDVT;
                chiTiet.Gia = ma.Gia;
                chiTiet.ThanhTien = ma.Gia * amount;
                chiTiet.GhiChu = "null";

                if (ChiTietDanhSachMonAn_BUS.AddNewFoodListDetail(chiTiet))
                    Console.WriteLine(chiTiet);
            }

            HoaDonMonAn hoaDon = new HoaDonMonAn();
            hoaDon.MaHoaDon = "B" + getRandomID();
            hoaDon.MaKH = this.CustomerPickCb.Text;
            hoaDon.MaDSMA = listId;
            hoaDon.TongTien = Double.Parse(this.TotalPrice.Text);
            hoaDon.TienNhan = 0.0;
            hoaDon.TienThua = 0.0;
            hoaDon.MaTinhTrang = "Pe";

            if (HoaDonMonAn_BUS.AddNewBill(hoaDon))
            {
                selectedFoodList.Clear();
                var bindingList = new BindingList<MonAn>(selectedFoodList);
                this.ListFoodRequestDGV.DataSource = bindingList;
                this.TotalPrice.Text = "0";
                BillLoad();
            }

        }

        private string getRandomID()
        {
            return String.Format("{0:d8}", (DateTime.Now.Ticks / 10) % 1000000000);
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

        #region Storage

        private List<NguyenLieu> ingredientSelectedList;
        List<NguyenLieu> ingredientList;
        private void StorageLoad()
        {
            IngredientLoad();
            RecommentText();
        }

        private void IngredientLoad()
        {
            ingredientList = NguyenLieu_BUS.IngredientList();
            if (ingredientList == null) ingredientList = new List<NguyenLieu>();
            this.MaterialDGV.DataSource = ingredientList;

            IReset();
        }

        private void IReset()
        {
            if (ingredientSelectedList == null)
                ingredientSelectedList = new List<NguyenLieu>();
            ingredientSelectedList.Clear();
            var bindingList = new BindingList<NguyenLieu>(ingredientSelectedList);
            this.ListMaterialDGV.DataSource = bindingList;

            this.MaterialReasonTxb.Text = "";
            this.MaterialNoteTxb.Text = "";
            this.ExportMaterialBtn.Enabled = true;
            this.MaterialNumberTxb.Text = "1";
        }

        private void RecommentText()
        {
            List<ChiTietDanhSachNguyenLieu> list = ChiTietDanhSachNguyenLieu_BUS.IngredientLists();
            if (list == null) return;
            AutoCompleteStringCollection l = new AutoCompleteStringCollection();
            foreach (ChiTietDanhSachNguyenLieu nl in list)
            {
                if (!l.Contains(nl.MaDSNL))
                    l.Add(nl.MaDSNL);
            }

            this.ImportListTxt.AutoCompleteCustomSource = l;
        }

        private void AddIEList()
        {
            try
            {
                NguyenLieu nl = this.MaterialDGV.SelectedRows[0].DataBoundItem as NguyenLieu;

                int index = ingredientSelectedList.FindIndex(x => x.MaNL == nl.MaNL);

                if (index != -1)
                {
                    ingredientSelectedList[index].SoLuong++;

                    if (ingredientSelectedList.Exists(x => x.SoLuong > nl.SoLuong))
                    {
                        this.ExportMaterialBtn.Enabled = false;

                    }
                }
                else
                {

                    NguyenLieu n = new NguyenLieu();
                    n.MaNL = nl.MaNL;
                    n.TenNL = nl.TenNL;
                    n.MaLoaiNL = nl.MaLoaiNL;
                    n.MaDVT = nl.MaDVT;
                    n.SoLuong = 1;

                    ingredientSelectedList.Add(n);
                    ingredientSelectedList[0].SoLuong = 1;
                }
                var bindingList = new BindingList<NguyenLieu>(ingredientSelectedList);
                this.ListMaterialDGV.DataSource = bindingList;
            }
            catch
            {
                return;
            }
        }

        private void DeleteIEList()
        {
            try
            {
                int index = this.ListMaterialDGV.SelectedRows[0].Index;
                if (ingredientSelectedList[index].SoLuong == 1)
                    ingredientSelectedList.RemoveAt(index);
                else
                    ingredientSelectedList[index].SoLuong--;

                if (ingredientList.Exists(x => x.MaNL == ingredientList[index].MaNL && x.SoLuong >= ingredientSelectedList[index].SoLuong))
                {
                    this.ExportMaterialBtn.Enabled = true;
                }

                var bindingList = new BindingList<NguyenLieu>(ingredientSelectedList);
                this.ListMaterialDGV.DataSource = bindingList;
            }
            catch
            {
                return;
            }
        }

        private void MaterialDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddIEList();
        }

        private void MaterialNumberTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            if (this.MaterialNumberTxb.Text == "1") return;
            this.MaterialNumberTxb.Text = (int.Parse(this.MaterialNumberTxb.Text) - 1).ToString();
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            this.MaterialNumberTxb.Text = (int.Parse(this.MaterialNumberTxb.Text) + 1).ToString();
        }

        private void AddMaterialBtn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.MaterialNumberTxb.Text);
            for (int i = 0; i < num; i++)
            {
                AddIEList();
            }
        }

        private void DeleteMaterialBtn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.MaterialNumberTxb.Text);
            for (int i = 0; i < num; i++)
            {
                DeleteIEList();
            }
        }


        private void RequestMaterialBtn_Click(object sender, EventArgs e)
        {
            string listId = "L" + getRandomID();
            if (this.ingredientSelectedList == null || this.ingredientSelectedList.Count == 0) return;

            foreach (NguyenLieu nl in ingredientSelectedList)
            {
                ChiTietDanhSachNguyenLieu ct = new ChiTietDanhSachNguyenLieu();
                ct.MaChiTiet = "D" + getRandomID();
                ct.MaDSNL = listId;
                ct.MaNL = nl.MaNL;
                ct.TenNL = nl.TenNL;
                ct.SoLuong = nl.SoLuong;
                ct.MaDVT = nl.MaDVT;
                ct.Gia = 0.0;
                ct.ThanhTien = 0.0;

                if (ChiTietDanhSachNguyenLieu_BUS.AddNewIngredientListDetail(ct))
                {
                    int sl = ingredientList.Find(x => x.MaNL == ct.MaNL).SoLuong + ct.SoLuong;
                    NguyenLieu_BUS.UpdateAmount(ct.MaNL, sl);
                    Console.WriteLine(ct.MaNL + ct.MaDSNL + ct.TenNL + ct.SoLuong.ToString() + ct.MaDVT + ct.Gia + ct.ThanhTien.ToString());
                }
            }

            PhieuNhapKho p = new PhieuNhapKho();
            p.MaPhieu = "F" + getRandomID();
            p.NgayLap = DateTime.Now.ToString();
            p.MaNV = "null";
            p.MaDSNL = listId;
            if (MaterialNoteTxb.Text == "") p.GhiChu = "null";
            else
                p.GhiChu = MaterialNoteTxb.Text;

            if (PhieuNhapKho_BUS.AddNewImport(p))
            {
                IngredientLoad();
                MessageBox.Show("Import completed");
            }

        }

        private void ExportMaterialBtn_Click(object sender, EventArgs e)
        {
            string listId = "L" + getRandomID();
            if (this.ingredientSelectedList == null || this.ingredientSelectedList.Count == 0) return;

            foreach (NguyenLieu nl in ingredientSelectedList)
            {
                ChiTietDanhSachNguyenLieu ct = new ChiTietDanhSachNguyenLieu();
                ct.MaChiTiet = "D" + getRandomID();
                ct.MaDSNL = listId;
                ct.MaNL = nl.MaNL;
                ct.TenNL = nl.TenNL;
                ct.SoLuong = nl.SoLuong;
                ct.MaDVT = nl.MaDVT;
                ct.Gia = 0.0;
                ct.ThanhTien = 0.0;

                if (ChiTietDanhSachNguyenLieu_BUS.AddNewIngredientListDetail(ct))
                {
                    int sl = ingredientList.Find(x => x.MaNL == ct.MaNL).SoLuong - ct.SoLuong;
                    NguyenLieu_BUS.UpdateAmount(ct.MaNL, sl);
                    Console.WriteLine(ct.MaNL + ct.MaDSNL + ct.TenNL + ct.SoLuong.ToString() + ct.MaDVT + ct.Gia + ct.ThanhTien.ToString());
                }
            }

            PhieuNhapKho p = new PhieuNhapKho();
            p.MaPhieu = "F" + getRandomID();
            p.NgayLap = DateTime.Now.ToString();
            p.MaNV = "null";
            p.MaDSNL = listId;
            if (MaterialNoteTxb.Text == "") p.GhiChu = "null";
            else
                p.GhiChu = MaterialNoteTxb.Text;

            if (PhieuNhapKho_BUS.AddNewImport(p))
                MessageBox.Show("Import completed");
        }

        private void ImportMaterialBtn_Click(object sender, EventArgs e)
        {
            string id = this.ImportListTxt.Text;
            List<ChiTietDanhSachNguyenLieu> list = ChiTietDanhSachNguyenLieu_BUS.IngredientList(id);
            if (list == null) return;

            ingredientSelectedList.Clear();

            foreach(ChiTietDanhSachNguyenLieu ct in list)
            {
                NguyenLieu nl = new NguyenLieu();
                nl.MaNL = ct.MaNL;
                nl.TenNL = ct.TenNL;
                nl.SoLuong = ct.SoLuong;
                ingredientSelectedList.Add(nl);
            }

            var bindingList = new BindingList<NguyenLieu>(ingredientSelectedList);
            this.ListMaterialDGV.DataSource = bindingList;
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
                IngredientLoad();
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


            foreach(ChiTietDanhSachNguyenLieu nl in IList)
            {
                nl.MaDSNL = listID;
                if (ChiTietDanhSachNguyenLieu_BUS.AddNewIngredientListDetail(nl))
                    RecommentText();
            }

            PhieuThanhToan p = new PhieuThanhToan();
            p.MaPhieu = "F" + getRandomID();
            p.MaDL = this.SupplierNameCb.Text;
            p.NgayLap = DateTime.Now.ToString();
            p.MaDSNL = listID;
            p.TongTien = Double.Parse(this.totaltxt.Text);
            p.MaTrangThai = "Co";
            if (this.SupplierEmailTxb.Text == "")
                p.GhiChu = "none";
            else p.GhiChu = this.SupplierEmailTxb.Text;

            if (PhieuThanhToan_BUS.AddNewAgent(p))
            {
                FReset();
                MessageBox.Show("Add successfully");
            }
        }

        private void FReset()
        {
            this.SupplierEmailTxb.Text = "";
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

        
    }
}
