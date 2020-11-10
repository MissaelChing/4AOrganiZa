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
        public int  BuscarEscuela(EscuelaModels escuela);
        public IEnumerable<EscuelaModels> GetW();
        public EscuelaModels Updates(EscuelaModels escuela);
    }
}
