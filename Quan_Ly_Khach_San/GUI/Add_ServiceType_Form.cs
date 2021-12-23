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
    public partial class Add_ServiceType_Form : Form
    {
        Add_Service_Form ff;
        public Add_ServiceType_Form(Add_Service_Form add_Service_Form)
        {
            InitializeComponent();
            ff = add_Service_Form;
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
            if (this.TypeIDTxb.Text == "" || this.TypeNameTxb.Text == "")
            {
                MessageBox.Show("Please enter full information");
                return;
            }

            LoaiDichVu lma = new LoaiDichVu();
            lma.MaLoaiDichVu = this.TypeIDTxb.Text;
            lma.TLoaiDichVu = this.TypeNameTxb.Text;

            if (LoaiDichVu_BUS.AddServiceType(lma))
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

