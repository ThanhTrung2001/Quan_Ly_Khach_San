using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Quan_Ly_Khach_San.GUI
{
    public partial class Add_Supplier_Form : Form
    {
        public Add_Supplier_Form()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (this.IngredientNameTxb.Text == "" || this.TypeTxb.Text == "")
            {
                MessageBox.Show("Enter customer name and customer indentify numbers");
                return;
            }
            DaiLy daiLy = new DaiLy();
        }
    }
}
