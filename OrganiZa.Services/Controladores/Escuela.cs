using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrganiZa.Services.Controladores
{
    public class Escuela : SQLRepository<EscuelaModels>, IRepositoryRegistroEscuela
    {
        public Escuela(AppDBContext context) : base(context) { }

        public int InsertEs(EscuelaModels escuela)
        {
            if (escuela == null) throw new ArgumentNullException("Entity");
            entities.Add(escuela);
            context.SaveChanges();
            return escuela.Id;
        }
    }
}
