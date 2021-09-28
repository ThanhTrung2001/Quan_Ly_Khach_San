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
            FoodGridLoad();
            TypeCbbLoad();
            CustomerLoad();
        }

        #region Menu

        private string foodName = "";
        private string foodType = "";
        private List<MonAn> selectedFoodList;

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
            if (list == null) return;
            this.FoodTypeCb.ValueMember = "MaLoaiMonAn";
            this.FoodTypeCb.DisplayMember = "TLoaiMonAn";

            LoaiMonAn lma = new LoaiMonAn();
            lma.MaLoaiMonAn = "";
            lma.TLoaiMonAn = "All";
            this.FoodTypeCb.Items.Add(lma);
           
            foreach(LoaiMonAn loaiMonAn in list)
            {
                this.FoodTypeCb.Items.Add(loaiMonAn);
            }
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


        //have bugs
        private void FoodTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //foodType = FoodTypeCb.SelectedValue.ToString();
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
            string listId = "LF" + getRandomID();
            if (this.selectedFoodList == null || this.selectedFoodList.Count == 0 || CustomerPickCb.Text == "") return;

            var requestList = selectedFoodList.GroupBy(i => i);
            foreach(var g in requestList)
            {
                ChiTietDanhSachMonAn chiTiet = new ChiTietDanhSachMonAn();
                chiTiet.MaChiTiet = "LD" + getRandomID();
                chiTiet.MaDSMA = listId;
                chiTiet.MaMonAn = g.Key.MaMonAn;
                chiTiet.TenMonAn = g.Key.TenMonAn;
                chiTiet.SoLuong = g.Count();
                chiTiet.MaDVT = g.Key.MaDVT;
                chiTiet.Gia = g.Key.Gia;
                chiTiet.ThanhTien = chiTiet.Gia * Double.Parse(chiTiet.SoLuong.ToString());
                chiTiet.GhiChu = " ";

                if (ChiTietDanhSachMonAn_BUS.AddNewFoodListDetail(chiTiet))
                    Console.WriteLine(chiTiet);
            }

            HoaDonMonAn hoaDon = new HoaDonMonAn();
            hoaDon.MaHoaDon = "B" + getRandomID();
            hoaDon.MaKH = this.CustomerPickCb.Text;
            hoaDon.MaDSMA = listId;
            hoaDon.TongTien = Double.Parse(this.TotalPrice.Text);
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


    }
}
