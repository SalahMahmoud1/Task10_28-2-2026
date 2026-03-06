using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesDB.Model
{
    internal class Store
    {
        [Key]
        public int StoreId { get; set; }

        //[Required, MaxLength(80)]
        //[Unicode(true)]
        public string Name { get; set; }

    }
}
