using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Visit
    {
        [Key]
        public int Id { get; set; }
        public DateTime VisitData { get; set; }
        public double OrderAmount { get; set; }
        public string OrderStatus { get; set; }
        public virtual Client Client { get; set; }
    }
}
