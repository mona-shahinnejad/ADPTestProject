using ADPTestProject.Data.Entities;
using System.Data.Entity;

namespace ADPTestProject.Data
{
    public class ADPTestProjectDatabaseContext : DbContext
    {
        public ADPTestProjectDatabaseContext()
            : base("ADPTest")
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Email> Emails { get; set; }

        public DbSet<Phone> Phones { get; set; }
    }
}
