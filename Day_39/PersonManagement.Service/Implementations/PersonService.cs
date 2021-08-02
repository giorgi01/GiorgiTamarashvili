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
                 Id = 1, FirstName = "გიორგი", LastName = "თამარაშვილი", Gender =  true, Description = "Good person", CreditCard = "4916111026621797", PersonIdentifier = "01005215495",
                 BirthDate = DateTime.Now.AddYears(-21), City = new CityServiceModel{Name = "Tbilisi"}, Email = "giorgi.tamarashvili.1@btu.edu.ge", Phone = "+995551995566", LinkedinProfile = "https://www.linkedin.com/in/gtamarashvili/"
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
