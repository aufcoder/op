using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ContactsAPIContext : DbContext
    {
        public ContactsAPIContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet <Contact> Contacts { get; set; }
    }
}