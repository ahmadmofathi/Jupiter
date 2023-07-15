using Jupiter.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.BL
{
    public class UserManager
    {
        private readonly IUserRepo _userRepo;

        public UserManager(IUserRepo userRepo) {
            _userRepo = userRepo;
        }
        public IEnumerable<UserReadDto> GetUsers()
        {
            IEnumerable<User> usersFromDb = _userRepo.GetUsers();
            return usersFromDb.Select(u => new UserReadDto()
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                Password    = u.Password,
                PhoneNumber = u.PhoneNumber,
                WhatsApp = u.WhatsApp,
                Address = u.Address,
                Branch = u.Branch,
                Role = u.Role,
            });
        }
    }
}
