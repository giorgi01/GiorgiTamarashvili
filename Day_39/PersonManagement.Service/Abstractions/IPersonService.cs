using PersonManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.Service.Abstractions
{
    public interface IPersonService
    {
        Task<List<PersonServiceModel>> GetAllAsync();
        Task<PersonServiceModel> GetAsync(int id);
        Task<bool> DeleteAsync(int id);
        Task Add(PersonServiceModel person);
    }
}
