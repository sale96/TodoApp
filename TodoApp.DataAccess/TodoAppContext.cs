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

        public DbSet<Todo> Todos { get; set; }
    }
}
