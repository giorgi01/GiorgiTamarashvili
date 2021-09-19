using System.Collections.Generic;

namespace EduWiki.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public int ECTS { get; set; }
    }
}