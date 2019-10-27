using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace LoginManagement.Data
{
    public partial class LoginManagementDbContext : DbContext
    {
        public LoginManagementDbContext()
        {
        }

        public LoginManagementDbContext(DbContextOptions<LoginManagementDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
    }
}
