using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesDB.Model
{
    internal class Coustomer
    {
        [Key]
        public int CoustomerId { get; set; }
        //[Required, MaxLength(100)]
        //[Unicode(true)]
        public string Name { get; set; }

        //[Required, MaxLength(80)]
        //[Unicode(false)]
        public string Email { get; set; }

        public string CreditCardNumber { get; set; }

    }
}
