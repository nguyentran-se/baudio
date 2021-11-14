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
    public class BookDAO : BaseDAL
    {
        //Them Xoa Sua Book o day

        private static BookDAO instance = null;
        private static readonly object instanceLock = new object();

        private BookDAO() { }
        public static BookDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookDAO();
                    }
                    return instance;
                }
            }
        }

        public BookObject GetBookByID(int bookID)
        {
            BookObject book = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select BookID, BookName, AudioPath, AddedDate" +
                " from Book where BookID = @bookID";
            try
            {
                var param = dataProvider.CreateParameter("@bookID", 4, bookID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    book = new BookObject
                    {
                        BookID = dataReader.GetInt32(0),
                        BookName = dataReader.GetString(1).Trim(),
                        AudioPath = dataReader.GetString(2).Trim(),
                        AddedDate = dataReader.GetDateTime(3)
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
            return book;
        }

        public void AddNew(BookObject book)
        {
            try
            {
                string SQLInsert = "Insert Book values(@BookName, @AudioPath, @AddedDate)";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@BookName", 100, book.BookName, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@AudioPath", 40, book.AudioPath, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@AddedDate", 15, book.AddedDate, DbType.DateTime));
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
        public void Remove(int bookId)
        {
            try
            {
                BookObject result = GetBookByID(bookId);
                if (result != null)
                {
                    string SQLDelete = "Delete Book where BookID = @bookId";
                    var param = dataProvider.CreateParameter("@bookId", 4, bookId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("This Book is not exist.");
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

        public void Update(BookObject book)
        {
            try
            {
                BookObject result = GetBookByID(book.BookID);
                if (result != null)
                {
                    string SQLUpdate = "Update Book set BookName = @BookName where BookID = @bookID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@BookName", 4, book.BookName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@bookID", 4, book.BookID, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("This Book is not already exist.");
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


        public IEnumerable<BookObject> GetBookList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select BookID, BookName, AudioPath, AddedDate";
            var books = new List<BookObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    books.Add(new BookObject
                    {
                        BookID = dataReader.GetInt32(0),
                        BookName = dataReader.GetString(1).Trim(),
                        AudioPath = dataReader.GetString(2).Trim(),
                        AddedDate = dataReader.GetDateTime(3)
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
            return books;
        }
    }
}
