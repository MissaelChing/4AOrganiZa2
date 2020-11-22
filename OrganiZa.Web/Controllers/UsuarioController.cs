using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenCoolMart.Domain.DTOs;
using OrganiZa.Web.Models;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using OrganiZa.Web.Responses;
using Newtonsoft.Json;

namespace OrganiZa.Web.Controllers
{
    public class UsuarioController : Controller
    {
        HttpClient client = new HttpClient();
        public string url = "https://localhost:44374/api/Usuario/";
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
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
                return RedirectToAction("Menu");
            }
            else if (_Usuario != null && _Usuario.IdT.Equals(2))
            {
                HttpContext.Session.SetString("Id", _Usuario.Id.ToString());
                return RedirectToAction("MenuVendedor");
            }
            else if (_Usuario == null)
            {

                login.status = false;
                return View();
            }
            return View();
        }
        public IActionResult Menu()
        {
            if (HttpContext.Session.GetString("Id") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult MenuVendedor()
        {
            if (HttpContext.Session.GetString("Id") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("Id");
            return RedirectToAction("Index");
        }

    }
}
