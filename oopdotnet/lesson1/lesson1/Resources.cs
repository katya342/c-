using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    public class Resources : Publication
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SecondName { get; set; }
        public string Annotation { get; set; }
        public override void ShowInfo()
        {
            
        }
    }
}
