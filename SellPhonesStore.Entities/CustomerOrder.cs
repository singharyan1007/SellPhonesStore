using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class CustomerOrder
    {
        [Key]
        public long OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; } //Navigation
        public long CustomerId { get; set; }  //Foreign Key
        public long OrderTotal { get; set; }
        public List<OrderedPhone> OrderedPhones  {get;set;}
    }
}
