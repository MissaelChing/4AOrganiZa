using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrganiZa.Models
{
    [Table("Calendario")]
    public class CalendarioModels: BaseEntity
    {
        public DateTime fecha { get; set; }
        public string ModoP { get; set; }
        public double Colegiatura { get; set; }
        public string statusdepago { get; set; }
        public string Alumno { get; set; }
        public int IdE { get; set; }
        public int IdP { get; set; }
        public int IdT { get; set; }

        //Referencias
        public List<EscuelaModels> EscuelaModels { get; set; }
        public List<PagosModels> PagosModels { get; set; }
        public List<TutorModels> TutorModels { get; set; }
    }
}
