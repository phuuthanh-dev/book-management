using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_HoangNT
{
    public partial class BookForm : Form
    {
        //dùng 1 biến Book hoặc int id để lưu trạng thái form
        //nếu biến này == null thì Form tạo mới
        //nếu biến này != null tức là id = ?? nào đó thì ta Get() từ DB
        public int? BookId { get; set; }
        private BookService _bookService = new();  //bỏ tên class
        private BookCategoryService _categoryService = new BookCategoryService();
        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            //đổ toàn bộ Category vào Dropdown
            cboCategory.DataSource = _categoryService.GetAllCategories();
            // chỉ show Name của Category
            cboCategory.DisplayMember = "BookGenreType"; //chọn 1 dòng xổ ra
            cboCategory.ValueMember = "BookCategoryId";
            //lấy CategoryId

            if (this.BookId != null)
            {
                //edit mode
                var book = _bookService.GetABook((int) BookId);

                txtId.Text = book.BookId.ToString();
                txtName.Text = book.BookName;
                txtDescription.Text = book.Description;
                dtpReleasedDate.Value = book.ReleaseDate;
                txtQuantity.Text = book.Quantity.ToString();
                txtPrice.Text = book.Price.ToString();
                txtAuthor.Text = book.Author;
                cboCategory.SelectedValue = book.BookCategoryId;
                lblFormTitle.Text = "Update a Book";
            }
        }
    }
}
