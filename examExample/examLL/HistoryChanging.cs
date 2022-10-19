using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examLL
{
    public class HistoryChanging
    {
        public int HistoryChangingId { get; set; }
        public string User { get; set; }
      // public DateTime ChangingTime { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime Changes { set; get; }

    }
}
