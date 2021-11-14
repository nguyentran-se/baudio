using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaudioWinApp
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMembers memberManage = new frmMembers();
            memberManage.Show();
            return;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHistory managerHistory = new ManagerHistory();
            managerHistory.Show();
            return;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
            return;
        }
    }
}
