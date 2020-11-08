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
        public int IdE { get; set; }

        //Referencias
        public List<EscuelaModels> EscuelaModels { get; set; }
    }
}
