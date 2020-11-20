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
            temp.MesPago = calendario.MesPago;
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
        public CalendarioModels GetCT(int Id)
        {
            return context.Calendario.FirstOrDefault(x => x.IdT == Id);
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
                if (calendario.IdE == items.IdE)
                {
                    calendario.IdE = items.IdE;
                    calendario.MesPago = items.MesPago;
                    id = items.IdE;
                    break;
                }
            }
            return id;
        }
        public int BuscarCalendarioMes(CalendarioModels calendario)
        {

            var Calendario = context.Calendario.ToList();
            int id = 0;
            foreach (var items in Calendario)
            {
                if (calendario.MesPago == items.MesPago)
                {
                    calendario.IdE = items.IdE;
                    calendario.MesPago = items.MesPago;
                    calendario.Colegiatura = items.Colegiatura;
                    calendario.IdT = items.IdT;
                    id = items.IdE;
                    break;
                }
            }
            return id;
        }
        public int BuscarCalendariIdE(CalendarioModels calendario)
        {

            var Calendario = context.Calendario.ToList();
            int id = 0;
            foreach (var items in Calendario)
            {
                if (calendario.IdE == items.IdE)
                {
                    calendario.Id = items.Id;
                    id = items.Id;
                    break;
                }
            }
            return id;
        }

    }
}
