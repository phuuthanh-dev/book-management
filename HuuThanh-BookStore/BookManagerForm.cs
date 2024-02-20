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
                var selectedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                MessageBox.Show("The search keyword is required!",
                    "Search keyword required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = _bookService.SearchBooks(txtKeyword.Text.Trim());

            //TODO: THÔNG BÁO NẾU KẾT QUẢ SEARCH KO CÓ
            if (result.IsNullOrEmpty())
            {
                MessageBox.Show("There are no books matching the search keyword!!!",
                    "Can't found!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
            dgvBookList.Columns["BookCategory"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //mã sách là con số int
            //Convert.ToInt32(chữ về số) Integer.Parse()
            //int.Parse(chữ về số)
            //Int32.Parse(chữ về số)
            //ném ra ngoài ngoại lệ nếu convert ko đc
            //int.TryParse(txtId.Text, out int id);
            int id;
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out id))
            //trả true || flase và cả id khai báo ngoài
            {
                MessageBox.Show("The Book ID is invalid. Please input a number!!!",
                    "Invalid Book ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //TODO: ĐÃ XÓA RỒI, MÀ XÓA LẠI, HOẶC GÕ ID ĐÃ XÓA, CHỬI KO TỒN TẠI
            //HINT: Get(id) của class Repo
            if (_bookService.GetABook(id) == null)
            {
                MessageBox.Show("Book ID does not exist!!!",
                    "Book ID not exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _bookService.DeleteABook(id);

            var result = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
            dgvBookList.Columns["BookCategory"].Visible = false;

            //TODO: XÓA THÀNH CÔNG THÌ XÓA TRẮNG CÁC Ô NHẬP
            txtId.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            dtpReleasedDate.Value = DateTime.Now;
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtAuthor.Text = "";
            cboCategory.SelectedValue = 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("The Book ID is invalid. Please select a row in the grid to edit or input the number!!!",
                    "Invalid Book ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //TODO: PHẢI CHECK NẾU CUỐN SÁCH ĐÃ TỒN TẠI, GIỐNG NHƯ XÓA SÁCH
            //HINT: GETABOOK()
            if (_bookService.GetABook(id) != null)
            {
                //đã có id rồi
                BookForm bookForm = new BookForm();
                bookForm.BookId = int.Parse(txtId.Text);
                //bookForm.Show(); // tạo đc nhiều form, ko nên
                bookForm.ShowDialog();

                var result = _bookService.GetAllBooks();
                dgvBookList.DataSource = null;
                dgvBookList.DataSource = result;
                dgvBookList.Columns["BookCategory"].Visible = false;

                //TODO : xóa ô text
                txtId.Text = "";
                txtName.Text = "";
                txtDescription.Text = "";
                dtpReleasedDate.Value = DateTime.Now;
                txtQuantity.Text = "";
                txtPrice.Text = "";
                txtAuthor.Text = "";
                cboCategory.SelectedValue = 1;
            } else
            {
                MessageBox.Show("Book ID does not exist!!!",
                    "Book ID not exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.BookId = null;
            bookForm.ShowDialog();
            //NEW THÌ SHOW FORM TRỐNG
            //xong, đóng form thì refresh lưới
            var result = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
            dgvBookList.Columns["BookCategory"].Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var result = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
            dgvBookList.Columns["BookCategory"].Visible = false;
        }
    }
}
