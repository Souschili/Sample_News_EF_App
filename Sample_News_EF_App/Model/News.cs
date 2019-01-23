using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_News_EF_App.Model
{
    public class News
    {
        public int Id  { get; set; }
        public string Author { get; set; }
        public string Text  { get; set; }

        //Внешняя связь с таблицей коментариев, автогенерация ключа
        public List<Coment> Coments { get; set; }

        //либо так либо по умолчанию выделить память под пустой лист
        public News()
        {
            Coments = new List<Coment>();
        }
    }
}
