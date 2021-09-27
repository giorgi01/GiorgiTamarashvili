using EduWiki.Data;
using EduWiki.Services.Abstractions;
using EduWiki.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using EduWiki.Domain.POCO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace EduWiki.Services.Implementations
{
    public class LecturerService : ILecturerService
    {
        #region Private Members

        private ILecturerRepository _repo;
        private ILecturerCourseRepository _lecturerCourseRepository;
        private ICourseRepository _courseRepository;

        #endregion

        #region Ctor

        public LecturerService(ILecturerRepository repo, ILecturerCourseRepository lecturerCourseRepository, ICourseRepository courseRepository)
        {
            _repo = repo;
            _lecturerCourseRepository = lecturerCourseRepository;
            _courseRepository = courseRepository;
        }

        #endregion
        public async Task<(Status status, int id)> CreateAsync(LecturerServiceModel lecturer)
        {
            var lecturerToInsert = lecturer.Adapt<Lecturer>();

            int insertedId = await _repo.CreateAsync(lecturerToInsert);

            return (Status.Success, insertedId);
        }

        public async Task<Status> DeleteAsync(int id)
        {
            if (!await _repo.Exists(id))
                return Status.NotFound;

            await _repo.DeleteAsync(id);

            return Status.Success;
        }

        public async Task<List<LecturerServiceModel>> GetAllAsync()
        {
            var result = await _repo.GetAllAsync();

            return result.Adapt<List<LecturerServiceModel>>();
        }

        public async Task<(Status status, LecturerServiceModel)> GetAsync(int id)
        {
            var result = await _repo.GetAsync(id);

            if (result == null)
                return (Status.NotFound, null);

            return (Status.Success, result.Adapt<LecturerServiceModel>());
        }

        public async Task<Status> UpdateAsync(LecturerServiceModel lecturer)
        {
            if (!(await _repo.Exists(lecturer.Id)))
                return Status.NotFound;

            var lecturerToUpdate = lecturer.Adapt<Lecturer>();

            var existingCourseIds = await _repo.GetRelatedCourseIds(lecturer.Id);

            foreach (var lecturerCourse in lecturerToUpdate.LecturerCourses.Where(x => existingCourseIds.Contains(x.CourseId)))
            {
                _lecturerCourseRepository.SetModifiedState(lecturerCourse);
                _courseRepository.SetModifiedState(lecturerCourse.Course);
            }

            await _repo.UpdateAsync(lecturerToUpdate);

            return Status.Success;
        }
    }
}
