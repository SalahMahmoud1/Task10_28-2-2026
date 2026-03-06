using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFStudentSystem.Models
{
    internal class Course
    {
        [Key]
        public int CourseId { get; set; }

        [MaxLength(80)]
        [Unicode(true)]
        public string Name { get; set; }

        [Unicode(true)]
        public string? Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
    }
}
