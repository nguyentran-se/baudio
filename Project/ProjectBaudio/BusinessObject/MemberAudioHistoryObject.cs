using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class MemberAudioHistoryObject
    {
        public int HistoryID { get; set; }
        public int MemberId { get; set; }
        //public int BookID { get; set; }
        public string BookName { get; set; }
        public string AudioPath { get; set; }
        public DateTime AddedDate { get; set; }

        public MemberAudioHistoryObject()
        {
        }

        public MemberAudioHistoryObject(int historyID, int memberId, int bookID, string bookName, string audioPath, DateTime addedDate)
        {
            HistoryID = historyID;
            MemberId = memberId;
            //BookID = bookID;
            BookName = bookName;
            AudioPath = audioPath;
            AddedDate = addedDate;
        }
    }
}
