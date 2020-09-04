using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HospitalRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MVCwithWillis.Models;
using PatientLibrary;

namespace MVCwithWillis.Controllers
{
    public class PatientController : Controller
    {

        private HospitalDbContext _hospitalDbContext = null;
       
        //static List<Patient> patients = new List<Patient>();
        //static PatientAddViewModel patientAddViewModel = new PatientAddViewModel();
        // static ProblemAddViewModel problemAddViewModel = new ProblemAddViewModel();
       
        public PatientController( IPatient p, HospitalDbContext _hosdb)
        {

            _hospitalDbContext = _hosdb;

            //if(patientAddViewModel.allPatients is null) { 
            //patientAddViewModel.allPatients = new List<Patient>();
            //    }
            
            
        }
       
        public IActionResult Add() // Load the UI
        {

            return View("PatientAddUI");
            
            //return View("PatientAdd" , patientAddViewModel ); // <---- here will be the problem
        }

        //[HttpPost]
        //public IActionResult Submit(Patient obj)
        //{
        //    var context = new ValidationContext(obj, null, null);
        //    List<ValidationResult> errresult = new List<ValidationResult>();
        //    bool isValid = Validator.TryValidateObject(obj, context, errresult, true);

        //    if (isValid)
        //    {

        //        _hospitalDbContext.patients.Add(obj);
        //        _hospitalDbContext.SaveChanges();

        //        List<Patient> pats = _hospitalDbContext.patients.ToList<Patient>();
        //        return Json(pats);
        //    }
        //    else
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, errresult);
        //    }


        //}

        //[HttpPost]
        //public IActionResult AddPatient(Patient obj) // When button is clicked
        //{
        //    //Patient obj = new Patient();
        //    // obj.name = Request.Form["txtname"];
        //    // obj.address = Request.Form["txtaddress"];
        //    var context = new ValidationContext(obj, null, null);
        //    List<ValidationResult> errresult = new List<ValidationResult>();
        //    bool isValid = Validator.TryValidateObject(obj, context, errresult, true);

        //    if (isValid)
        //    {
        //        if (patientaddviewmodel.currentpatient is null)
        //        {
        //            patientaddviewmodel.currentpatient = obj;
        //        }

        //    }
        //    else
        //    {
        //        patientaddviewmodel.errors = errresult;
        //        viewbag.pat = obj;

        //    }

        //    return View("PatientAdd", patientAddViewModel);
        //}
        //[HttpPost]
        //public IActionResult AddProblems(PatientProblem obj) // When button is clicked
        //{

        //        patientAddViewModel.currentProblem = obj;

        //    // patientAddViewModel.currentProblem = obj;
        //    //patientAddViewModel.patientProblems.Add(obj);
        //    //patientAddViewModel.currentPatient.problems.Add(obj);
        //    return View("PatientAdd", patientAddViewModel);
        //}

        //[HttpPost]
        //public IActionResult AddTreatments(Treatment obj)
        //{
        //    patientAddViewModel.currentProblem.treatments.Add(obj);

        //    return View("PatientAdd", patientAddViewModel);
        //}

        //public IActionResult AddToProblems()
        //{
        //    patientAddViewModel.currentPatient.problems.Add(patientAddViewModel.currentProblem);
        //    return View("PatientAdd", patientAddViewModel);
        //}
        //public IActionResult AddFinal()
        //{
        //    patientAddViewModel.allPatients.Add(patientAddViewModel.currentPatient);
        //    patientAddViewModel.currentPatient = null;

        //    //HospitalDbContext dbcontext = new HospitalDbContext();

        //    //creates the table
        //    //checks whether database is created
        //    //should be in startup or not be part of the code
        //    _hospitalDbContext.Database.EnsureCreated();

        //    foreach (var item in patientAddViewModel.allPatients)
        //    {
        //        _hospitalDbContext.patients.Add(item);//in memory
        //    }
        //    _hospitalDbContext.SaveChanges();//physical memory


        //    return View("PatientAdd", patientAddViewModel);
        //}

        //public IActionResult Update(Patient p)
        //{
        //    var newPatient = patientAddViewModel.allPatients.Where(p => p.name.Equals(patientAddViewModel.currentPatient.name)).FirstOrDefault();
        //    patientAddViewModel.allPatients.Remove(newPatient);
        //    patientAddViewModel.allPatients.Add(p);

        //    return View();
        //}
        public IActionResult Delete()
        {
            return View();
        }
    }
}