using System;
using System.Collections.Generic;
using System.Text;

namespace OrganiZa.Domain.DTOs
{
    public class EscuelaRequestDto
    {
        public string NombreE { get; set; }
        public string NombreAd { get; set; }
        public string ModoP { get; set; }
        public int Nreferencia { get; set; }
        public double Colegiatura { get; set; }
        public int IdA { get; set; }
        public int? CalendarioModelsId { get; set; }
        public int? PagosModelsId { get; set; }

        public bool Status { get; set; }
        public DateTime CreateAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? UpdatedBy { get; set; }

    }
}
