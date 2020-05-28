using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Models.Contexto;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Contexto _contexto;
        public UsuarioController(Contexto contexto) {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
