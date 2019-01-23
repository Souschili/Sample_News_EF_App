using Microsoft.EntityFrameworkCore;
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

                //миграция addcoments добавляем коментарии к записи
                // var t = db.News.FirstOrDefault(x => x.Id == 1);
                // if(t.Coments!=null)
                // {
                //     t.Coments.Add(new Coment { Author = "Kakoyto", Text = "This is bull shit" }
                //     );
                // db.SaveChanges();
                //
                // }
                // else
                // {
                //     Console.WriteLine("We have problem ^(");
                // }

                //Вывод новости с айди 1  и коментария(ев) к ней
                var news1 = db.News.Where(x => x.Id == 1).Include(p => p.Coments).FirstOrDefault();
                // if(news1!=null)
                // {
                //     Console.WriteLine($"Сама новость {news1.Text} за авторством {news1.Author}\n");
                //     foreach (var e in news1.Coments)
                //     {
                //         Console.WriteLine(e.Text);
                //
                //     }
                // }

                //редактирование коментария
                //news1.Coments[0].Text = "Perfect job you are great";
                //db.SaveChanges();
                //Console.WriteLine(news1.Coments[0].Text);


                //Console.WriteLine(t.Text);
            


            }


        }
    }
}
