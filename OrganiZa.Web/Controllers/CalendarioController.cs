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

        public async Task<IActionResult> Generar()
        {
            CalendarioModels calendarios = new CalendarioModels();
            calendarios.id = int.Parse(HttpContext.Session.GetString("Id"));
            calendarios.Rolusuario = HttpContext.Session.GetString("Rol");
            calendarios.Usuario = HttpContext.Session.GetString("Usuario");
            var Es = await client.GetStringAsync("https://localhost:44337/api/escuela");
            var pag = JsonConvert.DeserializeObject<ApiResponse<List<EscuelaResponseDto>>>(Es);
            foreach (var m in pag.Data)
            {
                if (m.IdA == calendarios.id)
                {
                    calendarios.Escuelas = m;

                    break;
                }


            }

            return View(calendarios);
        }
        [HttpPost]
        public async Task<IActionResult> Generar(CalendarioModels calendarios)
        {
            calendarios.id = int.Parse(HttpContext.Session.GetString("Id"));
            calendarios.Rolusuario = HttpContext.Session.GetString("Rol");
            calendarios.Usuario = HttpContext.Session.GetString("Usuario");
            var Es = await client.GetStringAsync("https://localhost:44337/api/escuela");
            var pag = JsonConvert.DeserializeObject<ApiResponse<List<EscuelaResponseDto>>>(Es);
            foreach (var m in pag.Data)
            {
                if (m.IdA == calendarios.id)
                {
                    calendarios.Escuelas = m;

                    break;
                }


            }
            CalendarioRequestDto calendarioRequestDto = calendarios.Calendario;
            calendarioRequestDto.Colegiatura = calendarios.Escuelas.Colegiatura;
            calendarioRequestDto.IdA = calendarios.Escuelas.IdA;
            calendarioRequestDto.ModoP = calendarios.Escuelas.ModoP;
            calendarioRequestDto.IdE = calendarios.Escuelas.Id;
            var Json = await client.PostAsJsonAsync("https://localhost:44337/api/Calendario/", calendarioRequestDto);
            
            
            
            return View(calendarios);
        }
        public async Task<IActionResult> CTutor(int Id)
        {
            CTutorModels calendarios = new CTutorModels();
            calendarios.id = int.Parse(HttpContext.Session.GetString("Id"));
            calendarios.Rolusuario = HttpContext.Session.GetString("Rol");
            calendarios.Usuario = HttpContext.Session.GetString("Usuario");
            var Es = await client.GetStringAsync("https://localhost:44337/api/escuela");
            var pag = JsonConvert.DeserializeObject<ApiResponse<List<EscuelaResponseDto>>>(Es);
            var calen = await client.GetStringAsync("https://localhost:44337/api/Calendario");
            var cal = JsonConvert.DeserializeObject<ApiResponse<List<CalendarioReponseDto>>>(calen);
            var Tutores = await client.GetStringAsync("https://localhost:44337/api/Tutor");
            var Tutors = JsonConvert.DeserializeObject<ApiResponse<List<TutorResponseDto>>>(Tutores);
            foreach (var m in Tutors.Data)
            {

                if (m.Id == calendarios.id)
                {
                    calendarios.Tutores = m;

                    break;
                }
               

            }
            foreach (var m in pag.Data)
            {

                if (m.Id == calendarios.Tutores.IdE)
                {
                    calendarios.Escuela = m;

                    break;
                }
                

            }
            foreach (var m in cal.Data)
            {

                calendarios.calendarios = cal.Data.Where(x => x.IdE == calendarios.Tutores.IdE).ToList();

                break;

            }
            return View(calendarios);
        }
    }
}