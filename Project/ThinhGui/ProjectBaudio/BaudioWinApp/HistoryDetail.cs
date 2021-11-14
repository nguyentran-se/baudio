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
    public partial class HistoryDetail : Form
    {
        public HistoryDetail()
        {
            InitializeComponent();
        }
        public IMemberAudioHistoryRepository memberAudioHistoryRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberAudioHistoryObject MemberInfor { get; set; }
        private Boolean MyValidate()
        {
            Boolean isValid = true;
            String message = "";
            if (String.IsNullOrEmpty(txtBookname.Text.Trim()))
            {
                message += "Your Book Name is invalid\n";
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
                //try
                //{
                    var history = new MemberAudioHistoryObject()
                    {
                        BookName = txtBookname.Text,
                        AudioPath = txtAudioPath.Text
                    };
                    if (InsertOrUpdate)
                    {
                        history.MemberId = int.Parse(txtUseID.Text);
                        history.HistoryID = int.Parse(txtHistoryId.Text);
                        memberAudioHistoryRepository.UpdateHistory(history);
                        MessageBox.Show("Updated successfully, press load to refresh data", "Message", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        memberAudioHistoryRepository.InsertHistory(history);
                        MessageBox.Show("Insert successfully, press load to refresh data", "Message", MessageBoxButtons.OK);
                        Close();
                    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }

        private void HistoryDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                txtHistoryId.Text = MemberInfor.HistoryID.ToString();
                txtUseID.Text = MemberInfor.MemberId.ToString();
                txtBookname.Text = MemberInfor.BookName;
                txtAudioPath.Text = MemberInfor.AudioPath;
                txtBookname.Enabled = true;
                lbAction.Text = "Update History";
                btnAction.Text = "Update";
            }
            else
            {
                lbAction.Text = "Add New History";
                btnAction.Text = "Add";
            }
            txtHistoryId.Enabled = false;
        }
    }
}
