using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HospitalRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCwithWillis.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [EnableCors("MyCorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    
    public class PatientApiController : ControllerBase
    {
        private HospitalDbContext _hospitalDbContext = null;
        public PatientApiController(HospitalDbContext _hosdb)
        {
            _hospitalDbContext = _hosdb;
        }

        
        // GET: api/<PatientApiController>
        [HttpGet]
        public IActionResult Get()
        { 
            List<Patient> list = _hospitalDbContext.patients
                      .Include(pat => pat.problems)
                      .ThenInclude(p => p.treatments)
                      .ToList<Patient>();
            return Ok(list);
        }

        // GET api/<PatientApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PatientApiController>
        [HttpPost]
        public IActionResult Post([FromBody] List<PatientDTO> objDto)
        {

            foreach (var item in objDto)
            {
                Patient obj = new Patient();

                obj.id = item.id;
                obj.name = item.name;
                obj.address = item.address;
                obj.email = item.email;


                var context = new ValidationContext(obj, null, null);
                List<ValidationResult> errresult = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(obj, context, errresult, true);

                if (isValid)
                {

                    _hospitalDbContext.patients.Add(obj);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, errresult);
                }
            }

            _hospitalDbContext.SaveChanges();

            List<Patient> pats = _hospitalDbContext.patients
                .Include(pat => pat.problems)
                .ThenInclude(p => p.treatments)
                .ToList<Patient>();

            return Ok(pats);

            
        }

        // PUT api/<PatientApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PatientApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
