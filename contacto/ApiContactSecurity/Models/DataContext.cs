namespace ApiContactSecurity.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ApiContactSecurity.Models.Contact> Contacts { get; set; }
    }
}