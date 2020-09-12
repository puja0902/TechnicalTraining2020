using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCwithWillis.Models;
using PatientLibrary;

namespace MVCwithWillis.Controllers
{
    public class HomeController : Controller
    {
        int i = 0;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger 
            , IPatient p
            ,IPatient p1)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //byte[] y = null;

            //PatientWithAddressCheck x1 = new PatientWithAddressCheck();
            //// security
            //if (HttpContext.Session.TryGetValue("valueofi",out y)) // 10 seconds
            //{
            //    i = (int)HttpContext.Session.GetInt32("valueofi");
            //}
            //i++;
            //HttpContext.Session.SetInt32("valueofi",  i);
            
            
            
            return View();
        }

        public IActionResult Privacy()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
