using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface IUserManagement
    {
        bool Create(User user);
        string Read();
        bool Update(User user);
        bool Delete(int id);
    }
}
