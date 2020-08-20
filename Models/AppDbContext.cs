using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BookListMVC.Models
{
    public class AppDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public Microsoft.EntityFrameworkCore.DbSet<Book> Books { get; set; }
    }
}
