using Repositories;
using Repositories.Entities;

namespace Services
{
    /// <summary>
    /// Class này chứa các hàm cung cấp và tương tác với GUI FORMS
    /// Nó sau đó sẽ giao tiếp với Repo tương ứng để tương tác gián tiếp
    /// với CSDL
    /// Các tên hàm gần gũi với con người hơn
    /// </summary>
    public class BookService
    {
        //cần repo để CRUD xuống DB
        
        /// <summary>
        /// Hàm lấy tất cả sách từ DB và cung cấp cho Form
        /// </summary>
        private BookRepository _repo = new BookRepository();
        public List<Book> GetAllBooks()
        {
            return _repo.GetAll();
        }

        /// <summary>
        /// Hàm này search cuốn sách theo tiêu chí name và description
        /// Search theo kiểu contains
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<Book> SearchBooks(string keyword) 
        {
            List<Book> result = _repo.GetAll().Where(x => x.BookName.ToLower().Contains(keyword.ToLower()) 
                                                      || x.Description.ToLower().Contains(keyword.ToLower())
                                                     ).ToList();
            return result;
        }

        /// <summary>
        /// Hàm này xóa 1 cuốn sách theo mã số - int
        /// </summary>
        /// <param name="id"></param>
        public void DeleteABook(int id)
        {
            _repo.Delete(id);  
        }
    }
}
