using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Directory.Models;

namespace Directory.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly IMongoCollection<Contact> _collection;
        private readonly IMongoCollection<Person> _collectionPerson;
        private readonly DbConfiguration _settings;
        public ContactRepository(IOptions<DbConfiguration> settings)
        {
            _settings = settings.Value;
            var client = new MongoClient(_settings.ConnectionString);
            var database = client.GetDatabase(_settings.DatabaseName);
            _collection = database.GetCollection<Contact>(_settings.CollectionName);
            _collectionPerson = database.GetCollection<Person>(_settings.CollectionName);
        }

        public Task<List<Contact>> GetAllAsync()
        {
            return _collection.Find(c => true).ToListAsync();
        }
        public async Task<Contact> CreateAsync(Contact contact)
        {
            contact.ContactId = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 24);
            if (contact.Id != null)
            {
                var resultPerson = await _collectionPerson.Find(c => c.Id == contact.Id).FirstOrDefaultAsync();
                if (resultPerson.contacts == null){resultPerson.contacts = new List<Contact>();}
                resultPerson.contacts.Add(contact);
                _collectionPerson.ReplaceOneAsync(c => c.Id == resultPerson.Id, resultPerson);
            }
            else {
                await _collection.InsertOneAsync(contact).ConfigureAwait(false);

            }
            return contact;
        }
        public Task DeleteAsync(string id)
        {
            return _collection.DeleteOneAsync(c => c.Id ==id);
        }
        public async Task<List<Contact>> GetByKonumListAsync(string Konum)
        {
            var gg = _collection .Find(x => x.Konum ==Konum).ToListAsync().Result;
            return gg;

        }
    }
}
