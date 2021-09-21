using ContactList.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Persistence.Mappings
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.CreateDate).IsRequired();
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(20);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(20);
            builder.Property(p => p.BirthDate).IsRequired();
            builder.Property(p => p.Email).IsRequired();

            builder.HasData(
                new Person() { Id = Guid.NewGuid(), FirstName = "Ahmet", LastName = "Yılmaz", BirthDate = DateTime.Now, Email = "test@test.com" },
                new Person() { Id = Guid.NewGuid(), FirstName = "Mehmet", LastName = "Kaya", BirthDate = DateTime.Now, Email = "test@test.com" },
                new Person() { Id = Guid.NewGuid(), FirstName = "Hasan", LastName = "Turan", BirthDate = DateTime.Now, Email = "test@test.com" },
                new Person() { Id = Guid.NewGuid(), FirstName = "Metin", LastName = "Ateş", BirthDate = DateTime.Now, Email = "test@test.com" }
                );
        }
    }
}
