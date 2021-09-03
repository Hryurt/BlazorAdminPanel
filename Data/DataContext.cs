using Microsoft.EntityFrameworkCore;
using RoyalstarAdminPanel.Models;

namespace RoyalstarAdminPanel.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<MainMachine> MainMachines { get; set; }
    }
}