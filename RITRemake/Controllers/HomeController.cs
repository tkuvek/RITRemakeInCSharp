using System;
using System.Collections.Generic;
using System.Diagnostics;
using RITRemake.Services;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RITRemake.Models;

namespace RITRemake.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var data = await ISTClient.GetAboutAsync();
            return View(data);
        }

        public async Task<IActionResult> DegreesAsync()
        {
            var data = await ISTClient.GetISTAsync("/api/degrees");
            return View(data);
        }

        public async Task<IActionResult> FacultyAsync()
        {
            var data = await ISTClient.GetISTAsync("/api/people/faculty");
            return View(data);
        }


        public async Task<IActionResult> EmploymentAsync()
        {
            var data = await ISTClient.GetISTTableAsync("/api/employment/");
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
