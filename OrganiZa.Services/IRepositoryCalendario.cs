using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrganiZa.Services
{
    public interface IRepositoryCalendario
    {
        public int InsertC(CalendarioModels calendario);
        public int InsertCT(CalendarioModels calendario);
        public int BuscarCalendario(CalendarioModels calendario);
        public int BuscarCalendarioMes(CalendarioModels calendario);
        public int BuscarCalendariIdE(CalendarioModels calendario);
        public CalendarioModels GetA(int id);
        public CalendarioModels GetCT(int id);
        public IEnumerable<CalendarioModels> GetW();
        public CalendarioModels Updates(CalendarioModels calendario);
    }
}
