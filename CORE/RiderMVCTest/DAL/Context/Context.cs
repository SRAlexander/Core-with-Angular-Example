using System;
using Microsoft.EntityFrameworkCore;
using RiderMVCTest.DAL.Models;

namespace RiderMVCTest.DAL.Context
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options) : base(options)
        {
            
        }
        
        public DbSet<TestTable> TestTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestTable>().ToTable("TestTable");
            
        }
    }
}