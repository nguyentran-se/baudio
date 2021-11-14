using System;
using System.Windows.Forms;

namespace BaudioWinApp
{
    public partial class InfoBook : Form
    {
        public InfoBook()
        {
            InitializeComponent();
        }

        public string bookName;
        public string audioPath;
        public string addedDate;

        private void InfoBook_Load(object sender, EventArgs e)
        {
            txtBookName.Text = bookName;
            txtAudioPath.Text = audioPath;
            txtAddedDate.Text = addedDate;
        }
    }
}
