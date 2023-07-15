
using Jupiter.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.DAL
{
    public class UserRepo : IUserRepo
    {

       


        private readonly SystemContext _context;

        public UserRepo(SystemContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            _context.Users.Add(user);
        }
         public List<User> GetUsers()
         {
                    return _context.Set<User>().ToList();
         }
        public void Delete(User user)
        {
            _context.Set<User>().Remove(user);
        }
     

        public User GetById(int id)
        {
            return _context.Set<User>().Find(id);
        }


        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(User user)
        {

        }
    }
}
