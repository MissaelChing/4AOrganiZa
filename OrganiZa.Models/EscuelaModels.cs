using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrganiZa.Models
{
    [Table("Escuela")]
    public class EscuelaModels : BaseEntity
    {
        public string NombreE { get; set; }
        public string NombreAd { get; set; }
        public string ModoP { get; set; }
        public double Colegiatura { get; set; }
        public int IdT { get; set; }
        public int IdA { get; set; }

        //Referencia

        public List<AdministradorModels> AdministradorModels { get; set; }
        public virtual CalendarioModels CalendarioModels { get; set; }
        public virtual PagosModels PagosModels { get; set; }
    }
}
