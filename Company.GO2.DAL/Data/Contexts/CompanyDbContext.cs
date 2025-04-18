﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Company.GO2.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.GO2.DAL.Data.Contexts
{



    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Depratment> Depratments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }

    //public class CompanyDbContext : DbContext
    //{
    //    public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
    //    {

    //    }
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        ModelBuilder modelBuilder1 = modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    //        base.OnModelCreating(modelBuilder);
    //    }
    //    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    //{
    //    //    optionsBuilder.UseSqlServer("Server = .; Database = CompanyG02 ; Trusted_Connection = True ;TrustServerCertificate = True");
    //    //}

    //    public DbSet<Depratment> Depratments { get; set; }
    //}
}
