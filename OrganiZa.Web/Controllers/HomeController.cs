using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OrganiZa.Api.Responses;
using OrganiZa.Domain.DTOs;
using OrganiZa.Web.Models;
using OrganiZa.Web.Validacion;

namespace OrganiZa.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        HttpClient client = new HttpClient();
        public string url = "https://localhost:44337/api/usuario";
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IndexAsync(LoginModel login)
        {
            var json = await client.GetStringAsync(url);
            var Usuarios = JsonConvert.DeserializeObject<ApiResponse<List<UsuarioResponseDto>>>(json);
            var _Usuario = Usuarios.Data.FirstOrDefault(e => e.Usuario.Equals(login.Usuario) && e.Contraseña.Equals(login.Contraseña));
            if (_Usuario != null && _Usuario.IdA.Equals(1))
            {
                HttpContext.Session.SetString("Id", _Usuario.Id.ToString());
                return RedirectToAction("Home");
            }
            else if (_Usuario != null && _Usuario.IdT.Equals(2))
            {
                HttpContext.Session.SetString("Id", _Usuario.Id.ToString());
                return RedirectToAction("Home");
            }
            else if (_Usuario == null)
            {

                login.status = false;
                return View();
            }
            return View();
        }
       

    }
}
