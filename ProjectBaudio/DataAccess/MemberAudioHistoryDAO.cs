using BusinessObject;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class MemberAudioHistoryDAO : BaseDAL
    {
        private static MemberAudioHistoryDAO instance = null;
        private static readonly object instanceLock = new object();

        internal void Remove(int id)
        {
            throw new NotImplementedException();
        }

        internal MemberAudioHistoryObject GetHistoryByHistoryID(int id)
        {
            MemberAudioHistoryObject memberAudioHistory = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select HistoryID, MemberId, BookID, BookName, AudioPath, AddedDate" +
                " from MemberAudioHistory where HistoryID = @historyID";
            try
            {
                var param = dataProvider.CreateParameter("@historyID", 4, id, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    memberAudioHistory = new MemberAudioHistoryObject
                    {
                        HistoryID = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        BookID = dataReader.GetInt32(2),
                        BookName = dataReader.GetString(3).Trim(),
                        AudioPath = dataReader.GetString(4).Trim(),
                        AddedDate = dataReader.GetDateTime(5)
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
            return memberAudioHistory;
        }

        internal IEnumerable<MemberAudioHistoryObject> GetHistoryList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select HistoryID, MemberId, BookID, BookName, AudioPath, AddedDate";
            var list = new List<MemberAudioHistoryObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    list.Add(new MemberAudioHistoryObject
                    {
                        HistoryID = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        BookID = dataReader.GetInt32(2),
                        BookName = dataReader.GetString(3).Trim(),
                        AudioPath = dataReader.GetString(4).Trim(),
                        AddedDate = dataReader.GetDateTime(5)
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
            return list;
        }

        internal IEnumerable<MemberAudioHistoryObject> GetHistoryListByUserID(object id)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select HistoryID, MemberId, BookID, BookName, AudioPath, AddedDate"+
                                " from MemberAudioHistory where MemberId = @MemberId";
            var list = new List<MemberAudioHistoryObject>();
            try
            {
                var param = dataProvider.CreateParameter("@MemberId", 4, id, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    list.Add(new MemberAudioHistoryObject
                    {
                        HistoryID = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        BookID = dataReader.GetInt32(2),
                        BookName = dataReader.GetString(3).Trim(),
                        AudioPath = dataReader.GetString(4).Trim(),
                        AddedDate = dataReader.GetDateTime(5)
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
            return list;
        }

        internal int AddNew(MemberAudioHistoryObject order)
        {
            throw new NotImplementedException();
        }

        internal void Update(MemberAudioHistoryObject history)
        {
            try
            {
                MemberAudioHistoryObject result = GetHistoryByHistoryID(history.HistoryID);
                if (result != null)
                {
                    string SQLUpdate = "Update MemberAudioHistory BookName = @BookName" +
                                    "where HistoryID = @HistoryID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@BookName", 100, history.BookName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, history.HistoryID, DbType.Int32));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
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

        private MemberAudioHistoryDAO() { }
        public static MemberAudioHistoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberAudioHistoryDAO();
                    }
                    return instance;
                }
            }
        }
    }
}
