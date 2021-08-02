using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Day_39.Models.DTO;
using PersonManagement.Service.Abstractions;
using PersonManagement.Service.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System;

namespace Day_39.Controllers
{
    [Route("[controller]")]
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

        [HttpGet]
        public async Task<List<PersonDTO>> GetAll()
        {
            var serviceResult = await _service.GetAllAsync();
            return serviceResult.Adapt<List<PersonDTO>>();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var serviceResult = await _service.GetAsync(id);

            var response = serviceResult.Adapt<PersonDTO>();

            return Ok(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _service.DeleteAsync(id))
                return Ok();

            _logger.LogError($"Person with id: {id} not found");
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PersonDTO person)
        {
            var persons = await _service.GetAllAsync();
            var maxId = persons.Select(x => x.Id).Max() + 1;

            var model = person.Adapt<PersonServiceModel>();
            model.Id = maxId;

            await _service.Add(model);

            return Ok();
        }
    }
}
