using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFStudentSystem.Models
{
    public enum ResourceType { Video, Presentation, Document, Other }

    internal class Resource
    {
        [Key]
        public int ResourceId { get; set; }

        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; }

        [Unicode(false)]
        public string Url { get; set; }

        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
