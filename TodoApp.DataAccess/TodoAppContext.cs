using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.DataAccess.Configurations;
using TodoApp.Domain;

namespace TodoApp.DataAccess
{
    public class TodoAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TodoApp;Integrated Security=True");

            base.OnConfiguring(optionBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TodoConfiguration());
        }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is BaseEntity e)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            e.CreateAt = DateTime.Now;
                            e.UpdatedAt = null;
                            break;
                        case EntityState.Modified:
                            e.UpdatedAt = DateTime.Now;
                            break;
                    }
                }
            }

            return base.SaveChanges();
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
