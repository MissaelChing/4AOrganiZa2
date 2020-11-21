using System;
using System.Collections.Generic;

#nullable disable

namespace OrganiZa.Infraestructure.Entities
{
    public partial class Administrador
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Status { get; set; }
        public string Rolusuario { get; set; }
        public string NombreAd { get; set; }
        public int? UsersId { get; set; }
        public int? EscuelaModelsId { get; set; }
        public int? CalendarioModelsId { get; set; }

        public virtual Calendario CalendarioModels { get; set; }
        public virtual Escuela EscuelaModels { get; set; }
        public virtual User Users { get; set; }
    }
}
