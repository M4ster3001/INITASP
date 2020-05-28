using CRUD.Models.Contexto;
using CRUD.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CRUD.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly Contexto _contexto;
        public UsuariosController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {

            var lista = _contexto.Usuario.ToList();

            return View(lista);

        }

        [HttpGet]
        public IActionResult Create()
        {

            var usuario = new Usuario();
            CarregarTipoUsuario();

            return View(usuario);

        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                _contexto.Usuario.Add(usuario);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            CarregarTipoUsuario();
            return View(usuario);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var usuario = _contexto.Usuario.Find(id);

            CarregarTipoUsuario();
            if (usuario != null)
            {
                return View(usuario);
            }

            return View("Usuário não encontrado");
        }

        [HttpPost]
        public IActionResult Edit(Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                _contexto.Usuario.Update(usuario);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            CarregarTipoUsuario();
            return View(usuario);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var usuario = _contexto.Usuario.Find(id);

            CarregarTipoUsuario();
            return View(usuario);

        }

        [HttpPost]
        public IActionResult Delete(Usuario _usuario)
        {

            var usuario = _contexto.Usuario.Find(_usuario.id);
            if (usuario != null)
            {
                _contexto.Usuario.Remove(usuario);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {

            var usuario = _contexto.Usuario.Find(id);

            CarregarTipoUsuario();
            return View(usuario);
        }

        public void CarregarTipoUsuario()
        {

            var ItensTipoUsuario = new List<SelectListItem>
            {
                new SelectListItem{ Value="1", Text="Administrador" },
                new SelectListItem{ Value="2", Text="Técnico" },
                new SelectListItem{ Value="3", Text="Normal" },
            };

            ViewBag.TiposUsuario = ItensTipoUsuario;

        }
    }
}
