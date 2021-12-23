using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San.GUI
{
    public partial class Add_DVT_Form : Form
    {
        Form f;
        public Add_DVT_Form(Form form)
        {
            InitializeComponent();
            f = form;
        }

        private void AddBtn_Click(object sender, System.EventArgs e)
        {
            if(this.UnitIDTxb.Text == "" || this. UnitNameTxb.Text == "")
            {
                MessageBox.Show("Please enter full information");
                return;
            }

            DonViTinh dvt = new DonViTinh();
            dvt.MaDVT = this.UnitIDTxb.Text;
            dvt.DVT = this.UnitNameTxb.Text;

            if (DonViTinh_BUS.AddUnit(dvt))
            {
                if(f is Add_Food_Form)
                {
                    ((Add_Food_Form)f).UnitLoad();
                }
                else if(f is Add_Service_Form)
                {
                    ((Add_Service_Form)f).UnitLoad();
                }
                Reset();
            }
        }

        private void Add_DVT_Form_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            this.UnitIDTxb.Text = "";
            this.UnitNameTxb.Text = "";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnitNameTxb_TextChanged(object sender, EventArgs e)
        {
            this.UnitIDTxb.Text = this.UnitNameTxb.Text.ToLower();
        }
    }
}
