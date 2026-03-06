using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesDB.Model
{
    internal class Sale
    {
        [Key]
        public int SaleId { get; set; }

        public DateTime Date { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CustomerId { get; set; }
        public Coustomer Coustomer { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }
    }

}
