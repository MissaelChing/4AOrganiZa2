using OrganiZa.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganiZa.Web.Models
{
    public class CalendarioModels
    {
        public CalendarioRequestDto Calendario { get; set; }
        public int id { get; set; }
        public EscuelaResponseDto Escuela { get; set; }

    }
}
