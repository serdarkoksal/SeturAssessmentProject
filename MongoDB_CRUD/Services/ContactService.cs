using System.Collections.Generic;
using System.Threading.Tasks;
using Directory.Models;
using Directory.Repository;

namespace Directory.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Task<List<Contact>> GetAllAsync()
        {
            return _contactRepository.GetAllAsync();
        }

        public Task<Contact> CreateAsync(Contact contact)
        {
            return _contactRepository.CreateAsync(contact);
        }
        public Task DeleteAsync(string id)
        {
            return _contactRepository.DeleteAsync(id);
        }
        public Task<List<Contact>> GetByKonumListAsync(string Konum)
        {
            return _contactRepository.GetByKonumListAsync(Konum);
        }
    }
}
