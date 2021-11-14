using BusinessObject;
using System.Collections.Generic;


namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public IEnumerable<MemberObject> GetMembersByUsername(string username) => MemberDAO.Instance.GetMembersByUsername(username);
        public MemberObject GetMemberByUsername(string username) => MemberDAO.Instance.GetMemberByUsername(username);
        public MemberObject CheckLogin(string username, string pwd) => MemberDAO.Instance.CheckLogin(username, pwd);
        public MemberObject GetMemberByID(int id) => MemberDAO.Instance.GetMemberByID(id);
        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList();
        public void InsertMember(MemberObject mem) => MemberDAO.Instance.AddNew(mem);
        public void UpdateMember(MemberObject mem) => MemberDAO.Instance.Update(mem);
        public void DeleteMember(int id) => MemberDAO.Instance.Remove(id);
    }
}
