using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonManagement.Infrastructure.Localization;
using PersonManagement.Models.DTO;
using PersonManagement.Service.Abstractions;
using PersonManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonManagement.Controllers
{
    [ApiVersion("1")]
    [ApiVersion("2")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _service;
        private readonly ILogger<PersonController> _logger;

        public PersonController(IPersonService service, ILogger<PersonController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Get all persons
        /// </summary>
        [Obsolete("Deprecated")]
        [MapToApiVersion("1")]
        [HttpGet]
        public async Task<List<PersonDTO>> GetAll1()
        {
            var serviceResult = await _service.GetAllAsync();

            return serviceResult.Adapt<List<PersonDTO>>();
        }

        /// <summary>
        /// Get all persons
        /// </summary>
        [MapToApiVersion("2")]
        [HttpGet]
        public async Task<List<PersonDTO>> GetAll2()
        {
            // აქ პირველი API-სგან განსხვავებული ლოგიკა უნდა ეწეროს წესით
            
            var serviceResult = await _service.GetAllAsync();

            return serviceResult.Adapt<List<PersonDTO>>();
        }

        /// <summary>
        /// Get a specific person
        /// </summary>
        /// <param name="id">person identifier</param>
        [HttpGet("{id}", Name = "GetPerson")]
        public async Task<IActionResult> Get(int id)
        {
            var serviceResult = await _service.GetAsync(id);

            if (serviceResult == null)
                _logger.LogError("Customer Not Found");

            var response = serviceResult.Adapt<PersonDTO>();

            return Ok(response);
        }

        /// <summary>
        /// Delete a specific person
        /// </summary>
        ///  <param name="id">person identifier</param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _service.DeleteAsync(id))
                return Ok();

            return NotFound(ErrorMessages.NotFound);
        }

        /// <summary>
        /// Add a specific person
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Person
        ///     {
        ///        "FirstName":"ბექა",
        ///        "LastName":"ღვაბერიძე",
        ///        "Identifier":"0100101011",
        ///        "BirthDate":"1992-12-20",
        ///        "Age": 29,
        ///        "City":"Tbilisi",
        ///        "Gender":true
        ///     }
        ///
        /// </remarks>

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<ActionResult<PersonDTO>> Add(PersonDTO person)
        {
            var persons = await _service.GetAllAsync();
            var maxId = persons.Select(x => x.Id).Max() + 1;

            var model = person.Adapt<PersonServiceModel>();
            model.Id = maxId;
            person.Id = maxId;

            await _service.Add(model);

            return CreatedAtRoute("GetPerson", new { id = person.Id }, person);
        }
    }
}
