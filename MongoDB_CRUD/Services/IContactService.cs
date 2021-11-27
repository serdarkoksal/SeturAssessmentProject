using System.Collections.Generic;
using System.Threading.Tasks;
using Directory.Models;

namespace Directory.Services
{
    public interface IContactService
    {
        Task<List<Contact>> GetAllAsync();
        Task<Contact> CreateAsync(Contact contact);
        Task DeleteAsync(string id);
        Task<List<Contact>> GetByKonumListAsync(string Konum);
    }
}
