using System;
using System.Windows.Forms;

namespace BaudioWinApp
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBrowseFile.Text = openFileDialog1.FileName;
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf"; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == null || txtBookName.Text == "")
            {
                MessageBox.Show("BOOK NAME CANNOT BE NULL", "Error");
                return;
            }
        }
    }
}
