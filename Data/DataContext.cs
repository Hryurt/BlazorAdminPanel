using System;
using Microsoft.EntityFrameworkCore;
using AdminPanel.Models;

namespace AdminPanel.Data
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