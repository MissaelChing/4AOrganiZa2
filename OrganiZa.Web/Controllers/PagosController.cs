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
        string url = "https://localhost:44337/api/pago";
        public async Task<IActionResult> Comprobacion() 
        {
            ComprobacionModels models = new ComprobacionModels();
            models.id= int.Parse(HttpContext.Session.GetString("Id"));
            models.Usuario= HttpContext.Session.GetString("Rol");
            models.Rolusuario= HttpContext.Session.GetString("Usuario");
            if (HttpContext.Session.GetString("Id") != null)
            {
                var json = await client.GetStringAsync(url);
                var Pagos = JsonConvert.DeserializeObject<ApiResponse<List<PagoResponseDto>>>(json);
                models.Pagos = Pagos.Data;
                return View(models);
            }
            else

            {
                return RedirectToAction("Home", "Home");
            }
        }
        public async Task<IActionResult> Aprobacion(int id)
        {
            AprobacionModels pagoDto = new AprobacionModels();

            pagoDto.Id = int.Parse(HttpContext.Session.GetString("Id"));
            pagoDto.Usuario = HttpContext.Session.GetString("Rol");
            pagoDto.Rolusuario = HttpContext.Session.GetString("Usuario");
            if (HttpContext.Session.GetString("Id") != null)
            {
                var json = await client.GetStringAsync("https://localhost:44337/api/pago/" + id);
                var _Pago = JsonConvert.DeserializeObject<ApiResponse<PagoRequestDto>>(json);
                 pagoDto.pagos = _Pago.Data;
                return View(pagoDto);
            }
            else
            {
                return RedirectToAction("Home", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Aprobacion(int Id, AprobacionModels pagoDto)
        {
            var json = await client.GetStringAsync("https://localhost:44337/api/pago/" + Id);
            var _Pago = JsonConvert.DeserializeObject<ApiResponse<PagoRequestDto>>(json);
            pagoDto.pagos.UpdatedBy = int.Parse(HttpContext.Session.GetString("Id"));
            pagoDto.pagos.CreatedBy =  int.Parse(HttpContext.Session.GetString("Id"));
            pagoDto.pagos.Fichapago = _Pago.Data.Fichapago;
            pagoDto.pagos.Voucher = _Pago.Data.Voucher;
            pagoDto.pagos.Mespagado = _Pago.Data.Mespagado;
            pagoDto.pagos.Fecha = _Pago.Data.Fecha;
            var putTask = await client.PutAsJsonAsync("https://localhost:44337/api/pago/?id=" + Id, pagoDto.pagos);
            if (putTask.IsSuccessStatusCode)
            {
                return RedirectToAction("Home", "Home");
            }
            return View(pagoDto);
        }

        public async Task<IActionResult>  Create()
        {
            PagoModels tutor = new PagoModels();
            tutor.Id = int.Parse(HttpContext.Session.GetString("Id"));
            tutor.Rolusuario = HttpContext.Session.GetString("Rol");
            tutor.Usuario = HttpContext.Session.GetString("Usuario");
            var Tutores = await client.GetStringAsync("https://localhost:44337/api/Tutor/");
            var Tutors = JsonConvert.DeserializeObject<ApiResponse<List<TutorRequestDto>>>(Tutores);
            foreach (var m in Tutors.Data)
            {
                if (m.Id == tutor.Id)
                {
                    tutor.Alumno = m.Alumno;
                    tutor.NombreT = m.NombreT;
                    if (m.FichaPago == null)
                    {
                        tutor.FichaPago = "No tiene aun una ficha de pago asignada";

                    }
                    else
                    {
                        tutor.Tutor.FichaPago = m.FichaPago;

                    }

                    break;
                }
            }

            return View(tutor);
        }
        [HttpPost]
        public async Task<IActionResult> Create(PagoModels admin)
        {
            admin.Id = int.Parse(HttpContext.Session.GetString("Id"));
            
            var Tutores = await client.GetStringAsync("https://localhost:44337/api/Tutor/");
            var Tutors = JsonConvert.DeserializeObject<ApiResponse<List<TutorRequestDto>>>(Tutores);
            foreach( var m in Tutors.Data)
            {
                if(m.Id == admin.Id)
                {
                    admin.Alumno = m.Alumno ;
                    admin.NombreT = m.NombreT;
                    admin.FichaPago = m.FichaPago;
                    break;
                }
            }
            PagoRequestDto adminRequestDto = admin.pagos;
            using (var target = new MemoryStream())
            {
                admin.file.CopyTo(target);
       
            admin.pagos.Voucher = target.ToArray();
            }
            admin.pagos.TutorId = int.Parse(HttpContext.Session.GetString("Id"));
            admin.pagos.CreatedBy = int.Parse(HttpContext.Session.GetString("Id"));
            admin.pagos.Alumno = admin.Alumno;
            admin.pagos.NombreT = admin.NombreT;
            admin.pagos.Fichapago = admin.FichaPago;
            var Json = await client.PostAsJsonAsync("https://localhost:44337/api/pago/", adminRequestDto);
            if (Json.IsSuccessStatusCode)
            {
                return RedirectToAction("Home", "Home");
            }
            return View(admin);
        }
  
    }
}
