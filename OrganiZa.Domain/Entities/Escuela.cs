using System;
using System.Collections.Generic;

#nullable disable

namespace OrganiZa.Infraestructure.Entities
{
    public partial class Escuela
    {
        public Escuela()
        {
            Administradors = new HashSet<Administrador>();
            Tutors = new HashSet<Tutor>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Status { get; set; }
        public string NombreE { get; set; }
        public string NombreAd { get; set; }
        public string ModoP { get; set; }
        public int Nreferencia { get; set; }
        public double Colegiatura { get; set; }
        public int IdA { get; set; }
        public int? CalendarioModelsId { get; set; }
        public int? PagosModelsId { get; set; }

        public virtual Calendario CalendarioModels { get; set; }
        public virtual Pago PagosModels { get; set; }
        public virtual ICollection<Administrador> Administradors { get; set; }
        public virtual ICollection<Tutor> Tutors { get; set; }
    }
}
