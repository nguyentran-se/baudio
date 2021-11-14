using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IBookRepository
    {
        public IEnumerable<BookObject> getBooks();
        BookObject GetBookByID(int bookID);
        void InsertBook(BookObject book);
        void DeleteBook(int bookID);
        void UpdateBook(BookObject book);
    }
}
