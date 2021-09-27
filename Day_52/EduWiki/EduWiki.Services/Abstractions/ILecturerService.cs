using EduWiki.Services.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduWiki.Services.Abstractions
{
    public interface ILecturerService
    {
        Task<List<LecturerServiceModel>> GetAllAsync();
        Task<(Status status, LecturerServiceModel)> GetAsync(int id);
        Task<(Status status, int id)> CreateAsync(LecturerServiceModel lecturer);
        Task<Status> UpdateAsync(LecturerServiceModel lecturer);
        Task<Status> DeleteAsync(int id);
    };
}
