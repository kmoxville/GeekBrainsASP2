#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonsWebApp.DAL;
using PersonsWebApp.DAL.Entities;
using PersonsWebApp.DAL.Responses.Person;
using PersonsWebApp.DAL.Validation;
using PersonsWebApp.Requests;
using PersonsWebApp.Services;

namespace PersonsWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public sealed class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET: api/Person
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetPersonsListByFilterRequest request)
        {
            IReadOnlyList<PersonDto> result;

            try
            {
                result = await _personService.GetByFilterAsync(request);
            }
            catch (ValidationException vx)
            {
                return BadRequest(vx.Result);
            }

            return Ok(new GetPersonsListResponse() { Persons = result });
        }

        // GET: api/Person/Search
        [HttpGet("Search")]
        public async Task<IActionResult> GetSearch([FromQuery] GetPersonsListBySearchTermRequest request)
        {
            IReadOnlyList<PersonDto> result;

            try
            {
                result = await _personService.GetBySearchTermAsync(request);
            }
            catch (ValidationException vx)
            {
                return BadRequest(vx.Result);
            }

            return Ok(new GetPersonsListResponse() { Persons = result });
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            PersonDto result;

            try
            {
                result = await _personService.GetByIdAsync(new GetPersonByIdRequest() { Id = id });
            }
            catch (ValidationException vx)
            {
                return BadRequest(vx.Result);
            }

            return Ok(new GetPersonResponse { Person = result });
        }

        // PUT: api/Person/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] UpdatePersonRequest request)
        {
            if (id != request.Person.Id)
            {
                return BadRequest();
            }

            try
            {
                await _personService.UpdateAsync(request);
            }
            catch (ValidationException vx)
            {
                return BadRequest(vx.Result);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PersonEntityExists(request.Person.Id))
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
        public async Task<ActionResult<PersonEntity>> Post([FromBody] InsertPersonRequest request)
        {
            PersonDto createdItem;

            try
            {
                createdItem = await _personService.InsertAsync(request);
            }
            catch (ValidationException vx)
            {
                return BadRequest(vx.Result);
            }

            return CreatedAtAction(nameof(Post), new { id = createdItem.Id }, createdItem);
        }

        // DELETE: api/Person/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            bool result;

            try
            {
                result = await _personService.DeleteAsync(new DeletePersonByIdRequest() { Id = id });
            }
            catch(ValidationException vx)
            {
                return BadRequest(vx.Result);
            }

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        private async Task<bool> PersonEntityExists(int id)
        {
            return (await _personService.GetByIdAsync(id)) != null;
        }
    }
}
