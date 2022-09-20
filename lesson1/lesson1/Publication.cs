using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    public abstract class Publication
    {
        public string Name { get; set; }
        public int CountPublication { get; set; }
        public DateTime CretedEdition { get; set; }

        public abstract void ShowInfo();
       
    }
}
