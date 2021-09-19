using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EduWiki.Domain.POCO
{
    public class Lecturer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<LecturerCourse> LecturerCourses { get; set; }
        public string AboutText { get; set; }
        public string ImagePath { get; set; }
    }
}
