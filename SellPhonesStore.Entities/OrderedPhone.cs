using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class OrderedPhone
    {
        public long OrderedPhoneId { get; set; }
        public Phone  Phone { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative")]
        public long Quantity { get; set; }

        public long PhoneId { get; set; }  //Foreign Key
    }
}
