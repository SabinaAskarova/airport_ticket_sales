using MyProject.DAL.DataContext;
using MyProject.DAL.IRepositories;
using MyProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyProject.DAL.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly TestDbContext _ctx;

        public UserRepository(TestDbContext ctx)
        {
            _ctx = ctx; 
        }

        public User Add(User user)
        {
            _ctx.Add(user);
            _ctx.SaveChanges();
            return user;
        }

        public void Delete(int userId)
        {
            User user = _ctx.Users.Find(userId);
            user.IsDeleted = true;
            _ctx.SaveChanges();
        }

        public List<User> Get()
        {
            return _ctx.Users.OrderBy(m => m.UserId).ToList();
        }

        public User GetById(int userId)
        {
            return _ctx.Users.Find(userId);
        }

        public User Update(User user)
        {
            _ctx.Users.Update(user);
            _ctx.SaveChanges();
            return user;
        }
    }
}
