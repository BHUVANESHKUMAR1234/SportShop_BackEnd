using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SportsShop.WebApi.Models
{
    public class Order
    {
        [Key]
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int ItemNumber { get; set; }
        public int CustomerId { get; set; }

        //public virtual Customer Customer { get; set; }

        //public virtual Item Item { get; set; }
       




    }
}
