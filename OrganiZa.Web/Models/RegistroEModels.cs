using OrganiZa.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganiZa.Web.Models
{
    public class RegistroEModels
    {
        public EscuelaRequestDto  Escuela { get; set; }
        public Modopago pago { get; set; }

        public enum Modopago
        {
           Mensual,
           Bimestral,
           Cuatrimestral,
          Semestral,
            Anual
        }
    }
}
