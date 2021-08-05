using PersonManagement.Service.Abstractions;
using PersonManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.Service.Implementations
{
    public class PersonService : IPersonService
    {
        #region PersonData

        private static List<PersonServiceModel> _persons = new List<PersonServiceModel>
        {
             new PersonServiceModel
             {
                 Id = 1, FirstName = "გიორგი", LastName = "ქაშიაშვილი", Gender =  true, PersonIdentifier = "01005215415", BirthDate = DateTime.Now.AddYears(-20), City = new CityServiceModel{Name = "Tbilisi"}
             },
               new PersonServiceModel
             {
                 Id = 2, FirstName = "ნინო", LastName = "ლომინიაძე", Gender =  false, PersonIdentifier = "01005214854", BirthDate = DateTime.Now.AddYears(-19), City = new CityServiceModel{Name = "Batumi"}
             },  new PersonServiceModel
             {
                 Id = 3, FirstName = "ქეთი", LastName = "ნებიერიძე", Gender =  false, PersonIdentifier = "01025216952", BirthDate = DateTime.Now.AddYears(-26), City = new CityServiceModel{Name = "Telavi"}
             },  new PersonServiceModel
             {
                 Id = 4, FirstName = "ლაშა", LastName = "დაუშვილი", Gender =  true, PersonIdentifier = "01003525147", BirthDate = DateTime.Now.AddYears(-30), City = new CityServiceModel{Name = "Kutaisi"}
             },
        };

        #endregion

        public async Task<List<PersonServiceModel>> GetAllAsync()
        {
            return await Task.FromResult(_persons);
        }

        public async Task<PersonServiceModel> GetAsync(int id)
        {
            return _persons.SingleOrDefault(x => x.Id == id);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            if (!_persons.Exists(x => x.Id == id))
                return false;

            var person = await GetAsync(id);
            _persons.Remove(person);

            return true;
        }

        public async Task Add(PersonServiceModel person)
        {
            _persons.Add(person);

            await Task.CompletedTask;
        }
    }
}
