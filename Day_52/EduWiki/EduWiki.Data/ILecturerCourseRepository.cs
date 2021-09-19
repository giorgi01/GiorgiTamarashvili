using EduWiki.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduWiki.Data
{
    public interface ILecturerCourseRepository
    {
        void SetModifiedState(LecturerCourse entity);
    }
}
