using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduWiki.Services.Models
{
    public class LecturerServiceModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<CourseServiceModel> Courses { get; set; }
        public string AboutText { get; set; }
        public string ImagePath { get; set; }
    }
}
