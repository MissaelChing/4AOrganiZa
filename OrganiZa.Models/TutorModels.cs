using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrganiZa.Models
{
    [Table("Tutor")]

    public class TutorModels : BaseEntity
    {
        public string Rolusuario { get; set; }
        public string Alumno { get; set; }
        public string NombreT { get; set; }
        public double Telefono { get; set; }
        public string NombreE { get; set; }
        public string FichaPago { get; set; }
        public int IdE { get; set; }

        public virtual Users Users { get; set; }
        public virtual EscuelaModels EscuelaModels { get; set; }
        public virtual CalendarioModels CalendarioModels { get; set; }


    }


}
