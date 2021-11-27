using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Directory.Models;
using Directory.Services;

namespace Directory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _personService.GetAllAsync().ConfigureAwait(false));
        }
        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> Get(string id)
        {
            var person = await _personService.GetByIdAsync(id).ConfigureAwait(false);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _personService.CreateAsync(person).ConfigureAwait(false);
            return Ok(person.Id);
        }
        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Person personIn)
        {
            var person = await _personService.GetByIdAsync(id).ConfigureAwait(false);
            if (person == null)
            {
                return NotFound();
            }
            await _personService.UpdateAsync(id, personIn).ConfigureAwait(false);
            return NoContent();
        }
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var person = await _personService.GetByIdAsync(id).ConfigureAwait(false);
            if (person == null)
            {
                return NotFound();
            }
            await _personService.DeleteAsync(person.Id.ToString()).ConfigureAwait(false);
            return NoContent();
        }

        

    }
}
