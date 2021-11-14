using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class BookObject
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string AudioPath { get; set; }
        public DateTime AddedDate { get; set; }

        public BookObject()
        {

        }
        public BookObject(int bookID, string bookName, string audioPath, DateTime addedDate)
        {
            BookID = bookID;
            BookName = bookName;
            AudioPath = audioPath;
            AddedDate = addedDate;
        }
    }
}
