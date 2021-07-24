using Day_36.Abstraction;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_36.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private IDbProvider<Company> _provider;
        public CompanyController(IDbProvider<Company> provider)
        {
            _provider = provider;
        }

        [HttpGet]
        public List<Company> Index()
        {
            return _provider.GetAll();
        }

        [HttpPost]
        public string AddCompany([FromQuery] string name, [FromQuery] string domain)
        {
            _provider.Add(new Company(name, domain));
            return "Company created";
        }

        [HttpGet]
        [Route("{id}")]
        public Company GetCompany(int id)
        {
            return _provider.GetElement(id);
        }

        [HttpPut]
        [Route("{id}")]
        public string UpdateCompany(int id, [FromQuery] string name, [FromQuery] string domain)
        {
            _provider.UpdateElement(id, new Company(name, domain));
            return "Company updated";
        }

        [HttpDelete]
        [Route("{id}")]
        public string DeleteCompany(int id)
        {
            _provider.DeleteElement(id);
            return "Company deleted";
        }
    }
}
