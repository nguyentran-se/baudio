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
            try
            {
                MemberAudioHistoryObject result = GetHistoryByHistoryID(id);
                if (result != null)
                {
                    string SQLDelete = "Delete MemberAudioHistory where HistoryID = @HistoryID";
                    var param = dataProvider.CreateParameter("@HistoryID", 4, id, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("This History is not exist.");
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

        internal MemberAudioHistoryObject GetHistoryByHistoryID(int id)
        {
            MemberAudioHistoryObject memberAudioHistory = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select HistoryID, MemberId, BookName, AudioPath, AddedDate" +
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
                        //BookID = dataReader.GetInt32(2),
                        BookName = dataReader.GetString(2).Trim(),
                        AudioPath = dataReader.GetString(3).Trim(),
                        AddedDate = dataReader.GetDateTime(4)
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
            string SQLSelect = "Select HistoryID, MemberId, BookName, AudioPath, AddedDate from MemberAudioHistory";
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
                        //BookID = dataReader.GetInt32(2),
                        BookName = dataReader.GetString(2).Trim(),
                        AudioPath = dataReader.GetString(3).Trim(),
                        AddedDate = dataReader.GetDateTime(4)
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
            string SQLSelect = "Select HistoryID, MemberId, BookName, AudioPath, AddedDate" +
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
                        BookName = dataReader.GetString(2).Trim(),
                        AudioPath = dataReader.GetString(3).Trim(),
                        AddedDate = dataReader.GetDateTime(4)
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

        internal void AddNew(MemberAudioHistoryObject history)
        {
            try
            {
                string SQLInsert = "Insert MemberAudioHistory values(@MemberID, @BookName, @AudioPath, @AddedDate)";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@MemberID", 100, history.MemberId, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@BookName", 100, history.BookName, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@AudioPath", 100, history.AudioPath, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@AddedDate", 15, history.AddedDate, DbType.DateTime));
                dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
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

        internal void Update(MemberAudioHistoryObject history)
        {
            try
            {
                MemberAudioHistoryObject result = GetHistoryByHistoryID(history.HistoryID);
                if (result != null)
                {
                    string SQLUpdate = "Update MemberAudioHistory set BookName = @BookName" +
                                    " where HistoryID = @HistoryID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@BookName", 100, history.BookName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@HistoryID", 4, history.HistoryID, DbType.Int32));
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
