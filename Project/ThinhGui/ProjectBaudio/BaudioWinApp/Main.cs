using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaudioWinApp
{
    public partial class Main : Form
    {
        IMemberAudioHistoryRepository memberAudioHistoryRepository = new MemberAudioHistoryRepository();
        public MemberObject MemberInfor { get; set; }
        BindingSource orderSource;
        public Main()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            IEnumerable<MemberAudioHistoryObject> Histories = memberAudioHistoryRepository.GetHistoryListByUserID(MemberInfor.MemberId);
            LoadHistoryListByID(Histories);
            
            if (dgvBookList.Rows.Count != 0)
            {
                lbIsEmpty.Visible = false;
            }
            else
            {
                lbIsEmpty.Visible = true;
            }
        }

        private void LoadHistoryListByID(IEnumerable<MemberAudioHistoryObject> Histories)
        {
            try
            {
                orderSource = new BindingSource();
                orderSource.DataSource = Histories;

                //txtId.DataBindings.Clear();
                //txtCompany.DataBindings.Clear();
                //txtEmail.DataBindings.Clear();
                //txtPassword.DataBindings.Clear();
                //txtCity.DataBindings.Clear();
                //txtCountry.DataBindings.Clear();

                //txtId.DataBindings.Add("Text", source, "MemberID");
                //txtCompany.DataBindings.Add("Text", source, "CompanyName");
                //txtEmail.DataBindings.Add("Text", source, "Email");
                //txtPassword.DataBindings.Add("Text", source, "Password");
                //txtCity.DataBindings.Add("Text", source, "City");
                //txtCountry.DataBindings.Add("Text", source, "Country");

                dgvBookList.DataSource = null;
                dgvBookList.DataSource = Histories;
                //ClearSearchBox();
                //if (members.Count() == 0)
                //{
                //    ClearText();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load History List");
            }
        }

        private void dgvBookList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null) return;

            InfoBook infoBook = new InfoBook();

            infoBook.bookName = dgvBookList.CurrentRow.Cells[0].Value.ToString();
            infoBook.audioPath = dgvBookList.CurrentRow.Cells[1].Value.ToString();
            infoBook.addedDate = dgvBookList.CurrentRow.Cells[2].Value.ToString();

            infoBook.Show();
        }

    }
}
