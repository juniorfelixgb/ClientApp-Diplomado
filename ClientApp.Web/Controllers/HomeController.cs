using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClientApp.Web.Models;
using ClientApp.DataAccess.Contract;
using ClientApp.Models.Entities;

namespace ClientApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClientAccess _clientAccess;

        public HomeController(ILogger<HomeController> logger,
                              IClientAccess clientAccess)
        {
            _logger = logger;
            _clientAccess = clientAccess;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<ActionResult<List<Client>>> Client()
        {
            var client = await _clientAccess.ReadData();
            return View(client);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
