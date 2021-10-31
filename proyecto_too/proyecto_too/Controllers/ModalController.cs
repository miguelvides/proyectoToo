using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_too.Controllers
{
    public class ModalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Error() 
        {

            return View();
        }

    }
}
