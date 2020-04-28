using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IUserDao
    {
        string GetAllUsers();
        bool AddUser(User user);
        bool DeleteUser(int id);
        bool UpdateUser(User user);
    }
}
