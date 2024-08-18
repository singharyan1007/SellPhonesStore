using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class Phone
    {
        public long PhoneId { get; set; }
        public string PhoneDescription { get; set; }
        public float Price { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public string BrandName { get; set; }

        public int InStock { get; set; }
    }
}
