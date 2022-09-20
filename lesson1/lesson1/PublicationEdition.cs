using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    public class PublicationEdition
    {
        List<Publication> publications = new List<Publication>();
        public PublicationEdition()
        {
            publications.Add(new Book() { Name = "Алые Паруса", Author = "Стивен Кинг", YearOfPublic = new DateTime(2223) });
            publications.Add(new Article("TITLE", "IVANOV", "CCCCCC"));
        }
        public Publication this [int index]
        {
            get { return publications[index]; }
            set { publications[index] = value; }
        }

    }
}
