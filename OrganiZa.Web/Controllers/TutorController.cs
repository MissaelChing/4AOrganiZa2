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
    public class TutorController : Controller
    {
        HttpClient client = new HttpClient();
        public async Task<IActionResult> Index()
        {

            if (HttpContext.Session.GetString("Id") != null)
            {
                var httpClient = new HttpClient();
                var Json = await httpClient.GetStringAsync("https://localhost:44337/api/Tutor");
                var ListProductos = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<TutorResponseDto>>>(Json);
                return View(ListProductos.Data);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

     
        public async Task<IActionResult> Details(int Id)
        {

            Id = int.Parse(HttpContext.Session.GetString("Id"));
            if (HttpContext.Session.GetString("Id") != null)
            {
                var httpClient = new HttpClient();
                var Json = await httpClient.GetStringAsync("https://localhost:44337/api/Tutor/" + Id);
                var producto = JsonConvert.DeserializeObject<ApiResponse<TutorResponseDto>>(Json);
                producto.Data.Usuario = HttpContext.Session.GetString("Usuario");


                return View(producto.Data);
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
        public IActionResult Menu(MenuTModel Menu)
        {
            Menu.id = int.Parse(HttpContext.Session.GetString("Id"));
            Menu.Rolusuario = HttpContext.Session.GetString("Rol");
            Menu.Usuario = HttpContext.Session.GetString("Usuario");

            return View(Menu);
        }
        [HttpPost]
        public async Task<IActionResult> Create(RegistroTModelcs tutorusr)
        {
            
            TutorRequestDto TutorRequestDto = tutorusr.Empleado;
            tutorusr.Empleado.Rolusuario = "Tutor";
            var Json = await client.PostAsJsonAsync("https://localhost:44337/api/tutor/", TutorRequestDto);
            var Tutor = await client.GetStringAsync("https://localhost:44337/api/tutor/");
            var Tutors = JsonConvert.DeserializeObject<ApiResponse<List<TutorResponseDto>>>(Tutor);
            UsuarioRequestDto usuarioRequestDto = tutorusr.Usuario;
            if (Json.IsSuccessStatusCode)
            {
                tutorusr.Usuario.Rolusuario = "Tutor";
                tutorusr.Usuario.IdT = Tutors.Data.Last().Id;
            }
            var Json2 = await client.PostAsJsonAsync("https://localhost:44337/api/usuario/", usuarioRequestDto);
            if (Json.IsSuccessStatusCode && Json2.IsSuccessStatusCode)
            {
                return RedirectToAction("Home", "Home");
            }
            return View(tutorusr);
        }

        public async Task<IActionResult> Update(int Id)
        {
            Id = int.Parse(HttpContext.Session.GetString("Id"));
            if (HttpContext.Session.GetString("Id") != null)
            {
                var httpClient = new HttpClient();
                var Json = await httpClient.GetStringAsync("https://localhost:44337/api/Tutor/" + Id);
                var producto = JsonConvert.DeserializeObject<ApiResponse<TutorRequestDto>>(Json);
                producto.Data.Usuario = HttpContext.Session.GetString("Usuario");


                return View(producto.Data);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        [HttpPost]
        public async Task<IActionResult> Update(int Id, TutorRequestDto tutor)
        {
           
            Id = int.Parse(HttpContext.Session.GetString("Id"));

            tutor.UpdatedBy = int.Parse(HttpContext.Session.GetString("Id"));
            tutor.Id = int.Parse(HttpContext.Session.GetString("Id"));
            tutor.Rolusuario = HttpContext.Session.GetString("Rol");
            tutor.Usuario = HttpContext.Session.GetString("Usuario");
            var putTask = await client.PutAsJsonAsync("https://localhost:44337/api/tutor/?id=" + Id, tutor);
            if (putTask.IsSuccessStatusCode)
            {
                return RedirectToAction("Details");
            }
           
            return View(tutor);
        }
      
    }
}
