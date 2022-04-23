#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonsWebApp.DAL;
using PersonsWebApp.DAL.Entities;
using PersonsWebApp.Services;

namespace PersonsWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IService<PersonEntity, PersonDto> _personService;

        public PersonController(IService<PersonEntity, PersonDto> personService)
        {
            _personService = personService;
        }

        // GET: api/Person
        [HttpGet]
        public ActionResult<IEnumerable<PersonDto>> Get([FromQuery] SkipTakeFilter filter)
        {
            var result = _personService.GetAll();

            if (filter.Skip != 0)
                result = result.Skip(filter.Skip);

            if (filter.Take != 0)
                result = result.Take(filter.Take);

            return Ok(result);
        }

        // GET: api/Person/Search
        [HttpGet("Search")]
        public ActionResult<IEnumerable<PersonDto>> GetSearch([FromQuery] string searchTerm)
        {
            var result = _personService
                .GetAll()
                .Where(person => person.LastName == searchTerm);

            return Ok(result);
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonDto>> Get(int id)
        {
            var personEntity = await _personService.Get(id);

            if (personEntity == null)
            {
                return NotFound();
            }

            return personEntity;
        }

        // PUT: api/Person/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] PersonDto personDto)
        {
            if (id != personDto.Id)
            {
                return BadRequest();
            }

            try
            {
                await _personService.Update(personDto);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonEntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Person
        [HttpPost]
        public async Task<ActionResult<PersonEntity>> Post([FromBody] PersonDto person)
        {
            var createdItem = await _personService.InsertAsync(person);

            return CreatedAtAction(nameof(Post), new { id = createdItem.Id }, createdItem);
        }

        // DELETE: api/Person/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool result = await _personService.Delete(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        private bool PersonEntityExists(int id)
        {
            return _personService.GetAll().Any(e => e.Id == id);
        }
    }

    public class SkipTakeFilter : IQueryFilter
    {
        public int Skip { get; set; }
        public int Take { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
