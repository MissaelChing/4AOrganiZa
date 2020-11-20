using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrganiZa.Services
{
   public  interface IRepositoryRegistroEscuela
    {
        public int InsertEs(EscuelaModels escuela);
        public EscuelaModels GetE(int id);
        public EscuelaModels GetEA(int id);
        public EscuelaModels GetEscuela(int Id);
        public int BuscarEscuela(EscuelaModels Escuela);
        public IEnumerable<EscuelaModels> GetW();
        public EscuelaModels Updates(EscuelaModels escuela);
    }
}
