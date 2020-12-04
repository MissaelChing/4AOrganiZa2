﻿using System.Collections.Generic;
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
using OrganiZa.Domain.Entities;
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
        public HomeModel user = new HomeModel();
        public IActionResult Home()
        {

            if (HttpContext.Session.GetString("Id") == null)
            {
                user.id = 0;
            }
            else if(HttpContext.Session.GetString("Rol")=="Tutor")
            {
                user.id = int.Parse(HttpContext.Session.GetString("Id"));
                user.Rolusuario = HttpContext.Session.GetString("Rol");
                user.Usuario = HttpContext.Session.GetString("Usuario");
            }
            else if (HttpContext.Session.GetString("Rol") == "Administrador")
            {
                user.id = int.Parse(HttpContext.Session.GetString("Id"));
                user.Rolusuario = HttpContext.Session.GetString("Rol");
                user.Usuario = HttpContext.Session.GetString("Usuario");
            }
            return View(user);

        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("Id");
            HttpContext.Session.Remove("Rol");
            HttpContext.Session.Remove("Usuario");
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(LoginModel login)
        {
            var json = await client.GetStringAsync(url);
            var Usuarios = JsonConvert.DeserializeObject<ApiResponse<List<UsuarioResponseDto>>>(json);
            var _Usuario = Usuarios.Data.FirstOrDefault(e => e.Usuario.Equals(login.Usuario) && e.Contraseña.Equals(login.Contraseña));
            if (_Usuario != null && _Usuario.Rolusuario =="Tutor")
            {
                HttpContext.Session.SetString("Id", _Usuario.IdT.ToString());
                HttpContext.Session.SetString("Usuario", _Usuario.Usuario.ToString());
                HttpContext.Session.SetString("Rol", _Usuario.Rolusuario.ToString());


                return Redirect("Home/Home");
            }
            else if (_Usuario != null && _Usuario.Rolusuario =="Administrador")
            {
                HttpContext.Session.SetString("Id", _Usuario.IdA.ToString());
                HttpContext.Session.SetString("Usuario", _Usuario.Usuario.ToString());
                HttpContext.Session.SetString("Rol", _Usuario.Rolusuario.ToString());
                return Redirect("Home/Home");
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
