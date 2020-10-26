using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrganiZa.Models
{    [Table("Tutor")]

    public class TutorModels : BaseEntity
    {
        public string Rolusuario { get; set; }
        string Alumno { get; set; }
        string NombreT { get; set; }
        public int UsersId { get; set; }
        [ForeignKey("UsersId")]
        public virtual Users Users { get; set; }
    }
}
