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
            StorageLoad();
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

        public void FoodGridLoad()
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
            if (ClassPublic.NavigationVar == "Food")
            {
                this.CustomerPickCb.Text = ClassPublic.Customerid;
                ClassPublic.NavigationVar = "";
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

        private void NewFoodBtn_Click(object sender, EventArgs e)
        {
            Add_Food_Form add_Food_Form = new Add_Food_Form(this);
            add_Food_Form.ShowDialog();
        }

        private void AddSelectedList(MonAn selectedFood)
        {
            if (selectedFoodList == null)
            {
                selectedFoodList = new List<MonAn>();
            }

            selectedFoodList.Add(selectedFood);

            UpdateFoodRequest();
        }

        private void UpdateFoodRequest()
        {
            try
            {
                double total = 0;
                List<ChiTietDanhSachMonAn> list = new List<ChiTietDanhSachMonAn>();
                var requestList = selectedFoodList.GroupBy(i => i);

                foreach (var g in requestList)
                {
                    MonAn ma = g.Key;
                    int amount = g.Count();

                    ChiTietDanhSachMonAn chiTiet = new ChiTietDanhSachMonAn();
                    chiTiet.MaMonAn = ma.MaMonAn;
                    chiTiet.TenMonAn = ma.TenMonAn;
                    chiTiet.SoLuong = amount;
                    chiTiet.Gia = ma.Gia;
                    list.Add(chiTiet);
                }

                var bindingList = new BindingList<ChiTietDanhSachMonAn>(list);
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
                string mama = ListFoodRequestDGV.SelectedRows[0].Cells["maMonAn"].Value.ToString();
                selectedFoodList.RemoveAt(selectedFoodList.FindLastIndex(x => x.MaMonAn == mama));
                UpdateFoodRequest();
            }
            catch
            {
                return;
            }
        }

        private void RequestFoodBtn_Click(object sender, EventArgs e)
        {
            string listId = "L" + getRandomID();
            if (this.selectedFoodList == null || this.selectedFoodList.Count == 0 ) return;
            if (this.CustomerPickCb.Text == "")
            {
                MessageBox.Show("Please enter Customer");
                return;
            }
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
            }

        }

        private string getRandomID()
        {
            return String.Format("{0:d8}", (DateTime.Now.Ticks / 10) % 1000000000);
        }


        #endregion

        #region Storage

        public List<NguyenLieu> ingredientSelectedList;
        public List<NguyenLieu> ingredientList;
        private void StorageLoad()
        {
            TypeILoad();
            IngredientLoad();
        }

        public void IngredientLoad()
        {
            ingredientList = NguyenLieu_BUS.IngredientList();
            if (ingredientList == null) ingredientList = new List<NguyenLieu>();
            this.MaterialDGV.DataSource = ingredientList;

            IReset();
        }

        private void TypeILoad()
        {
            List<LoaiNguyenLieu> list = LoaiNguyenLieu_BUS.IngredientTypeList();
            LoaiNguyenLieu lnl = new LoaiNguyenLieu();
            lnl.MaLoaiNL = "";
            lnl.TLoaiNguyenLieu = "All";
            list.Insert(0, lnl);
            this.IngredientTypeCBB.DataSource = list;
            this.IngredientTypeCBB.DisplayMember = "TloaiNguyenLieu";
            this.IngredientTypeCBB.ValueMember = "MaLoaiNL";
        }

        private void SearchMaterialTxb_TextChanged(object sender, EventArgs e)
        {
            ingredientList = NguyenLieu_BUS.IngredientListWithSearch(this.SearchMaterialTxb.Text, this.IngredientTypeCBB.SelectedValue.ToString());
            if (ingredientList == null) ingredientList = new List<NguyenLieu>();
            this.MaterialDGV.DataSource = ingredientList;
        }

        private void IngredientTypeCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredientList = NguyenLieu_BUS.IngredientListWithSearch(this.SearchMaterialTxb.Text, this.IngredientTypeCBB.SelectedValue.ToString());
            if (ingredientList == null) ingredientList = new List<NguyenLieu>();
            this.MaterialDGV.DataSource = ingredientList;
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
                if (this.ListMaterialDGV.SelectedRows == null)
                    return;

                int index = this.ListMaterialDGV.SelectedRows[0].Index;

                if (ingredientSelectedList[index].SoLuong == 1)
               
                        ingredientSelectedList.RemoveAt(index);
                else
                    ingredientSelectedList[index].SoLuong--;

                if (ingredientList.Exists(x => x.MaNL == ingredientSelectedList[index].MaNL && x.SoLuong >= ingredientSelectedList[index].SoLuong))
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
                AddAgentBill(listId);
                IngredientLoad();
                MessageBox.Show("Import completed");
            }

        }

        private void AddAgentBill(string ListID)
        {
            PhieuThanhToan phieuThanhToan = new PhieuThanhToan();
            phieuThanhToan.MaPhieu = "A" + getRandomID();
            phieuThanhToan.NgayLap = DateTime.Now.ToString();
            phieuThanhToan.MaDSNL = ListID;
            phieuThanhToan.MaTrangThai = "Pe";
            phieuThanhToan.TongTien = 0.0;

            if (PhieuThanhToan_BUS.AddNewAgent(phieuThanhToan))
            {
                Console.WriteLine(phieuThanhToan);
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

            PhieuXuatKho p = new PhieuXuatKho();
            p.MaPhieu = "F" + getRandomID();
            p.NgayLap = DateTime.Now.ToString();
            p.MaNV = "null";
            p.MaDSNL = listId;
            if (MaterialNoteTxb.Text == "") p.GhiChu = "null";
            else
                p.GhiChu = MaterialNoteTxb.Text;
            if (this.MaterialReasonTxb.Text == "") p.LyDo = "null";
            else p.LyDo = this.MaterialReasonTxb.Text;

            if (PhieuXuatKho_BUS.AddNewExport(p))
            {
                IngredientLoad();
                MessageBox.Show("Export completed");
            }
        }

        private void ImportMaterialBtn_Click(object sender, EventArgs e)
        {
            Add_Ingredient_Form form = new Add_Ingredient_Form(this);
            form.ShowDialog();
        }

        private void FoodNumberTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ListMaterialDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteIEList();
        }




        #endregion

        //In put


    }
}
