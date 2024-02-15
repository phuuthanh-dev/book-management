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
    public partial class BookManagerForm : Form
    {
        private BookService _bookService = new BookService();
        private BookCategoryService _categoryService = new BookCategoryService();
        public BookManagerForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BookManagerForm_Load(object sender, EventArgs e)
        {
            var result = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
            //giấu cột CategoryId, nó đang chứa 1 dòng của table Category
            dgvBookList.Columns["BookCategory"].Visible = false;

            //đổ toàn bộ Category vào Dropdown
            cboCategory.DataSource = _categoryService.GetAllCategories();
            // chỉ show Name của Category
            cboCategory.DisplayMember = "BookGenreType"; //chọn 1 dòng xổ ra
            cboCategory.ValueMember = "BookCategoryId";
            //lấy CategoryId
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var selectedBook = (Book) dgvBookList.SelectedRows[0].DataBoundItem;
                //có đc 1 cuốn sách đc lựa chọn
                txtId.Text = selectedBook.BookId.ToString();
                txtName.Text = selectedBook.BookName;
                txtDescription.Text = selectedBook.Description;
                dtpReleasedDate.Value = selectedBook.ReleaseDate;
                txtQuantity.Text = selectedBook.Quantity.ToString();
                txtPrice.Text = selectedBook.Price.ToString();
                txtAuthor.Text = selectedBook.Author;
                cboCategory.SelectedValue = selectedBook.BookCategoryId;
            }
        }
    }
}
