using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BookRepository : IBookRepository
    {
        public void DeleteBook(int bookID) => BookDAO.Instance.Remove(bookID);

        public BookObject GetBookByID(int bookID) => BookDAO.Instance.GetBookByID(bookID);

        public IEnumerable<BookObject> getBooks() => BookDAO.Instance.GetBookList();

        public void InsertBook(BookObject book) => BookDAO.Instance.AddNew(book);

        public void UpdateBook(BookObject book) => BookDAO.Instance.Update(book);
    }
}
