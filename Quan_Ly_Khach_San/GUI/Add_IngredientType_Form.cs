using System;
using BUS;
using DTO;
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
    public partial class Add_IngredientType_Form : Form
    {
        Add_Ingredient_Form addIngre;
        public Add_IngredientType_Form(Add_Ingredient_Form form)
        {
            InitializeComponent();
            addIngre = form;
        }

        private string getRandomID()
        {
            return String.Format("{0:d8}", (DateTime.Now.Ticks / 10) % 1000000000);
        }
        private void Reset()
        {
            this.TypeIDTxb.Text = "T" + getRandomID();
            this.TypeNameTxb.Text = "";
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (this.TypeIDTxb.Text == "" || this.TypeNameTxb.Text == "")
            {
                MessageBox.Show("Please enter full information");
                return;
            }

            LoaiNguyenLieu lnl = new LoaiNguyenLieu();
            lnl.MaLoaiNL = this.TypeIDTxb.Text;
            lnl.TLoaiNguyenLieu = this.TypeNameTxb.Text;

            if (LoaiNguyenLieu_BUS.AddIngredientType(lnl))
            {
                Reset();
                addIngre.TypeLoad();
            }
        }

        private void Add_IngredientType_Form_Load(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
