using System;
using Microsoft.AspNetCore.Mvc;
using TechTest.Controllers.Models;
using TechTest.Repositories;
using TechTest.Repositories.Models;

namespace TechTest.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        public PeopleController(IPersonRepository personRepository)
        {
            this.PersonRepository = personRepository;
        }

        private IPersonRepository PersonRepository { get; }

        [HttpGet]
        public IActionResult GetAll()
        {
            // the repository is designed to return an empty array if there are no people
            var people = this.PersonRepository.GetAll();

            return this.Ok(people);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = this.PersonRepository.Get(id);

            if (person == null)
            {
                return this.NotFound();
            }

            return this.Ok(person);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, PersonUpdate personUpdate)
        {
            var existing = this.PersonRepository.Get(id);

            if (existing == null)
            {
                return this.NotFound();
            }

            existing.FirstName = personUpdate.FirstName;
            existing.LastName = personUpdate.LastName;
            existing.Authorised = personUpdate.Authorised;
            existing.Enabled = personUpdate.Enabled;
            existing.Colours = personUpdate.Colours;

            var updated = this.PersonRepository.Update(existing);

            return this.Ok(updated);
        }
    }
}