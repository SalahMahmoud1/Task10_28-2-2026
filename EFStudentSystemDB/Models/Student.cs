using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFStudentSystem.Models
{
    internal class Student
    {
        [Key]
        public int StudentId { get; set; }

        [MaxLength(100)]
        //[Unicode(true)]
        public string Name { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }

        public DateTime? Birthday { get; set; }
        public DateTime RegisteredOn { get; set; }

    }

}
