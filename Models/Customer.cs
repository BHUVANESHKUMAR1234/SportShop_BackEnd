using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop.WebApi.Models
{
    public class Customer
    {

        [Key]
        public int CustomerId { get; set; }

        //[Column(TypeName = "nvarchar(200)")]
        //[Required(ErrorMessage = "This field is required.")]
        //[DisplayName("Customer Name")]
        public string CustomerName { get; set; }

        //[Column(TypeName = "nvarchar(20)")]
        //[DisplayName("Email ID")]
        public string ContactNumber { get; set; }

        //[Column(TypeName = "nvarchar(200)")]
        //[DisplayName("Email ID")]
        public string Address { get; set; }


        //[Column(TypeName = "nvarchar(100)")]
        //[DisplayName("Email ID")]
        public string EmailId { get; set; }

    }
}
