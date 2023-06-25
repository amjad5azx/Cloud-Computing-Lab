using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PayrollApi.Models
{
    public class SqlDbContext : DbContext  
	{  
	public SqlDbContext() : base("name=SqlConn")
	{  
	}
        public DbSet<Payroll> Payroll { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payroll>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);
        }
	}  
}  