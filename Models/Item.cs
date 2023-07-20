using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SportsShop.WebApi.Models
{
    public class Item
    {

        [Key]
        public int ItemNumber{ get; set; }

        //[Column(TypeName = "nvarchar(50)")]
        //[Required(ErrorMessage = "This field is required.")]
        //[DisplayName("Customer Name")]
        public string ItemName { get; set; }

        //[Column(TypeName = "nvarchar(20)")]
        //[DisplayName("Email ID")]
        public string Color{ get; set; }

       // [Column(TypeName = "decimal")]
        //[DisplayName("Email ID")]
        public int Value { get; set; }


       
    }
}
