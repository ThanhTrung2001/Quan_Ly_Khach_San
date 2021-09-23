using Quan_Ly_Khach_San.BUS;
using Quan_Ly_Khach_San.DTO;
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
    public partial class Risk_Form : Form
    {
        public Risk_Form()
        {
            InitializeComponent();
        }

        private void reset()
        {
            this.RiskCodeTxb.Text = "";
            this.RiskTypeTxb.Text = "";
            this.RiskCostTxb.Text = "";
        }

        private void LoadRisk()
        {
            List<RuiRo> riskList = RuiRo_BUS.RiskList();
            if (riskList == null) riskList = new List<RuiRo>();
            this.RiskGrid.DataSource = riskList;
        }

        private void Risk_Form_Load(object sender, EventArgs e)
        {
            LoadRisk();
            reset();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (this.RiskTypeTxb.Text == "")
            {
                MessageBox.Show("Enter risk type to continue");
                return;
            }

            RuiRo ruiRo = new RuiRo();
            ruiRo.MaRR = this.RiskCodeTxb.Text;
            ruiRo.LoaiRR = this.RiskTypeTxb.Text;
            ruiRo.PhanHoanTien = double.Parse(this.RiskCostTxb.Text);

            List<RuiRo> list = RuiRo_BUS.SearchedRisk(ruiRo.MaRR);

            if (list == null)
            {
                if (RuiRo_BUS.AddNewRisk(ruiRo))
                    MessageBox.Show("Added new risk");
            }
            else
            {
                if (RuiRo_BUS.UpdateRisk(ruiRo))
                {
                    MessageBox.Show("Updated risk");
                }
            }

            Risk_Form_Load(null, null);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string maRR = this.RiskCodeTxb.Text;
            if (maRR == "")
            {
                MessageBox.Show("Enter Risk Code");
                return;
            }

            if (RuiRo_BUS.DeleteRisk(maRR))
            {
                MessageBox.Show("Deleted");
                Risk_Form_Load(null, null);
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void RiskGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = RiskGrid.CurrentRow.Index;
            this.RiskCodeTxb.Text = RiskGrid.Rows[i].Cells[0].Value.ToString();
            this.RiskTypeTxb.Text = RiskGrid.Rows[i].Cells[1].Value.ToString();
            this.RiskCostTxb.Text = RiskGrid.Rows[i].Cells[2].Value.ToString();
        }
    }
}
