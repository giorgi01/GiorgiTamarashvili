using EduWiki.Data;
using EduWiki.Domain.POCO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWiki.DataEF
{
    public class LecturerRepository : ILecturerRepository
    {
        readonly IBaseRepository<Lecturer> _repository;

        public LecturerRepository(IBaseRepository<Lecturer> repository)
        {
            _repository = repository;
        }

        public async Task<int> CreateAsync(Lecturer lecturer)
        {
            await _repository.AddAsync(lecturer);
            return lecturer.Id;
        }

        public Task DeleteAsync(int id)
        {
            return _repository.RemoveAsync(id);
        }

        public async Task<bool> Exists(int id)
        {
            return await _repository.AnyAsync(x => x.Id == id);
        }

        public async Task<List<Lecturer>> GetAllAsync()
        {
            var smth = await _repository.Table.Include(x => x.LecturerCourses).ThenInclude(x => x.Course).ToListAsync();
            return smth;
        }

        public async Task<Lecturer> GetAsync(int id)
        {
            return await _repository.Table.Include(x => x.LecturerCourses).ThenInclude(x => x.Course).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<int>> GetRelatedCourseIds(int id)
        {
            return await _repository.Table.Where(x => x.Id == id).SelectMany(x => x.LecturerCourses).Select(x => x.CourseId).ToListAsync();
        }

        public Task UpdateAsync(Lecturer lecturer)
        {
            return _repository.UpdateAsync(lecturer);
        }
    }
}

