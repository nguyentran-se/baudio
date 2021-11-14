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
    public partial class ManagerHistory : Form
    {
        public ManagerHistory()
        {
            InitializeComponent();
        }
        IMemberAudioHistoryRepository memberAudioHistoryRepository = new MemberAudioHistoryRepository();
        BindingSource memberSource;

        private void LoadAllHistory(IEnumerable<MemberAudioHistoryObject> histories)
        {
            try
            {
                memberSource = new BindingSource();
                memberSource.DataSource = histories;

                txtHistoryId.DataBindings.Clear();
                txtUseID.DataBindings.Clear();
                txtBookname.DataBindings.Clear();
                txtAudioPath.DataBindings.Clear();
                txtAddedDate.DataBindings.Clear();

                txtHistoryId.DataBindings.Add("Text", memberSource, "HistoryID");
                txtUseID.DataBindings.Add("Text", memberSource, "MemberId");
                txtBookname.DataBindings.Add("Text", memberSource, "BookName");
                txtAudioPath.DataBindings.Add("Text", memberSource, "AudioPath");
                txtAddedDate.DataBindings.Add("Text", memberSource, "AddedDate");

                dgvHistoryList.DataSource = null;
                dgvHistoryList.DataSource = memberSource;
                if (histories.Count() > 0)
                {
                    btnRemove.Enabled = true;
                    btnUpdate.Enabled = true;

                }
                else if (histories.Count() == 1)
                {
                    btnRemove.Enabled = false;
                }
                else
                {
                    ClearText();
                    btnUpdate.Enabled = false;
                    btnRemove.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load History List");
            }
        }
        private void ClearText()
        {
            txtUseID.Text = string.Empty;
            txtHistoryId.Text = string.Empty;
            txtBookname.Text = string.Empty;
            txtAudioPath.Text = string.Empty;
            txtAddedDate.Text = string.Empty;
        }
        private void ManagerHistory_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAllHistory(memberAudioHistoryRepository.GetHistoryList());
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            List<MemberAudioHistoryObject> result = memberAudioHistoryRepository.GetHistoryList().OrderBy(mem => mem.HistoryID).ToList<MemberAudioHistoryObject>();
            result.Reverse();
            LoadAllHistory(result);
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            List<MemberAudioHistoryObject> result = memberAudioHistoryRepository.GetHistoryList().OrderBy(mem => mem.HistoryID).ToList<MemberAudioHistoryObject>();
            LoadAllHistory(result);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var historyDetail = new HistoryDetail()
            {
                InsertOrUpdate = false,
                memberAudioHistoryRepository = this.memberAudioHistoryRepository
            };
            historyDetail.Show();
            LoadAllHistory(memberAudioHistoryRepository.GetHistoryList());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var historyDetail = new HistoryDetail()
            {
                InsertOrUpdate = true,
                memberAudioHistoryRepository = this.memberAudioHistoryRepository,
                MemberInfor = memberAudioHistoryRepository.GetHistoryByHistoryID(Int32.Parse(txtHistoryId.Text))
            };
            historyDetail.Show();
        }
        //private MemberAudioHistoryObject GetHistoryObject()
        //{
        //    MemberAudioHistoryObject history = null;
        //    try
        //    {
        //        history = new MemberAudioHistoryObject
        //        {
        //            HistoryID = int.Parse(txtHistoryId.Text),
        //            MemberId = int.Parse(txtUseID.Text),
        //            BookName = txtBookname.Text,
        //            AudioPath = txtAudioPath.Text
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Get Member Error");
        //    }
        //    return history;
        //}

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.TryParse(txtHistoryId.Text,out int a))
                {
                    memberAudioHistoryRepository.DeleteHistory(Int32.Parse(txtHistoryId.Text));
                    LoadAllHistory(memberAudioHistoryRepository.GetHistoryList());
                }
                else
                {
                    MessageBox.Show("Please choice a row to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a Member");
            }
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
    }
}
