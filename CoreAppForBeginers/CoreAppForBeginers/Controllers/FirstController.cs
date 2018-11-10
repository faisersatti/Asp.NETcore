using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace CoreAppForBeginers.Controllers
{
    public class FirstController : Controller
    {
        private readonly IConfiguration configuration;
        public FirstController(IConfiguration config)
        {
            configuration = config;
        }
        public IActionResult Index()
        {
            string con = configuration.GetConnectionString("DefaultConnection");
            return View();
        }
    }
}