using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrganiZa.Models
{
    [Table("Administrador")]

    public class AdministradorModels : BaseEntity
    {
      
            public string Rolusuario { get; set; }
            public string NombreAd { get; set; }
             public int IdE { get; set; }
        //referencia 

            public virtual Users Users { get; set; }
            public List<EscuelaModels> EscuelaModels { get; set; }


    }
}
