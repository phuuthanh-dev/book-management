using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    /// <summary>
    /// Class này dùng để CRUD table Category - Thể loại sách
    /// </summary>
    public class BookCategoryRepository
    {
        private BookManagement2024DbContext _context;
        public List<BookCategory> GetAll()
        {
            _context = new BookManagement2024DbContext();
            return _context.BookCategories.ToList();
        } 
    }
}
