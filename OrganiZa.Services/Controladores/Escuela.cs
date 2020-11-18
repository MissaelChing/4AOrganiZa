using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        public EscuelaModels Updates(EscuelaModels escuela)
        {
            var temp = context.Escuela.FirstOrDefault(x => x.Id == escuela.Id)
            ?? new EscuelaModels();
            if (temp.Id == 0)
                return temp;
            temp.Id = escuela.Id;
            temp.NombreE = escuela.NombreE;
            temp.ModoP = escuela.ModoP;
            temp.Colegiatura = escuela.Colegiatura;
            temp.NombreAd = escuela.NombreAd;
            if (temp == null) throw new ArgumentNullException("Entity");
            if (temp.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return temp;
        }
        public EscuelaModels GetE(int Id)
        {
            return context.Escuela.FirstOrDefault(x => x.Id == Id);
        }
        public EscuelaModels GetEA(int Id)
        {
            return context.Escuela.FirstOrDefault(x => x.IdA == Id);
        }
        public IEnumerable<EscuelaModels> GetW()
        {
            return context.Escuela.ToList() ?? new List<EscuelaModels>();
        }

        public int BuscarEscuela(EscuelaModels Escuela)
        {

            var escuelas = context.Escuela.ToList();
            int id = 0;
            foreach (var items in escuelas)
            { 
                if (Escuela.IdA == items.IdA)
                {
                    Escuela.Id = items.Id;
                    Escuela.NombreE = items.NombreE;
                    id = items.Id;
                    break;
                }
            }
            return id;
        }
    }
}
