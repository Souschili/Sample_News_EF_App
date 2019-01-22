using Microsoft.EntityFrameworkCore;
using Sample_News_EF_App.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_News_EF_App.Data
{
    class NewsContext:DbContext
    {
        public DbSet<News> News { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=SampleNews;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        }

    }
}
