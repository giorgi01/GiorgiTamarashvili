using System.Collections.Generic;

namespace EduWiki.Services.Models
{
    public class CourseServiceModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public int ECTS { get; set; }
        public List<LecturerServiceModel> Lecturers { get; set; }
    }
}