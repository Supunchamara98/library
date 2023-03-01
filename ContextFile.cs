using Library.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Library
{
    public class ContextFile : DbContext
    {
        public ContextFile(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Owner> Owners { get; set; }

        public DbSet<Ussers> Ussers { get; set; }

    }
}
