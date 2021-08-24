using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RoyalstarAdminPanel.Data;
using RoyalstarAdminPanel.Models;

namespace RoyalstarAdminPanel.Services
{
    public class AuthService
    {
        private readonly DataContext _context;
        public AuthService(DataContext context)
        {
            _context = context;
        }
        public async Task<User> LoginAsync(string username, string password)
        {
            var userFromDb = await _context.Users.FirstOrDefaultAsync(x => x.Username.ToLower() == username.ToLower());

            if (userFromDb == null)
                return null;
            
            if(userFromDb.Password != password)
                return null;
            
            return userFromDb;
        }

        public async Task<User> RegisterAsync()
        {
            var userToCreate = new User{
                Username = "admin",
                Password =  "admin"
            };

            await _context.Users.AddAsync(userToCreate);
            await _context.SaveChangesAsync();

            return userToCreate;
        }
    }
}