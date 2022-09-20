using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    public class Article : Publication
    {
        public Article(string Title, string AuthorSecNm, string TitleJourn)
        {
           this.Title = Title;
           this.AuthorSecondName = AuthorSecNm;
           this.TitleJournal = TitleJourn;
        }
        public string Title { get; set; }
        public string AuthorSecondName { get; set; }
        public string TitleJournal { get; set; }
        public DateTime YearOfPublication { get; set; } = DateTime.Now;

        public override void ShowInfo()
        {
            Console.WriteLine(base.Name);
            Console.WriteLine();
        }
    }
}
