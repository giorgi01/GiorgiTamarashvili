using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PersonManagement.Data;
using PersonManagement.DataADO.Models;
using PersonManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PersonManagement.DataADO.Implementations
{
    public class PersonRepository : IPersonRepository
    {

        //private DbContextOptions<PersonManagmentContext> _options;
        private readonly PersonManagmentContext _context;

        public PersonRepository(PersonManagmentContext context)
        {
            _context = context;
            //_options = new DbContextOptionsBuilder<PersonManagmentContext>()
            //    .UseSqlServer("Server=(localdb)\\ProjectsV13; Database=PersonManagement; Trusted_Connection=True; MultipleActiveResultSets=true")
            //    .Options;
        }

        public async Task<int> CreateAsync(Person person)
        {
            //var context = new PersonManagmentContext(_options);

            var persons = await _context.Persons.AddAsync(person);
            await _context.SaveChangesAsync();

            return person.Id;
        }

        public async Task DeleteAsync(int id)
        {
            //var context = new PersonManagmentContext(_options);

            var person = await _context.Persons.FindAsync(id).ConfigureAwait(false);

            if(person != null)
            {
                _context.Persons.Remove(person);
            }
            
            await _context.SaveChangesAsync();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Person>> GetAllAsync()
        {
            //var _context = new PersonManagmentContext(_options);

            await _context.Database.MigrateAsync().ConfigureAwait(false);

            var persons = await _context.Persons.ToListAsync().ConfigureAwait(false);

            return persons;
        }

        public async Task<Person> GetAsync(int id)
        {
            //var _context = new PersonManagmentContext(_options);

            var person = await _context.Persons.FindAsync(id).ConfigureAwait(false);

            return person;
        }

        public async Task UpdateAsync(Person person)
        {
            //var _context = new PersonManagmentContext(_options);

            
            //context.Persons.Update(person);

            var result = await _context.Persons.FindAsync(person.Id).ConfigureAwait(false);
            result.LastName = "Daushvili";

            await _context.SaveChangesAsync();
            //var result = await context.Persons.FindAsync(person.Id).ConfigureAwait(false);

            

        }
    }
}
