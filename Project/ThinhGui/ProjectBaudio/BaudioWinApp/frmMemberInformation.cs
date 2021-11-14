using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaudioWinApp
{
    public partial class frmMemberInformation : Form
    {
        public frmMemberInformation()
        {
            InitializeComponent();
        }

        public IMemberRepository MemberRepository { get; set; }
        public MemberObject MemberInfor { get; set; }

        private void loadData()
        {
            txtId.Text = MemberInfor.MemberId.ToString();
            txtId.Enabled = false;
            txtUsername.Text = MemberInfor.Username;
            txtPassword.Text = MemberInfor.Password;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBookToAudio_Click(object sender, EventArgs e)
        {
            Main main1 = new Main()
            {
                MemberInfor = MemberInfor
            };
            main1.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "";
                Boolean isError = false;
                if (String.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    msg += "You can't leave your Username empty\n";
                    isError = true;
                }
                MemberObject memberObject = CheckAdminAccount();
                if (txtUsername.Text.Equals(memberObject.Username))
                {
                    msg += "Can not use this username\n";
                    isError = true;
                }
                if (isError)
                {
                    throw new Exception(msg);
                }
                this.MemberInfor.Username = txtUsername.Text;
                this.MemberInfor.Password = txtPassword.Text;
                MemberRepository.UpdateMember(MemberInfor);
                MessageBox.Show("Update Successfully");
                loadData();
                this.Update();
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private MemberObject CheckAdminAccount()
        {
            MemberObject admin = null;
            try
            {
                string currentDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
                string path = projectDirectory + "\\" + "appsettings.json";
                using (StreamReader sr = new StreamReader(path))
                {
                    string json = sr.ReadToEnd();
                    admin = JsonSerializer.Deserialize<MemberObject>(json);
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Check Admin Account: Error " + ex.Message);
            }
            return admin;
        }

        private void frmMemberInformation_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
