using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PasReg.Model;

namespace PasReg.Controllers
{
    [Route("api/[controller]")]
    public class StudiesController : Controller
    {
        private readonly StudyRegistry studies;

        public StudiesController(StudyRegistry studies)
        {
            this.studies = studies;
        }
        
        // GET api/studies (returns study name only)
        [HttpGet]
        public IEnumerable<StudyInfo> Get()
        {
            return studies.GetAll().Select(s => new StudyInfo {Id = s.Id, Name = s.Name});
        }
        
        // GET api/studies/{id}/groups
        [HttpGet("{id}/groups")]
        public IEnumerable<string> Get(Guid id)
        {
            return studies.GetOne(id).Groups;
        }

        public class StudyInfo
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
        }
    }
}