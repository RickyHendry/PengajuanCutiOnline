using Microsoft.EntityFrameworkCore;
using PengajuanCutiOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PengajuanCutiOnline.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContext) : base(dbContext)
        {

        }

        // mengatur connection string (done)
        // menambahkan model untuk diolah dan / atau migrasi

        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
