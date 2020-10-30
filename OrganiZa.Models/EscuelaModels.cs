using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrganiZa.Models
{
    [Table("Escuela")]
    public class EscuelaModels:BaseEntity
    {
        public string NombreE { get; set; }
        public string ModoP { get; set; }
    }
}
