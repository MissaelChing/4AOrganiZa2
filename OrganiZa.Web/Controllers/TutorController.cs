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

        public bool status = true;
        HttpClient client = new HttpClient();
        public async Task<IActionResult> Index()
        {
            //https://localhost:44315/api/Producto

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
            if (HttpContext.Session.GetString("Id") != null)
            {
                var httpClient = new HttpClient();
                var Json = await httpClient.GetStringAsync("https://localhost:44315/api/Producto/" + Id);
                var producto = JsonConvert.DeserializeObject<ApiResponse<TutorResponseDto>>(Json);
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
        [HttpPost]
        public async Task<IActionResult> Create(RegistroTModelcs empleadousr)
        {
            UsuarioRequestDto usuarioRequestDto = empleadousr.Usuario;
            empleadousr.Usuario.Rolusuario = "Tutor";
            TutorRequestDto empleadoRequestDto = empleadousr.Empleado;
            empleadousr.Empleado.Rolusuario = "Tutor";
            var Tutors = await client.GetStringAsync("https://localhost:44337/api/tutor/");
            var Tutor = JsonConvert.DeserializeObject<ApiResponse<List<TutorResponseDto>>>(Tutors);
            var Json = await client.PostAsJsonAsync("https://localhost:44337/api/tutor/", empleadoRequestDto);
            empleadousr.Usuario.Id = Tutor.Data.Last().Id;
            var Json2 = await client.PostAsJsonAsync("https://localhost:44337/api/usuario/", usuarioRequestDto);
            if (Json.IsSuccessStatusCode && Json2.IsSuccessStatusCode)
            {
                return Redirect("Home/Index");
            }
            return View(empleadousr);
        }

        public async Task<IActionResult> Update(int Id)
        {
            if (HttpContext.Session.GetString("Id") != null)
            {
                var httpClient = new HttpClient();
                var Json = await httpClient.GetStringAsync("https://localhost:44315/api/Producto/" + Id);
                var producto = JsonConvert.DeserializeObject<ApiResponse<TutorRequestDto>>(Json);
                return View(producto.Data);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        [HttpPost]
        public IActionResult Update(int Id, TutorRequestDto productoDto)
        {
            var httpClient = new HttpClient();
            productoDto.UpdatedBy = Int32.Parse(HttpContext.Session.GetString("Id"));
            httpClient.BaseAddress = new Uri("https://localhost:44315/api/Producto/");
            //TODO: obtener id del usuario que inicio sesion con int.Parse(HttpContext.Session.GetString("Id")) e integrar UpdatedBy 
            var putTask = httpClient.PutAsJsonAsync<TutorRequestDto>("?id=" + Id, productoDto);
            putTask.Wait();

            var result = putTask.Result;
            if (result.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");
            }
            return View(productoDto);
        }
    }
}
