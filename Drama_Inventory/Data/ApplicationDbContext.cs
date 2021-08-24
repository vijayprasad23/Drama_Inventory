using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Drama_Inventory.Models;

namespace Drama_Inventory.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Drama_Inventory.Models.Student> Student { get; set; }
        public DbSet<Drama_Inventory.Models.Item> Item { get; set; }
        public DbSet<Drama_Inventory.Models.Loan> Loan { get; set; }
    }
}
