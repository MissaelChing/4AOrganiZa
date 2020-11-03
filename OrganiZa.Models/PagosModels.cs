using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrganiZa.Models
{
    public class PagosModels : BaseEntity
    {
        public string Alumno { get; set; }
        public string Fichapago { get; set; }
        public string NombreT { get; set; }
        public DateTime Fecha { get; set; }
        public string Mespagado { get; set; }
        public byte[] voucher { get; set; }
        public int TutorId { get; set; }
        public List<TutorModels> TutorModels { get; set; }

    }
}
