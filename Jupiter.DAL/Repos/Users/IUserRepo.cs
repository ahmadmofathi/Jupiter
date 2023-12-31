﻿

namespace Jupiter.DAL
{
    public interface IUserRepo
    {
        List<User> GetUsers(); 
        User GetById(int id);
        
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        int SaveChanges();
    }
}
