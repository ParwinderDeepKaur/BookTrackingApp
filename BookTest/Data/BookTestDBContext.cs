using BookTest.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookTest.Data
{
    public class BookTestDBContext : DbContext
    {

        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryType> CategType { get; set; }

        /// <summary>
        /// DB path (Data base location)
        /// </summary>
        public string DbPath { get; private set; }

        public BookTestDBContext()
        {
            var path = Environment.CurrentDirectory;
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}BookTest.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

}
