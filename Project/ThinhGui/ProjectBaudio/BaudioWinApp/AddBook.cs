using BusinessObject;
using DataAccess.Repository;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Text;
using System.Windows.Forms;
using BaudioService;
using BaudioService.Apis;
using BaudioService.Model;
using BaudioService.Utils;

namespace BaudioWinApp
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        public MemberObject MemberInfor { get; set; }
        private BookRepository bookRepository = new BookRepository();
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
        //private string ExtractTextFromPdf(string path)
        //{
        //    using PdfReader reader = new(path);
        //    StringBuilder text = new();

        //    for (int i = 1; i <= reader.NumberOfPages; i++)
        //    {
        //        text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
        //    }

        //    return text.ToString();
        //}
        private Apis api = new Apis();
        private Utils utils = new Utils();
        private MemberAudioHistoryRepository audioHistory = new MemberAudioHistoryRepository();
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == null || txtBookName.Text == "")
            {
                MessageBox.Show("BOOK NAME CANNOT BE EMPTY", "Error");
                return;
            }
            string path = txtBrowseFile.Text;
            var content = utils.ExtractTextFromPdf(path);
            //var content = textBox1.Text.Substring(0, 15);
            var response = await api.GetAudioFromText(content);
            var audioURL = response.data.url;
            string audioPath = utils.DownloadAudio(audioURL);

            //BookObject book = new BookObject
            //{
            //    BookName = txtBookName.Text,
            //    AddedDate = DateTime.Now,
            //    AudioPath = audioPath
            //};

            MemberAudioHistoryObject memberAudioHistoryObject = new MemberAudioHistoryObject
            {
                MemberId = MemberInfor.MemberId,
                BookName = txtBookName.Text,
                AddedDate = DateTime.Now,
                AudioPath = audioPath,
            };

            //txtBrowseFile.Text = audioPath;
            //txtPdfUrl.Text = audioURL;
            //bookRepository.InsertBook(book);
            audioHistory.InsertHistory(memberAudioHistoryObject);

        }
    }
}
