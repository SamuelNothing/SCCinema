using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SCCinamaComum;
using SCCinamaComum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCCinemaWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly SCCinemaContext _context;
        public LoginController(SCCinemaContext context, ILogger<LoginController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(string Login, string Senha)
        {
            Usuario usuario = _context.Usuario.FirstOrDefault(x => x.Login == Login && x.Senha == Senha);
            if (usuario != null)
            {
                HttpContext.Session.SetString("Nome", usuario.Nome);
                HttpContext.Session.SetString("IDUsuario", usuario.IDUsuario.ToString());
                HttpContext.Session.SetString("Perfil", usuario.Perfil.ToString());
                return RedirectToAction("Index", "Home");
            }
            return View("Index");
        }
    }
}
