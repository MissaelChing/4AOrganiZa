using Microsoft.EntityFrameworkCore;
using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganiZa.Services.Controladores
{
    public class Calendario : SQLRepository<CalendarioModels>, IRepositoryCalendario
    {
        public Calendario(AppDBContext context) : base(context) { }

        public int InsertC(CalendarioModels Calendario)
        {
            if (Calendario == null) throw new ArgumentNullException("Entity");
            entities.Add(Calendario);
            context.SaveChanges();
            return Calendario.Id;
        }
        public int InsertCT(CalendarioModels Calendario)
        {
            if (Calendario == null) throw new ArgumentNullException("Entity");
            entities.Add(Calendario);
            context.SaveChanges();
            return Calendario.Id;
        }
        public CalendarioModels Updates(CalendarioModels calendario)
        {
            var temp = context.Calendario.FirstOrDefault(x => x.Id == calendario.Id)
            ?? new CalendarioModels();
            if (temp.Id == 0)
                return temp;
            temp.Id = calendario.Id;
            temp.fecha = calendario.fecha;
            if (temp == null) throw new ArgumentNullException("Entity");
            if (temp.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return temp;
        }
        public CalendarioModels GetA(int Id)
        {
            return context.Calendario.FirstOrDefault(x => x.Id == Id);
        }
        public IEnumerable<CalendarioModels> GetW()
        {
            return context.Calendario.ToList() ?? new List<CalendarioModels>();
        }
        public int BuscarCalendario(CalendarioModels calendario)
        {

            var Calendario = context.Calendario.ToList();
            int id = 0;
            foreach (var items in Calendario)
            {
                if (calendario.IdT == items.IdT)
                {
                    calendario.Id = items.Id;
                    calendario.IdE = items.IdE;
                    id = items.Id;
                    break;
                }
            }
            return id;
        }

    }
}
