using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberAudioHistoryRepository : IMemberAudioHistoryRepository
    {
        public void DeleteHistory(int id) => MemberAudioHistoryDAO.Instance.Remove(id);

        public MemberAudioHistoryObject GetHistoryByHistoryID(int id) => MemberAudioHistoryDAO.Instance.GetHistoryByHistoryID(id);

        public IEnumerable<MemberAudioHistoryObject> GetHistoryList() => MemberAudioHistoryDAO.Instance.GetHistoryList();

        public IEnumerable<MemberAudioHistoryObject> GetHistoryListByUserID(int orderId) => MemberAudioHistoryDAO.Instance.GetHistoryListByUserID(orderId);

        public int InsertHistory(MemberAudioHistoryObject order) => MemberAudioHistoryDAO.Instance.AddNew(order);

        public void UpdateHistory(MemberAudioHistoryObject order) => MemberAudioHistoryDAO.Instance.Update(order);
    }
}
