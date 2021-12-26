using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San.GUI
{
    public partial class Add_Ingredient_Form : Form
    {

        private Food_Form ff;
        public Add_Ingredient_Form()
        {
            InitializeComponent();
        }

        public Add_Ingredient_Form(Food_Form food_Form)
        {
            ff = food_Form;
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string getRandomID()
        {
            return String.Format("{0:d8}", (DateTime.Now.Ticks / 10) % 1000000000);
        }

        private void Add_Ingredient_Form_Load(object sender, EventArgs e)
        {
            this.IngredientIDtxt.Text = "I" + getRandomID();
            TypeLoad();
            UnitLoad();
        }

        public void UnitLoad()
        {
            List<DonViTinh> list = DonViTinh_BUS.MeasureList();
            if (list == null) return;

            this.IngredientUnittxt.DataSource = list;
            this.IngredientUnittxt.DisplayMember = "DVT";
            this.IngredientUnittxt.ValueMember = "maDVT";
        }

        public void TypeLoad()
        {
            List<LoaiNguyenLieu> list = LoaiNguyenLieu_BUS.IngredientTypeList();
            if (list == null) return;

            this.IngredientStyletxt.DataSource = list;
            this.IngredientStyletxt.DisplayMember = "TLoaiNguyenLieu";
            this.IngredientStyletxt.ValueMember = "maLoaiNL";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (this.IngredientNametxt.Text == "")
            {
                MessageBox.Show("Please enter enough information!");
                return;
            }
            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.MaNL = this.IngredientIDtxt.Text;
            nguyenLieu.TenNL = this.IngredientNametxt.Text.ToUpper();
            nguyenLieu.MaLoaiNL = this.IngredientStyletxt.SelectedValue.ToString();
            nguyenLieu.MaDVT = this.IngredientUnittxt.SelectedValue.ToString();

            if (NguyenLieu_BUS.AddNewIngredient(nguyenLieu))
            {
                MessageBox.Show("Successful");
                Reset();
            }
        }

        private void Reset()
        {
            this.IngredientIDtxt.Text = "I" + getRandomID();
            this.IngredientNametxt.Text = "";

            ff.IngredientLoad();
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            Add_DVT_Form form = new Add_DVT_Form(this);
            form.ShowDialog();
        }
    }
}
