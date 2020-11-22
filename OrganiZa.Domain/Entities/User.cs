using System;
using System.Collections.Generic;
using OrganiZa.Domain.Entities;

#nullable disable

namespace OrganiZa.Domain.Entities
{
    public partial class User : BaseEntity
    {
        public User()
        {
            Administradors = new HashSet<Administrador>();
            Tutors = new HashSet<Tutor>();
        }

        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Rolusuario { get; set; }
        public int IdT { get; set; }
        public int IdA { get; set; }

        public virtual ICollection<Administrador> Administradors { get; set; }
        public virtual ICollection<Tutor> Tutors { get; set; }

    }
}
