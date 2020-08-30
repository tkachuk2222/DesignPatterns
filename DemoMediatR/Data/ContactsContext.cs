using Microsoft.EntityFrameworkCore;

namespace DemoMediatR.Data
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Contact>().HasData(
                new Contact {Id = 1, FirstName = "Steve", LastName = "Michelotti"},
                new Contact {Id = 2, FirstName = "Ivan", LastName = "Tkachuk"},
                new Contact {Id = 3, FirstName = "Bill", LastName = "Gates"}
            );
        }
    }
}
