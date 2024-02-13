using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookManagementMemberRepository
    {
        //Các hàm CRUD của table Member
        public BookManagementMember? Get(string email) 
        {
            BookManagement2024DbContext db = new BookManagement2024DbContext();
            //db đang chứa 3 table, list các data sẵn
            return db.BookManagementMembers.FirstOrDefault(x => x.Email == email);
        }
    }
}
