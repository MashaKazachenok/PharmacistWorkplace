using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime VisitData { get; set; }
        public int OrderAmount { get; set; }
        public string OrderStatus { get; set; }
        public Client Owner { get; set; }
    }
}
