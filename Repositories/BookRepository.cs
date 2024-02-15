using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    /// <summary>
    /// Đây là class tương tác trực tiếp với CSDL, table Book, tức là nó sẽ xài class Book đc generate bởi scaffold
    /// Các hàm sẽ là CRUD 1 cuốn sách 1 instance of Book Class
    /// Để tt được CSDL ta phải gọi class BookManagement2024DBContext
    /// </summary>
    public class BookRepository
    {
        /// <summary>
        /// Hàm nhận vào mã sách là số nguyên và trả về 1 cuốn duy nhất
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        private BookManagement2024DbContext _context;
        public Book? Get(int bookId)
        {
            _context = new BookManagement2024DbContext();
            return _context.Books.Find(bookId);
        }

        /// <summary>
        /// Hàm này trả về tất cả cuốn sách có trong table Book
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAll()
        {
            _context = new BookManagement2024DbContext();
            //return _context.Books.ToList();
            //Chỉ Load thông tin table book, ko load table category
            //Làm sao load đc info category để còn lấy tên category

            // CÂU JOIN BẮT ĐẦU
            return _context.Books.Include(cat => cat.BookCategory).ToList();
            //inner join sang table BookCategory
            //Qua đặc tính, thuộc tính Category ở Book
        }

        /// <summary>
        /// Tạo mới 1 cuốn sách và insert vào table book ở CSDL
        /// Đầu vào cần là new Book(...) mới tinh nào đó
        /// </summary>
        /// <param name="book"></param>
        public void Create(Book book) 
        {
            _context = new BookManagement2024DbContext();
            _context.Books.Add(book);  //INSERT INTO Book Values()
            _context.SaveChanges();
        }
        /// <summary>
        /// Cập nhập 1 cuốn sách đang có, với thông tin bên trong cuốn sách đc điều chỉnh
        /// là mới
        /// </summary>
        /// <param name="book"></param>
        public void Update(Book book) 
        {
            _context = new BookManagement2024DbContext();
            _context.Books.Update(book);
            _context.SaveChanges();
        }
        /// <summary>
        /// Hàm này xóa 1 cuốn cách theo id
        /// </summary>
        /// <param name="book"></param>
        public void Delete(int id) 
        {
            _context = new BookManagement2024DbContext();
            var book = _context.Books.FirstOrDefault(x => x.BookId == id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        //public List<Book> Search(string keyword) { }
        // nên để ở tầng Service do nhu cầu search khác nhau
        // tầng Repo chỉ nên làm những hàm cơ bản CRUD
    }
}
