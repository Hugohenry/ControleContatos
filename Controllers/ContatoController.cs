using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ControleContatos.Controllers
{

    public class ContatoController : Controller
    {
          public IActionResult IndexContato()
          {
            return View();
          }
           public IActionResult CriarContato()
          {
            return View();
          }
           public IActionResult EditarContato()
          {
            return View();
          }
           public IActionResult ExcluirContato()
          {
            return View();
          }


    }
}