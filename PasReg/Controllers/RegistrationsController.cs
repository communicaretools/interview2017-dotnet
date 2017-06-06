using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PasReg.Model;

namespace PasReg.Controllers
{
    [Route("api/[controller]")]
    public class RegistrationsController : Controller
    {
        private readonly ILogger<RegistrationsController> logger;
        private readonly RegistrationRegistry registrations;

        public RegistrationsController(ILogger<RegistrationsController> logger, RegistrationRegistry registrations)
        {
            this.logger = logger;
            this.registrations = registrations;
        }
        
        // GET api/registrations
        [HttpGet]
        public IEnumerable<Registration> Get()
        {
            logger.LogInformation("Get all registrations");
            return registrations.GetAll();
        }
        
        // GET api/registrations/{id}
        [HttpGet("{id}")]
        public Registration Get(Guid id)
        {
            logger.LogInformation("Get registration with id={0}", id);
            return registrations.GetOne(id);
        }

        // POST api/registrations
        [HttpPost]
        public void Post([FromBody]Registration registration)
        {
            if (registration == null)
            {
                logger.LogError("Registration was not provided on the correct format to POST api/registrations");
                return;
            }
            
            logger.LogInformation("Post new registration for patient {0}", registration?.Name);
            registrations.Save(registration);
        }

        // DELETE api/registrations/{id}
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            logger.LogInformation("Delete registration with id={0}", id);
            registrations.Delete(id);
        }
    }
}