using BusinessObject;
using DataAccess.Repository;
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
    public partial class frmMembers : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource memberSource;
        public frmMembers()
        {
            InitializeComponent();
        }

        private void LoadAllMember(IEnumerable<MemberObject> members)
        {
            try
            {
                memberSource = new BindingSource();
                memberSource.DataSource = members;

                txtId.DataBindings.Clear();
                txtUsername.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtId.DataBindings.Add("Text", memberSource, "MemberID");
                txtUsername.DataBindings.Add("Text", memberSource, "Username");
                txtPassword.DataBindings.Add("Text", memberSource, "Password");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = memberSource;
                //ClearSearchBox();
                //if (members.Count() == 0)
                //{
                //    ClearText();
                //}
                if (members.Count() == 0)
                {
                    ClearText();
                    btnUpdate.Enabled = false;
                    btnRemove.Enabled = false;
                }
                else if (members.Count() == 1)
                {
                    btnRemove.Enabled = false;
                }
                else
                {
                    btnRemove.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load History List");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAllMember(memberRepository.GetMembers());
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            //LoadAllMember(memberRepository.GetMembers());
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new Manager();
            main.Show();
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            List<MemberObject> result = memberRepository.GetMembers().OrderBy(mem => mem.MemberId).ToList<MemberObject>();
            result.Reverse();
            LoadAllMember(result);
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            List<MemberObject> result = memberRepository.GetMembers().OrderBy(mem => mem.MemberId).ToList<MemberObject>();
            LoadAllMember(result);
        }

        private void ClearText()
        {
            txtId.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void ClearSearchBox()
        {
            txtSearchUsername.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmMemberDetail = new frmMemberDetail()
            {
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            frmMemberDetail.Show();
            LoadAllMember(memberRepository.GetMembers());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var frmMemberDetail = new frmMemberDetail()
            {
                InsertOrUpdate = true,
                MemberRepository = memberRepository,
                MemberInfor = GetMemberObject(),
            };
            frmMemberDetail.Show();
        }
        private MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject
                {
                    MemberId = int.Parse(txtId.Text),
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member Error");
            }
            return member;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberId);
                LoadAllMember(memberRepository.GetMembers());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a Member");
            }
        }
    }
}
