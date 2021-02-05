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
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Generar(CalendarioModels calendarios)
        {
            CalendarioRequestDto calendarioRequestDto = calendarios.Calendario;
            calendarios.id = int.Parse(HttpContext.Session.GetString("Id"));
            calendarios.Calendario.IdA = int.Parse(HttpContext.Session.GetString("Id"));
            var Json = await client.PostAsJsonAsync("https://localhost:44337/api/Calendario/", calendarioRequestDto);
            if (Json.IsSuccessStatusCode)
            {
                return RedirectToAction("Home", "Home");
            }
            return View(calendarios);
        }
    }
}
