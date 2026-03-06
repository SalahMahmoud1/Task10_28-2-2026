using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesDB.Model
{
    internal class Product
    {
        [Key]
        public int ProductId { get; set; }

        //[Required, MaxLength(50)]
        //[Unicode(true)]
        public string Name { get; set; }

        public double Quantity { get; set; }

        public decimal Price { get; set; }
        //add Description Column
        [MaxLength(250)]
        //[DefaultValue("No description")]
        public string Description { get; set; } = "No description";


    }
}
