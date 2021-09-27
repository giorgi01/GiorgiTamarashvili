using EduWiki.Data;
using EduWiki.Domain.POCO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EduWiki.DataEF
{
    public class LecturerCourseRepository : ILecturerCourseRepository
    {
        readonly IBaseRepository<LecturerCourse> _repo;


        public LecturerCourseRepository(IBaseRepository<LecturerCourse> repo)
        {
            _repo = repo;
        }

        public void SetModifiedState(LecturerCourse entity)
        {
            _repo.SetState(entity, EntityState.Modified);
        }

        public async Task CreateAsync(LecturerCourse entity)
        {
            await _repo.AddAsync(entity);
        }

        public async Task<bool> ExistsAnotherOwner(int lecturerId, int courseId)
        {
            return await _repo.AnyAsync(x => x.LecturerId != lecturerId && x.CourseId == courseId);
        }
    }
}
