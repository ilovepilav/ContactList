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
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.CreateDate).IsRequired();
            builder.Property(c => c.ContactName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(10);
            builder.HasOne<Person>(c => c.Person).WithMany(c => c.Contacts).HasForeignKey(c => c.PersonId);
        }
    }
}
