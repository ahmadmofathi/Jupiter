using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.BL;

public interface IUserManager
{
    IEnumerable<UserReadDto>GetUsers();
    UserReadDto GetUser(int id);
    int Add(UserReadDto user);
    bool Update(UserReadDto user);
    bool Delete(int id);
}
