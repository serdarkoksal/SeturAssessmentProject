using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Directory.Models;
using Directory.Services;

namespace Directory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _contactService.CreateAsync(contact).ConfigureAwait(false);
            return Ok(contact.Id);
        }
        [HttpGet("{Konum}")]
        public async Task<IActionResult> IsminiSerdarKoysun(string Konum)
        {
            var person = await _contactService.GetByKonumListAsync(Konum).ConfigureAwait(false);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
    }
}
