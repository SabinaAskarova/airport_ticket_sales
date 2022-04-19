using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.DAL.IRepositories
{
    public interface IUserRepository
    {
        public List<User> Get();
        
        public User GetById(int userId);
        
        public User Add(User user);
        
        public User Update(User user);

        public void Delete(int userId);        
    }
}
