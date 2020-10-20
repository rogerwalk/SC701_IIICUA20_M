using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.UI.Services;

namespace Solution.UI.Controllers
{
    public class PaisEFController : Controller
    {

        //se crea el modelo 
        public IRepositorioPaisEF repo { get; }

        //se crea un constructor

        public PaisEFController(IRepositorioPais repositorio)
        {
            repo = repositorio;
        }


        public IActionResult Index()
        {
            return View(repo.);
        }
    }
}
