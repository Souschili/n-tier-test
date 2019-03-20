using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Services;
using Microsoft.AspNetCore.Mvc;

namespace n_tier_test.Controllers
{
    public class HomeController : Controller
    {
        // наш сервис из слоя BAL заинжектили в контролер (ну все как обычно)
        private IDataService myservice;

        public HomeController(IDataService serv)
        {
            this.myservice = serv;
        }


        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(myservice.GetAll());
        }
    }
}