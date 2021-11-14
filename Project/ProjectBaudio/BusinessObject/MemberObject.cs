using System;

namespace BusinessObject
{
    public class MemberObject
    {
        public int MemberId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public MemberObject()
        {
        }

        public MemberObject(int memberId, string username, string password)
        {
            MemberId = memberId;
            Username = username;
            Password = password;
        }
    }
}
