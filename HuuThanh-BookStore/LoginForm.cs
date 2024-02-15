using Microsoft.Extensions.Configuration;
using Repositories.Entities;
using Services;
using System.Configuration;

namespace BookStore_HoangNT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;  //TO DO: kiểm tra rỗng
            string password = txtPassword.Text; //TO DO: kiểm tra rỗng
            BookManagementMemberService service = new BookManagementMemberService();
            BookManagementMember account = service.CheckLogin(email, password);
            if (account == null)
            {
                MessageBox.Show("Login failed. Please check your credentials", 
                    "Wrong credentials", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                return;
            }
            //cho vào form quản lí sách
            if (account.MemberRole != 1)
            {
                MessageBox.Show("You are not allowed to access this function!",
                    "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // role admin
            BookManagerForm bookMgt = new BookManagerForm();
            bookMgt.Show();
            this.Hide();
        }

        
    }
}   