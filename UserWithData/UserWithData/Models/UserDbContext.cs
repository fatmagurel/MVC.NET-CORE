using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserWithData.Models;

namespace UserWithData.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) 
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserWithData.Models.UserShortListViewModel> UserShortListViewModel { get; set; }
    }
}
