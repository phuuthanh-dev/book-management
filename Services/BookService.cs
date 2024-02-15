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
    }
}
