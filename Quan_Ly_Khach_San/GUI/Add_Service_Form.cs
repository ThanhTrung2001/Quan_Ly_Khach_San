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
    public partial class Add_Service_Form : Form
    {
        Service_Form f;
        public Add_Service_Form(Service_Form form)
        {
            InitializeComponent();
            f = form;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Service_Form_Load(object sender, EventArgs e)
        {
            Reset();
            TypeLoad();
            UnitLoad();
            StatusLoad();
        }

        private void StatusLoad()
        {
            List<TinhTrang> list = TinhTrang_BUS.StatusList();
            if (list == null) list = new List<TinhTrang>();

            this.ServiceStatusCbb.DataSource = list;
            this.ServiceStatusCbb.DisplayMember = "TenTinhTrang";
            this.ServiceStatusCbb.ValueMember = "MaTinhTrang";

            if (list.Count > 0) this.ServiceStatusCbb.SelectedIndex = 1;
        }

        public void UnitLoad()
        {
            List<DonViTinh> list = DonViTinh_BUS.MeasureList();
            if (list == null) list = new List<DonViTinh>();

            this.ServiceUnittxt.DataSource = list;
            this.ServiceUnittxt.DisplayMember = "DVT";
            this.ServiceUnittxt.ValueMember = "MaDVT";

            if (list.Count > 0) this.ServiceUnittxt.SelectedIndex = 1;
        }

        public void TypeLoad()
        {
            List<LoaiDichVu> list = LoaiDichVu_BUS.ServiceTypeList();
            if (list == null) list = new List<LoaiDichVu>();

            this.ServiceTypetxt.DataSource = list;
            this.ServiceTypetxt.DisplayMember = "TLoaiDichVu";
            this.ServiceTypetxt.ValueMember = "MaLoaiDichVu";

            if (list.Count > 0) this.ServiceTypetxt.SelectedIndex = 1;
        }

        private void Reset()
        {
            this.ServiceIDtxt.Text = "S" + getRandomID();
            this.ServiceNametxt.Text = "";
            this.ServicePriceTxt.Text = "";
        }

        private void FoodPriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string getRandomID()
        {
            return String.Format("{0:d8}", (DateTime.Now.Ticks / 10) % 1000000000);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(this.ServiceIDtxt.Text == ""|| this.ServiceNametxt.Text == ""|| this.ServicePriceTxt.Text == "")
            {
                MessageBox.Show("Please enter full information");
                return;
            }

            DichVu dv = new DichVu();
            dv.MaDV = this.ServiceIDtxt.Text;
            dv.TenDV = this.ServiceNametxt.Text.ToUpper();
            dv.MaLoaiDV = this.ServiceTypetxt.SelectedValue.ToString();
            dv.MaDVT = this.ServiceUnittxt.SelectedValue.ToString();
            dv.Gia = Double.Parse(this.ServicePriceTxt.Text);
            dv.MaTinhTrang = this.ServiceStatusCbb.SelectedValue.ToString();
            dv.SoLuong = 1;

            if (DichVu_BUS.AddNewService(dv))
            {
                Reset();
                f.LoadServiceList();
            }

        }

        private void ServicePriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            Add_DVT_Form form = new Add_DVT_Form(this);
            form.ShowDialog();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            Add_ServiceType_Form form = new Add_ServiceType_Form(this);
            form.ShowDialog();
        }
    }
}
