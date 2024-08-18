using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class Phone
    {
        public long PhoneId { get; set; }

        [Required]
        [MaxLength(500)]
        public string PhoneDescription { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price cannot be negative")]
        public float Price { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public string BrandName { get; set; }

        public int InStock { get; set; }
    }
}
