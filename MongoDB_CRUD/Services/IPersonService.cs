using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Directory.Models;

namespace Directory.Services
{
    public interface IPersonService
    {
        Task<List<Person>> GetAllAsync();
        Task<Person> GetByIdAsync(string id);
        Task<Person> CreateAsync(Person person);
        Task UpdateAsync(string id, Person person);
        Task DeleteAsync(string id);
    }
}
