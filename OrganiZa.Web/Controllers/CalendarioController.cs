using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrganiZa.Api.Responses;
using OrganiZa.Domain.DTOs;
using OrganiZa.Domain.Entities;
using OrganiZa.Web.Models;

namespace OrganiZa.Web.Controllers
{
    public class CalendarioController : Controller
    {
        HttpClient client = new HttpClient();
        string url = "https://localhost:44337/api/Calendario";

        public IActionResult Generar()
        {
            CalendarioModels calendarios = new CalendarioModels();
            calendarios.id = int.Parse(HttpContext.Session.GetString("Id"));
            calendarios.Rolusuario = HttpContext.Session.GetString("Rol");
            calendarios.Usuario = HttpContext.Session.GetString("Usuario");
            return View(calendarios);
        }
        [HttpPost]
        public async Task<IActionResult> Generar(CalendarioModels calendarios)
        {
            calendarios.id = int.Parse(HttpContext.Session.GetString("Id"));
            calendarios.Rolusuario = HttpContext.Session.GetString("Rol");
            calendarios.Usuario = HttpContext.Session.GetString("Usuario");
            CalendarioRequestDto calendarioRequestDto = calendarios.Calendario;
            
            calendarios.Calendario.IdA = int.Parse(HttpContext.Session.GetString("Id"));
            var Json = await client.PostAsJsonAsync("https://localhost:44337/api/Calendario/", calendarioRequestDto);
            var Es = await client.GetStringAsync("https://localhost:44337/api/escuela/");
            var Escue = JsonConvert.DeserializeObject<ApiResponse<List<EscuelaResponseDto>>>(Es);
            foreach (var m in Escue.Data)
            {

                calendarios.Escuelas = Escue.Data.ToList();

                break;

            }
            if (Json.IsSuccessStatusCode)
            {
                return RedirectToAction("Home", "Home");
            }
            return View(calendarios);
        }
    }
}
