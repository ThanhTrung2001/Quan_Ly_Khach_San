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
    public partial class Service_Form : Form
    {
        private string serviceName;
        private string riskId;
        private List<DichVu> selectedServiceList;
        public Service_Form()
        {
            InitializeComponent();
            LoadServiceList();
            CustomerLoad();
            BillLoad();
            LoadRisk();
                
        }
        
        
        
        #region Service

        //Load ServiceList To GridView
        private void LoadServiceList()
        {
            List<DichVu> serviceList = DichVu_BUS.ServiceList();
            if(serviceList == null)
            {
                serviceList = new List<DichVu>();
            }
            this.ServiceListDGV.DataSource = serviceList;
        }

        //Customer
        private void CustomerLoad()
        {
            this.CustomerSelectCb.Items.Clear();
            List<KhachHang> list = KhachHang_BUS.CustomerList();
            if (list == null) return;
            this.CustomerSelectCb.ValueMember = "maKH";
            this.CustomerSelectCb.DisplayMember = "maKH";

            foreach (KhachHang khachHang in list)
            {
                this.CustomerSelectCb.Items.Add(khachHang);
            }
        }

        //Search Service
        private void SearchServiceTxb_TextChanged(object sender, EventArgs e)
        {
            serviceName = SearchServiceTxb.Text;
            List<DichVu> serviceList = DichVu_BUS.ServiceListWithSearch(serviceName);
            if (serviceList == null)
            {
                serviceList = new List<DichVu>();
            }
            this.ServiceListDGV.DataSource = serviceList;
        }
        //Sub & Plus Button
        private void SubBtn_Click(object sender, EventArgs e)
        {
            if(this.ServiceNumberTxb.Text == "1")
            {
                return;
            }
            this.ServiceNumberTxb.Text = (int.Parse(ServiceNumberTxb.Text) - 1).ToString();
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            this.ServiceNumberTxb.Text = (int.Parse(ServiceNumberTxb.Text) + 1).ToString();
        }

        //SHow Information about Service in textbox below
       
        private void ServiceListDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = ServiceListDGV.CurrentRow.Index;
            this.ServiceNameTxb.Text = ServiceListDGV.Rows[i].Cells[2].Value.ToString();
            this.ServiceTypeTxb.Text = ServiceListDGV.Rows[i].Cells[3].Value.ToString();
            this.ServicePriceTxb.Text = ServiceListDGV.Rows[i].Cells[5].Value.ToString();
        }
        //Add new or Remove Service 
        private void AddServiceBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteServiceBtn_Click(object sender, EventArgs e)
        {

        }

        //Add Service to List Selected
        private void AddSelectedList(DichVu selectedService) 
        {
            double total = 0;
            if (selectedServiceList == null)
            {
                selectedServiceList = new List<DichVu>();

            }

            selectedServiceList.Add(selectedService);

            var bindingList = new BindingList<DichVu>(selectedServiceList);
            this.ServicePickedDGV.DataSource = bindingList;

            foreach (DichVu ma in selectedServiceList)
            {
                total += ma.Gia * ma.SoLuong;
            }

            this.TotalPriceTxb1.Text = total.ToString();
        }

      
        private void RequestServiceBtn_Click(object sender, EventArgs e)
        {

            try
            {
                int amount = int.Parse(ServiceNumberTxb.Text);
                DichVu dichVu = ServiceListDGV.SelectedRows[0].DataBoundItem as DichVu;
                dichVu.SoLuong = amount;
                    AddSelectedList(dichVu);
            }
            catch
            {
                MessageBox.Show("Add failed");
                return;
            }
        }
        private void ServiceListDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DichVu selectedService = ServiceListDGV.Rows[e.RowIndex].DataBoundItem as DichVu;
                AddSelectedList(selectedService);
            }
            catch
            {
                MessageBox.Show("Add failed");
                return;
            }
        }

        //Remove Selected Service
        private void DeleteRow()
        {
            try
            {
                double total = 0;
                selectedServiceList.RemoveAt(ServicePickedDGV.SelectedRows[0].Index);

                var bindingList = new BindingList<DichVu>(selectedServiceList);
                this.ServicePickedDGV.DataSource = bindingList;

                foreach (DichVu ma in selectedServiceList)
                {
                    total += ma.Gia;
                }

                this.totalPrice.Text = total.ToString();
            }
            catch
            {
                return;
            }
        }

        private void RemoveServiceBtn_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }
        private void ServicePickedDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteRow();
        }



        //generate Random ID
        private string getRandomID()
        {
            return String.Format("{0:d8}", (DateTime.Now.Ticks / 10) % 1000000000);
        }

        //Add new Customer
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            Add_Customer_Form add = new Add_Customer_Form();
            add.ShowDialog();
        }

        //Request List Service
        private void RequestServiceListBtn_Click(object sender, EventArgs e)
        {
            string listId = "L" + getRandomID();
            if (this.selectedServiceList == null || this.selectedServiceList.Count == 0 || CustomerSelectCb.Text == "")
            {
                return;
            }
            var requestList = selectedServiceList.GroupBy(i => i);
            foreach (var g in requestList)
            {
                DichVu ma = g.Key;
                int amount = g.Count();

                ChiTietDanhSachDichVu chiTiet = new ChiTietDanhSachDichVu();
                chiTiet.MaChiTietDV = "L" + getRandomID();
                chiTiet.MaDSDV = listId;
                chiTiet.MaDV = ma.MaDV;
                chiTiet.MaLoaiDV = ma.MaLoaiDV;
                chiTiet.SoLuong = amount;
                chiTiet.MaDVT = ma.MaDVT;
                chiTiet.Gia = ma.Gia;
                chiTiet.ThanhTien = ma.Gia * amount;
                chiTiet.GhiChu = "null";

                if (ChiTietDanhSachDichVu_BUS.AddNewListServiceDetail(chiTiet))
                    Console.WriteLine(chiTiet);
            }

            HoaDonDichVu hoaDon = new HoaDonDichVu();
            hoaDon.MaHoaDon = "B" + getRandomID();
            hoaDon.Checkin = DateTime.Now.ToString();
            hoaDon.Checkout = DateTime.Now.AddDays(1).ToString(); // Ve su dung dich vu het han trong 1 ngay
            hoaDon.MaKH = this.CustomerSelectCb.Text;
            hoaDon.MaDSDV = listId;
            hoaDon.TongTien = Double.Parse(this.TotalPriceTxb1.Text);
            hoaDon.TienNhan = 0.0;
            hoaDon.TienThua = 0.0;
            hoaDon.MaTinhTrang = "Pe";

            if (HoaDonDichVu_BUS.AddNewServiceBill(hoaDon))
            {
                selectedServiceList.Clear();
                var bindingList = new BindingList<DichVu>(selectedServiceList);
                this.ServicePickedDGV.DataSource = bindingList;
                this.TotalPriceTxb1.Text = "0";
            }

        }

        #endregion

        #region Request

        //Load Bill data to DGV
        private void BillLoad()
        {
            List<HoaDonDichVu> serviceBillList = HoaDonDichVu_BUS.ServiceBillPendingList();
            if (serviceBillList == null)
            { serviceBillList = new List<HoaDonDichVu>(); 
            }
            this.ServiceBillDgv.DataSource = serviceBillList;
        }

        //Show Bill data
        private void ServiceBillDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = ServiceBillDgv.CurrentRow.Index;

            this.ServiceBillid.Text =   ServiceBillDgv.Rows[i].Cells[0].ToString();
            this.checkInDate.Text =     ServiceBillDgv.Rows[i].Cells[1].ToString();
            this.checkOutDate.Text =    ServiceBillDgv.Rows[i].Cells[2].ToString();
            this.customerId.Text =      ServiceBillDgv.Rows[i].Cells[4].ToString(); 
            this.serviceListId.Text =   ServiceBillDgv.Rows[i].Cells[5].ToString();
            this.totalPriceTxb.Text =   ServiceBillDgv.Rows[i].Cells[6].ToString();
            this.receiveTxb.Text =      ServiceBillDgv.Rows[i].Cells[7].ToString();
            this.returnTxb.Text =       ServiceBillDgv.Rows[i].Cells[8].ToString();
            this.risk.Text =            ServiceBillDgv.Rows[i].Cells[9].ToString();
            this.refundTxb.Text =       ServiceBillDgv.Rows[i].Cells[10].ToString();
            this.noteServiceBill.Text = ServiceBillDgv.Rows[i].Cells[12].ToString();

        }

        //Load Risk data to CBbox and Choose
        private void LoadRisk()
        {
            List<RuiRo> riskList = RuiRo_BUS.RiskList();
            if (riskList == null) riskList = new List<RuiRo>();
            this.riskDgv.DataSource = riskList;
        }
        private void riskDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = riskDgv.CurrentRow.Index;
            this.risk.Text = riskDgv.Rows[i].Cells[0].Value.ToString();
            this.refundTxb.Text = riskDgv.Rows[i].Cells[2].Value.ToString();

            double refund = Double.Parse(this.refundTxb.Text);
            double total = Double.Parse(this.totalPriceTxb.Text);
            double re = total - refund;

            this.totalPriceTxb.Text = re.ToString();
        }
        private void receiveTxb_TextChanged(object sender, EventArgs e)
        {
            if (this.receiveTxb.Text == "")
            {
                return;
            }
            int receive = int.Parse(receiveTxb.Text);
            int total = int.Parse(totalPriceTxb.Text);
            if(receive < total)
            {
                MessageBox.Show("Not Enough Money!", "Error");
                this.receiveTxb.Text = "";
            }
            else
            {
                if(refundTxb.Text == "" || refundTxb.Text == "0")
                {
                    returnTxb.Text = (receive - total).ToString();
                }
                else
                {
                    int refund = int.Parse(refundTxb.Text);
                    returnTxb.Text = (receive - total + refund).ToString();
                }
            }
        }

        private void ConfirmRequestBtn_Click(object sender, EventArgs e)
        {
            if(receiveTxb.Text == "")
            {
                MessageBox.Show("Not Enough Money!");
            }
            else
            {
                HoaDonDichVu hoaDonDichVu = new HoaDonDichVu();
                hoaDonDichVu.MaHoaDon = this.ServiceBillid.Text;
                hoaDonDichVu.TongTien = Double.Parse(this.totalPriceTxb.Text);
                hoaDonDichVu.MaRR = this.risk.Text;
                hoaDonDichVu.SoTienHoan = Double.Parse(this.refundTxb.Text);
                hoaDonDichVu.TienNhan = Double.Parse(this.receiveTxb.Text);
                hoaDonDichVu.TienThua = Double.Parse(this.returnTxb.Text);
                hoaDonDichVu.GhiChu = this.noteServiceBill.Text;
                hoaDonDichVu.MaTinhTrang = "Co";
                if(HoaDonDichVu_BUS.UpdateServiceBill(hoaDonDichVu))
                {
                    MessageBox.Show("Payment completed");
                    BillLoad();

                    ServiceBillid.Text = "";
                    checkInDate.Text = "";
                    checkOutDate.Text = "";
                    customerId.Text = "";
                    serviceListId.Text = "";
                    totalPriceTxb.Text = "";
                    receiveTxb.Text = "";
                    returnTxb.Text = "";
                    risk.Text = "";
                    refundTxb.Text = "";
                    noteServiceBill.Text = "";
                }
            }
        }

        private void CancelRequestBtn_Click(object sender, EventArgs e)
        {
            ServiceBillid.Text = "";
            checkInDate.Text = "";
            checkOutDate.Text = "";
            customerId.Text = "";
            serviceListId.Text = "";
            totalPriceTxb.Text = "";
            receiveTxb.Text = "";
            returnTxb.Text = "";
            risk.Text = "";
            refundTxb.Text = "";
            noteServiceBill.Text = "";
            int i = ServiceBillDgv.CurrentRow.Index;
        }


        #endregion

        
    }


}
