using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaudioService.Utils
{
    public class Utils
    {
        public string DownloadAudio(string _audioURL)
        {
            string _audioPath;
            using (var client = new WebClient())
            {
                _audioPath = _audioURL.Substring(47, 20) + ".mp3";
                client.DownloadFile(_audioURL, _audioPath);
            }
            return _audioPath;
        }
        public string ExtractTextFromPdf(string path)
        {
            using PdfReader reader = new(path);
            StringBuilder text = new();

            for (int i = 1; i <= reader.NumberOfPages; i++)
            {
                text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
            }

            return text.ToString();
        }
        public void PlayAudio(string _audioPath)
        {
            SoundPlayer soundPlayer = new();
            try
            {
                soundPlayer.SoundLocation = _audioPath;
                soundPlayer.PlaySync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
