using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace BolonChat.Models
{
    public class BolonChatDbContext : DbContext
    {
        public BolonChatDbContext(DbContextOptions<BolonChatDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}