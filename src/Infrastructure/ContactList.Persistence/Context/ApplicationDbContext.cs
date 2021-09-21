using ContactList.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person() { Id = Guid.NewGuid(), FirstName = "Ahmet", LastName = "Yılmaz", BirthDate = DateTime.Now, Email = "test@test.com" },
                new Person() { Id = Guid.NewGuid(), FirstName = "Mehmet", LastName = "Yılmaz", BirthDate = DateTime.Now, Email = "test@test.com" },
                new Person() { Id = Guid.NewGuid(), FirstName = "Hasan", LastName = "Yılmaz", BirthDate = DateTime.Now, Email = "test@test.com" },
                new Person() { Id = Guid.NewGuid(), FirstName = "Metin", LastName = "Yılmaz", BirthDate = DateTime.Now, Email = "test@test.com" }
                
                
                );


            base.OnModelCreating(modelBuilder);
        }
    }
}
