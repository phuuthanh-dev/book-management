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
        private BookService _service = new BookService();
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
            var result = _service.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
            //giấu cột CategoryId, nó đang chứa 1 dòng của table Category
            dgvBookList.Columns["BookCategory"].Visible = false;
        }
    }
}
