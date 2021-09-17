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
    public partial class Statistic_Manage : Form
    {
        public Statistic_Manage()
        {
            InitializeComponent();
        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {
            Food_Report rp = new Food_Report();
            rp.ShowDialog();
        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            Supplier_Report rp = new Supplier_Report();
            rp.ShowDialog();
        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            Room_Service_Report rp = new Room_Service_Report();
            rp.ShowDialog();
        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {
            Room_Service_Report rp = new Room_Service_Report();
            rp.ShowDialog();
        }

        private void DailyBtn_Click(object sender, EventArgs e)
        {
            Daily_Report rp = new Daily_Report();
            rp.ShowDialog();
        }

        private void MonthlyBtn_Click(object sender, EventArgs e)
        {
            Monthly_Report rp = new Monthly_Report();
            rp.ShowDialog();
        }
    }
}
