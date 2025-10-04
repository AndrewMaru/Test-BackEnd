using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Test_BackEnd.Models
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions<BankDbContext> options) 
            : base(options) 
        { 
        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<StatusModel> Statuses { get; set; }
    }
}
