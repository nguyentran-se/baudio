using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace DataAccess.Repository
{
    public class MemberDAO : BaseDAL
    {
        // Nơi thêm xóa sửa member

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public MemberObject CheckLogin(string username, string pwd)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberId, Username,Password " +
                " from Member where Username = @Username and Password = @Password";
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@Username", 100, username, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Password", 30, pwd, DbType.String));
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Username = dataReader.GetString(1).Trim(),
                        Password = dataReader.GetString(2).Trim()
                    };
                }
                else
                {
                    throw new Exception("Email or password is invalid");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                CloseConnection();
            }
            return member;
        }

        public MemberObject GetMemberByID(int memberId)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberId,Username ,Password " +
                " from Member where MemberId = @MemberId";
            try
            {
                var param = dataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Username = dataReader.GetString(1).Trim(),
                        Password = dataReader.GetString(2).Trim()
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }

        public MemberObject GetMemberByUsername(string username)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberId, Username, Password " +
                " from Member where Username = @Username";
            try
            {
                var param = dataProvider.CreateParameter("@Username", 100, username, DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Username = dataReader.GetString(1).Trim(),
                        Password = dataReader.GetString(2).Trim()
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }

        public void AddNew(MemberObject member)
        {
            try
            {
                MemberObject result = GetMemberByUsername(member.Username);
                if (result == null)
                {
                    string SQLInsert = "Insert Member values(@Username, @Password)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@Username", 100, member.Username, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 30, member.Password, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("This member is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(MemberObject member)
        {
            try
            {
                MemberObject result = GetMemberByID(member.MemberId);
                if (result != null)
                {
                    bool check = false;
                    foreach (MemberObject temp in GetMemberList())
                    {
                        if (temp.MemberId != result.MemberId)
                        {
                            if (temp.Username.Trim().Equals(member.Username.Trim()))
                            {
                                check = true;
                            }
                        }
                    }
                    if (check == false)
                    {
                        string SQLUpdate = "Update Member set Username = @Username, " +
                                        " Password = @Password where MemberId = @MemberId";
                        var parameters = new List<SqlParameter>();
                        parameters.Add(dataProvider.CreateParameter("@Username", 100, member.Username, DbType.String));
                        parameters.Add(dataProvider.CreateParameter("@Password", 30, member.Password, DbType.String));
                        parameters.Add(dataProvider.CreateParameter("@MemberId", 4, member.MemberId, DbType.Int32));
                        dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                    }
                    else
                    {
                        throw new Exception("Username already exists.");
                    }

                }
                else
                {
                    throw new Exception("Member does not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int memberId)
        {
            try
            {
                MemberObject result = GetMemberByID(memberId);
                if (result != null)
                {
                    string SQLDelete = "Delete Member where MemberId = @MemberId";
                    var param = dataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("This member is not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public IEnumerable<MemberObject> GetMembersByUsername(string username)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberId, Username, Password " +
                " from Member where Username LIKE @Username";
            var members = new List<MemberObject>();
            try
            {
                var param = dataProvider.CreateParameter("@Username", 100, "%" + username + "%", DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    members.Add(new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Username = dataReader.GetString(1).Trim(),
                        Password = dataReader.GetString(2).Trim()
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }

        public IEnumerable<MemberObject> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberId, Username, Password from Member";
            var members = new List<MemberObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    members.Add(new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Username = dataReader.GetString(1).Trim(),
                        Password = dataReader.GetString(2).Trim()
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }
    }
}