using System;
using System.Collections.Generic;

#nullable disable

namespace OrganiZa.Infraestructure.Entities
{
    public partial class Calendario
    {
        public Calendario()
        {
            Administradors = new HashSet<Administrador>();
            Escuelas = new HashSet<Escuela>();
            Pagos = new HashSet<Pago>();
            Tutors = new HashSet<Tutor>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Status { get; set; }
        public string MesPago { get; set; }
        public string ModoP { get; set; }
        public double Colegiatura { get; set; }
        public string Statusdepago { get; set; }
        public string Alumno { get; set; }
        public int IdE { get; set; }
        public int IdP { get; set; }
        public int IdT { get; set; }
        public int IdA { get; set; }

        public virtual ICollection<Administrador> Administradors { get; set; }
        public virtual ICollection<Escuela> Escuelas { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
        public virtual ICollection<Tutor> Tutors { get; set; }
    }
}
