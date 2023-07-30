//КЛАСС ENTITY CONTEXT
using System.Data.Entity;


namespace LAB_8.Models
{
    public class EntityContext : DbContext
    {
        public EntityContext(): base("DefaultConnection")
        {
            Database.SetInitializer(new DataBaseInitializer());
        }
        public DbSet<Payment> payments { get; set; }
    }
}
