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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        IMemberRepository memberRepository = new MemberRepository();

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
        private void loginButton_Click(object sender, EventArgs e)
        {
            String email = frmLoginEmail.Text;
            String password = frmLoginPassword.Text;
            if (email == "" || password == "")
            {
                MessageBox.Show("You haven't provide enough information", "Message", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    MemberObject adminAccount = CheckAdminAccount();
                    if (email.Equals(adminAccount.Username) && password.Equals(adminAccount.Password))
                    {
                        this.Hide();
                        Manager mainWindow = new Manager();
                        mainWindow.Show();
                        return;
                    }
                    else
                    {
                        MemberObject member = memberRepository.CheckLogin(email, password);
                        if (member.MemberId > 0)
                        {
                            this.Hide();
                            frmMemberInformation memberWindow = new frmMemberInformation
                            {
                                MemberInfor = member,
                                MemberRepository = memberRepository
                            };
                            memberWindow.Show();
                            return;
                        }
                    }
                    MessageBox.Show("Invalid email or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
