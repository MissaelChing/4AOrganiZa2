using Microsoft.AspNetCore.Http;
using OrganiZa.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganiZa.Web.Models
{
    public class PagoModels
    {
        public PagoRequestDto pagos { get; set; }
        public TutorRequestDto Tutor { get; set; }
        public int Id { get; set; }
        public string Rolusuario { get; set; }
        public string Usuario { get; set; }
        public IFormFile file { get; set; }

    }
}
