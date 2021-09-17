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
    public partial class Room_Manage : Form
    {
        public Room_Manage()
        {
            InitializeComponent();
        }

        private void PickRoomBtn_Click(object sender, EventArgs e)
        {
            Customer_Information inf = new Customer_Information();
            inf.ShowDialog();
        }

        private void DeleteRoomBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddTypeRoomBtn_Click(object sender, EventArgs e)
        {

        }

        private void AcceptRQBtn_Click(object sender, EventArgs e)
        {

        }

        private void PendingRQBtn_Click(object sender, EventArgs e)
        {

        }

        private void CancelRQBtn_Click(object sender, EventArgs e)
        {

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
