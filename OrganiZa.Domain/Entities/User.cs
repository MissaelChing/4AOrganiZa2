using System;
using System.Collections.Generic;

#nullable disable

namespace OrganiZa.Infraestructure.Entities
{
    public partial class User
    {
        public User()
        {
            Administradors = new HashSet<Administrador>();
            Tutors = new HashSet<Tutor>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Status { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Rolusuario { get; set; }
        public int IdT { get; set; }
        public int IdA { get; set; }

        public virtual ICollection<Administrador> Administradors { get; set; }
        public virtual ICollection<Tutor> Tutors { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
