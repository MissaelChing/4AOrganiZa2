using System;
using System.Collections.Generic;

#nullable disable

namespace OrganiZa.Infraestructure.Entities
{
    public partial class Pago
    {
        public Pago()
        {
            Escuelas = new HashSet<Escuela>();
            Tutors = new HashSet<Tutor>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Status { get; set; }
        public string Alumno { get; set; }
        public string Fichapago { get; set; }
        public string NombreT { get; set; }
        public DateTime Fecha { get; set; }
        public double Colegiatura { get; set; }
        public string Mespagado { get; set; }
        public byte[] Voucher { get; set; }
        public int TutorId { get; set; }
        public int IdE { get; set; }
        public string Statusdepago { get; set; }
        public int? CalendarioModelsId { get; set; }

        public virtual Calendario CalendarioModels { get; set; }
        public virtual ICollection<Escuela> Escuelas { get; set; }
        public virtual ICollection<Tutor> Tutors { get; set; }
    }
}
