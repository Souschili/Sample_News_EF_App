using Microsoft.EntityFrameworkCore;
using Sample_News_EF_App.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_News_EF_App.Data
{
    //команды EF основные выполнять нугет пакадж менеджере консоль
    //add-migration %dbname% - создать миграцию
    //update-database –verbose - применить изменения и создать или изменить базу

    class NewsContext :DbContext
    {
        public DbSet<News> News { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=SampleNews;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        }

    }
}
