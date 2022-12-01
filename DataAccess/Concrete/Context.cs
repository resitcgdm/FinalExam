using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"server=DESKTOP-QP5A446;database=ReaFinalExam;trusted_connection=true");
        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Statu> Status { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Mission> Missions { get; set; }
    }
}
