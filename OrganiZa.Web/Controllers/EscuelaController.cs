using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrganiZa.Api.Responses;
using OrganiZa.Domain.DTOs;
using OrganiZa.Web.Models;

namespace OrganiZa.Web.Controllers
{
    public class EscuelaController : Controller
    {
        HttpClient client = new HttpClient();
        public string url  = "https://localhost:44337/api/Escuela";
        public async Task<IActionResult> Details(int Id)
        {
            Id = int.Parse(HttpContext.Session.GetString("Id"));
            if (HttpContext.Session.GetString("Id") != null)
            {
                var httpClient = new HttpClient();
                var json1 = await client.GetStringAsync(url);
                var Usuarios = JsonConvert.DeserializeObject<ApiResponse<List<EscuelaResponseDto>>>(json1);
                var _Usuario = Usuarios.Data.FirstOrDefault(e => e.IdA.Equals(Id));
                var Json = await httpClient.GetStringAsync("https://localhost:44337/api/Escuela/" + _Usuario.Id);
                var Escuela = JsonConvert.DeserializeObject<ApiResponse<EscuelaResponseDto>>(Json);
                return View(Escuela.Data);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RegistroEModels Escuelas)
        {
            EscuelaRequestDto escuelaRequestDto = Escuelas.Escuela;
            Escuelas.Escuela.IdA = int.Parse(HttpContext.Session.GetString("Id"));
            Escuelas.Escuela.CreatedBy = int.Parse(HttpContext.Session.GetString("Id"));
            var Json = await client.PostAsJsonAsync("https://localhost:44337/api/Escuela/", escuelaRequestDto);
          
            if (Json.IsSuccessStatusCode)
            {
                return RedirectToAction("Home/Home");
            }
            return View(Escuelas);
        }

        public async Task<IActionResult> Update(int Id)
        {
            Id = int.Parse(HttpContext.Session.GetString("Id"));
            if (HttpContext.Session.GetString("Id") != null)
            {
                var httpClient = new HttpClient();
                var Json = await httpClient.GetStringAsync("https://localhost:44337/api/Escuela/" + Id);
                var Escuela = JsonConvert.DeserializeObject<ApiResponse<EscuelaRequestDto>>(Json);
                Escuela.Data.Usuario = HttpContext.Session.GetString("Usuario");


                return View(Escuela.Data);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        [HttpPost]
        public async Task<IActionResult> Update(int Id, AdministradorRequestDto tutor)
        {

            Id = int.Parse(HttpContext.Session.GetString("Id"));

            tutor.UpdatedBy = int.Parse(HttpContext.Session.GetString("Id"));
            tutor.Id = int.Parse(HttpContext.Session.GetString("Id"));
            tutor.Rolusuario = HttpContext.Session.GetString("Rol");
            tutor.Usuario = HttpContext.Session.GetString("Usuario");
            var putTask = await client.PutAsJsonAsync("https://localhost:44337/api/Administrador/?id=" + Id, tutor);
            if (putTask.IsSuccessStatusCode)
            {
                return RedirectToAction("Details");
            }

            return View(tutor);
        }
    }
}
