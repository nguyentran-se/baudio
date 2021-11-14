using System;
using System.Windows.Forms;

namespace BaudioWinApp
{
    public partial class Main : Form
    {
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
            dgvBookList.Rows.Add("abc", "def", "21-01-2021");
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
