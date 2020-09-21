using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServices.Models.Enuns;

namespace UserServices.Models.Context
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options) { }
        public DbSet<Users> Users {get; set;}

        public DbSet<Education> Educations {get; set;}
    }
}
