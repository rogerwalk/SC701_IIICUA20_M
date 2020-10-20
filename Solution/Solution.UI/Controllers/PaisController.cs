using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Solution.UI.Services;

namespace Solution.UI.Controllers
{

    [Authorize]
    public class PaisController : Controller
    { 
        
        //se crea el modelo 
       public IRepositorioPais repo { get; }

        //se crea un constructor

        public PaisController(IRepositorioPais repositorio)
        {
            repo = repositorio;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {

       

           //   List<string> paises = new List<string> {"Ghana","Japon","Costa Rica","Ecuador" };

            //pasamos  la list paises al retun View para luego manejarla desde el View con @Model tambien lo podria manejar con viewbag 
            // return View(paises);

            return View(repo.ObtenerTodos());

        }
    }
}
