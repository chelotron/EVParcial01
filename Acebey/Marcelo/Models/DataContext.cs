namespace Marcelo.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Marcelo.Models.Clown> Clowns { get; set; }
    }
}