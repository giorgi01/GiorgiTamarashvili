using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EduWiki.Domain.POCO
{
    public class LecturerCourse
    {
        public int LecturerId { get; set; }
        public int CourseId { get; set; }
        public Lecturer Lecturer { get; set; }
        public Course Course { get; set; }
    }
}
