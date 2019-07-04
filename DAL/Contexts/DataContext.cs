using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DAL.Contexts
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-KSMGIIG;Initial Catalog=MovieSatar;Integrated Security=True");
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieDetail> MovieDetail { get; set; }
      
      
    }
    
}
