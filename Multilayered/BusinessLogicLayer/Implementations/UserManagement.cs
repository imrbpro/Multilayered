using BusinessLogicLayer.Interfaces;
using Models;
using System;
using DataAccessLayer.Implementations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogicLayer.Implementations
{
    public class UserManagement : IUserManagement
    {
        UserDao Dao = new UserDao();
        public bool Create(User user)
        {
            return Dao.AddUser(user);
        }

        public bool Delete(int id)
        {
            return Dao.DeleteUser(id);
        }

        public DataTable Read()
        {
            return Dao.GetAllUsers();
        }

        public bool Update(User user)
        {
            return Dao.UpdateUser(user);
        }
    }
}
