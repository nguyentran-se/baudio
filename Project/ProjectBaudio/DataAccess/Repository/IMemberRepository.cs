using BusinessObject;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public IEnumerable<MemberObject> GetMembers();
        MemberObject GetMemberByID(int memberId);
        void InsertMember(MemberObject mem);
        void DeleteMember(int memberId);
        void UpdateMember(MemberObject mem);
        public IEnumerable<MemberObject> GetMembersByUsername(string username);
        public MemberObject GetMemberByUsername(string username);
        public MemberObject CheckLogin(string username, string pwd);
    }
}
