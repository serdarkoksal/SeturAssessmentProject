using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Directory.Models;

namespace Directory.Repository
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetAllAsync();
        Task<Contact> CreateAsync(Contact contact);
        Task DeleteAsync(string id);
        Task<List<Contact>> GetByKonumListAsync(string Konum);
    }
}
