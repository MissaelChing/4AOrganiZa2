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
    public class PagosController : Controller
    {
        HttpClient client = new HttpClient();

        public IActionResult Create()
        {
            PagoModels tutor = new PagoModels();
            tutor.Id = int.Parse(HttpContext.Session.GetString("Id"));
            tutor.Rolusuario = HttpContext.Session.GetString("Rol");
            tutor.Usuario = HttpContext.Session.GetString("Usuario");
            return View(tutor);
        }
        [HttpPost]
        public async Task<IActionResult> Create(PagoModels admin)
        {

            PagoRequestDto adminRequestDto = admin.pagos;
            
            var Tutor = await client.GetStringAsync("https://localhost:44337/api/Tutor/");
            var Tutors = JsonConvert.DeserializeObject<ApiResponse<List<TutorRequestDto>>>(Tutor);
            var _Usuario = Tutors.Data.FirstOrDefault(e => e.Usuario.Equals(int.Parse(HttpContext.Session.GetString("Id"))));
            if (_Usuario.Id == int.Parse(HttpContext.Session.GetString("Id")))
            {
                TutorRequestDto tutorRequestDto = admin.Tutor;
                admin.Tutor = _Usuario;
            }
            using (var target = new MemoryStream())
            {
                admin.file.CopyTo(target);
       
            admin.pagos.Voucher = target.ToArray();
            }
            admin.pagos.TutorId = int.Parse(HttpContext.Session.GetString("Id"));
            admin.pagos.CreatedBy = int.Parse(HttpContext.Session.GetString("Id"));
            var Json = await client.PostAsJsonAsync("https://localhost:44337/api/pagos/", adminRequestDto);
            if (Json.IsSuccessStatusCode)
            {
                return RedirectToAction("Home/Home");
            }
            return View(admin);
        }
  
    }
}
