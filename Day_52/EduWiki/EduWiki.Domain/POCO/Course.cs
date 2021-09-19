using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EduWiki.Domain.POCO
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public int ECTS { get; set; }
        public List<LecturerCourse> LecturerCourses { get; set; }
    }
}
