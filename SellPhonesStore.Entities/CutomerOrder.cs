using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class CutomerOrder
    {
        public long OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public long OrderTotal { get; set; }
        public List<OrderedPhone> OrderedPhones  {get;set;}
    }
}
