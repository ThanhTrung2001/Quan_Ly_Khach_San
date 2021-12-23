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
    public partial class Add_FoodType_form : Form
    {
        Add_Food_Form ff;
        public Add_FoodType_form(Add_Food_Form foodform)
        {
            InitializeComponent();
            ff = foodform;
        }

        private string getRandomID()
        {
            return String.Format("{0:d8}", (DateTime.Now.Ticks / 10) % 1000000000);
        }

        private void Add_FoodType_form_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            this.TypeIDTxb.Text = "T" + getRandomID();
            this.TypeNameTxb.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(this.TypeIDTxb.Text == ""|| this.TypeNameTxb.Text == "")
            {
                MessageBox.Show("Please enter full information");
                return;
            }

            LoaiMonAn lma = new LoaiMonAn();
            lma.MaLoaiMonAn = this.TypeIDTxb.Text;
            lma.TLoaiMonAn = this.TypeNameTxb.Text;

            if (LoaiMonAn_BUS.AddFoodType(lma))
            {
                Reset();
                ff.TypeLoad();
            }

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
