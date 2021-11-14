using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberAudioHistoryRepository
    {
        public IEnumerable<MemberAudioHistoryObject> GetHistoryList();
        public IEnumerable<MemberAudioHistoryObject> GetHistoryListByUserID(int orderId);
        MemberAudioHistoryObject GetHistoryByHistoryID(int id);
        int InsertHistory(MemberAudioHistoryObject order);
        void DeleteHistory(int id);
        void UpdateHistory(MemberAudioHistoryObject order);
    }
}
