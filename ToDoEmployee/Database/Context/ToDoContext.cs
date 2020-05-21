using Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Context
{
    public class ToDoContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ToDo> Tasks { get; set; }

        public ToDoContext(DbContextOptions<ToDoContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
