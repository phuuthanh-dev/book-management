using Microsoft.IdentityModel.Tokens;
using Repositories.Entities;
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
                var book = _bookService.GetABook((int)BookId);

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO: BẮT VALIDATION, IF CÁC Ô NHẬP THỎA HAY KO, KO THÌ CHỬI
            //      BẰNG MASSAGEBOX.SHOW()
            if (txtId.Text.IsNullOrEmpty() || txtName.Text.IsNullOrEmpty() || txtDescription.Text.IsNullOrEmpty() 
                || txtAuthor.Text.IsNullOrEmpty()|| txtQuantity.Text.IsNullOrEmpty() || txtPrice.Text.IsNullOrEmpty()
                || txtAuthor.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please fill in all fields completely!!",
                    "Input required!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Book book = new()
            {
                BookId = int.Parse(txtId.Text.Trim()),
                BookName = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                ReleaseDate = dtpReleasedDate.Value.Date,  //ko lấy giờ
                Author = txtAuthor.Text.Trim(),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                Price = double.Parse(txtPrice.Text.Trim()),
                BookCategoryId = int.Parse(cboCategory.SelectedValue.ToString())
            };

            if (BookId != null ) //mode update
            {
                _bookService.UpdateABook(book);
            } else
            {
                _bookService.AddABook(book);
            }
            Close(); //đóng form sau khi save xong
        }
    }
}
