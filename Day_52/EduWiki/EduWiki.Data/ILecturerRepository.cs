using EduWiki.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduWiki.Data
{
    public interface ILecturerRepository
    {
        Task<List<Lecturer>> GetAllAsync();
        Task<Lecturer> GetAsync(int id);
        Task<int> CreateAsync(Lecturer lecturer);
        Task<bool> Exists(int id);
        Task UpdateAsync(Lecturer lecturer);
        Task DeleteAsync(int id);
        Task<List<int>> GetRelatedCourseIds(int id);
    }
}
