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
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject MemberInfor { get; set; }


        private Boolean MyValidate()
        {
            Boolean isValid = true;
            String message = "";
            if (String.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                message += "Your Username is invalid\n";
                isValid = false;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                message += "Your Password is invalid\n";
                isValid = false;
            }
            MemberObject memberObject = CheckAdminAccount();
            if (txtUsername.Text.Equals(memberObject.Username))
            {
                message += "Cant use this Username\n";
                isValid = false;
            }
            if (!isValid)
            {
                MessageBox.Show(message, "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return isValid;
        }
        private void btnAction_Click(object sender, EventArgs e)
        {
            if (MyValidate())
            {
                try
                {
                    var member = new MemberObject()
                    {
                        Username = txtUsername.Text,
                        Password = txtPassword.Text
                    };
                    if (InsertOrUpdate)
                    {
                        member.MemberId = int.Parse(txtId.Text);
                        MemberRepository.UpdateMember(member);
                        MessageBox.Show("Updated successfully, press load to refresh data", "Message", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MemberRepository.InsertMember(member);
                        MessageBox.Show("Insert successfully, press load to refresh data", "Message", MessageBoxButtons.OK);
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                txtId.Text = MemberInfor.MemberId.ToString();
                txtUsername.Text = MemberInfor.Username;
                txtPassword.Text = MemberInfor.Password;
                lbAction.Text = "Update Member";
                btnAction.Text = "Update";
            }
            else
            {
                lbAction.Text = "Add New Member";
                btnAction.Text = "Add";
            }
            txtId.Enabled = false;
        }

    }
}
