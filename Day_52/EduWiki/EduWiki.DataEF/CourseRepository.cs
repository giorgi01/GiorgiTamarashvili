using EduWiki.Data;
using EduWiki.Domain.POCO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EduWiki.DataEF
{
    public class CourseRepository : ICourseRepository
    {
        readonly IBaseRepository<Course> _repo;


        public CourseRepository(IBaseRepository<Course> repo)
        {
            _repo = repo;
        }

        public void SetModifiedState(Course entity)
        {
            _repo.SetState(entity, EntityState.Modified);
        }
    }
}
