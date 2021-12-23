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

namespace Quan_Ly_Khach_San.GUI
{
    public partial class Add_Food_Form : Form
    {
        private Food_Form ff;
        public Add_Food_Form(Food_Form food_Form)
        {
            InitializeComponent();
            ff = food_Form;
        }

        private void Add_Food_Form_Load(object sender, EventArgs e)
        {
            TypeLoad();
            UnitLoad();
            Reset();
        }

        private void Reset()
        {
            this.FoodIDtxt.Text = "F" + getRandomID();
            this.FoodNameTxt.Text = "";
            this.FoodPriceTxt.Text = "";
            this.FoodNoteTxt.Text = "";
        }

        public void UnitLoad()
        {
            List<DonViTinh> list = DonViTinh_BUS.MeasureList();
            if (list == null) list = new List<DonViTinh>();

            this.FoodUnitCbb.DataSource = list;
            this.FoodUnitCbb.DisplayMember = "DVT";
            this.FoodUnitCbb.ValueMember = "MaDVT";

            if (list.Count > 0) this.FoodUnitCbb.SelectedIndex = 1;
        }

        public void TypeLoad()
        {
            List<LoaiMonAn> list = LoaiMonAn_BUS.FoodTypeList();
            if (list == null) list = new List<LoaiMonAn>();

            this.FoodTypeCbb.DataSource = list;
            this.FoodTypeCbb.DisplayMember = "TLoaiMonAn";
            this.FoodTypeCbb.ValueMember = "MaLoaiMonAn";

            if (list.Count > 0) this.FoodTypeCbb.SelectedIndex = 1;
        }

        private string getRandomID()
        {
            return String.Format("{0:d8}", (DateTime.Now.Ticks / 10) % 1000000000);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (this.FoodNameTxt.Text == "" || this.FoodPriceTxt.Text == "")
            {
                MessageBox.Show("Please enter full information");
                return;
            }

            MonAn ma = new MonAn();
            ma.MaMonAn = this.FoodIDtxt.Text;
            ma.TenMonAn = this.FoodNameTxt.Text;
            ma.MaLoaiMonAn = this.FoodTypeCbb.SelectedValue.ToString();
            ma.MaDVT = this.FoodUnitCbb.SelectedValue.ToString();
            ma.Gia = Double.Parse(this.FoodPriceTxt.Text);
            ma.GhiChu = " " + this.FoodNoteTxt.Text;

            if (MonAn_BUS.AddFood(ma))
            {
                Reset();
                ff.FoodGridLoad();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FoodPriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NewTypeBtn_Click(object sender, EventArgs e)
        {
            Add_FoodType_form add_FoodType_Form = new Add_FoodType_form(this);
            add_FoodType_Form.ShowDialog();
        }

        private void NewUnitBtn_Click(object sender, EventArgs e)
        {
            Add_DVT_Form form = new Add_DVT_Form(this);
            form.ShowDialog();
        }
    }
}
