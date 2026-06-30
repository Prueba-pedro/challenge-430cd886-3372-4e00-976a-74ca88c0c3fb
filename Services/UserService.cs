using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Data;

namespace WebAPI.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public User RegisterUser(User user)
        {
            if (_context.Users.Any(u => u.Email == user.Email))
                return null;

            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }
    }
}