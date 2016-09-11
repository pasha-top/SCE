using DataAccess.Models;
using System.Data.Entity;

namespace DataAccess.Contexts
{
    public class SCEContext : DbContext
    {
        public SCEContext() : base("SCEContext") { }

        public  DbSet<Content> Contents { get; set; }
    }
}
