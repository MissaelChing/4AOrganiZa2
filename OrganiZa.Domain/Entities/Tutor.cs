using System;
using System.Collections.Generic;

#nullable disable

namespace OrganiZa.Infraestructure.Entities
{
    public partial class Tutor
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Status { get; set; }
        public string Rolusuario { get; set; }
        public string Alumno { get; set; }
        public string NombreT { get; set; }
        public double Telefono { get; set; }
        public string NombreE { get; set; }
        public string FichaPago { get; set; }
        public int IdE { get; set; }
        public int? UsersId { get; set; }
        public int? EscuelaModelsId { get; set; }
        public int? CalendarioModelsId { get; set; }
        public int? PagosModelsId { get; set; }

        public virtual Calendario CalendarioModels { get; set; }
        public virtual Escuela EscuelaModels { get; set; }
        public virtual Pago PagosModels { get; set; }
        public virtual User Users { get; set; }
    }
}
