using Sample_News_EF_App.Data;
using Sample_News_EF_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample_News_EF_App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NewsContext())
            {
                //Добавление данных в одиночную таблицу
                //List<News> ln = new List<News>
                //{
                //    new News{Author="Dill",Text="first news"},
                //    new News{Author="Lil Kim",Text="Kiso ku ku epta"},
                //    new News{Author="Dylan", Text="Fuck you!!!!!!!"}
                //};
                //db.News.AddRange(ln);
                //db.SaveChanges();
                //Console.WriteLine("Data transfer finish !");

                //Вывод даных по критерию 
                //var n = db.News.Where(x => x.Id > 1 && x.Author=="Dylan").FirstOrDefault();

                // foreach (var item in n)
                // {
                //     Console.WriteLine($"News Id:{item.Id}\nNews Author: {item.Author}\nNews Text: {item.Text}");
                // }

                //апдейт данных пример 
                //n.Text = "Sorry :0(";
                //db.News.Update(n);
                //db.SaveChanges();
            
            }


        }
    }
}
