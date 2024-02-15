using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookManagementMemberService
    {
        public BookManagementMember? CheckLogin(string email, string password)
        {
            BookManagementMemberRepository repo = new BookManagementMemberRepository();
            BookManagementMember account = repo.Get(email);

            //if (account == null)
            //    return null; //email ko tồn tại
            //if (account.Password == password) 
            //    return account;
            //return null;

            return account != null && account.Password == password ? account : null;
        }
    }
}
