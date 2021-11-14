using System;
using System.Windows.Forms;

namespace BaudioWinApp
{
    public partial class Listen : Form
    {
        public Listen()
        {
            InitializeComponent();
        }

        public string bookName;
        public string audioPath;
        public string addedDate;

        private void Listen_Load(object sender, EventArgs e)
        {
            txtBookName.Text = bookName;
            txtAudioPath.Text = audioPath;
            txtAddedDate.Text = addedDate;
        }
    }
}
