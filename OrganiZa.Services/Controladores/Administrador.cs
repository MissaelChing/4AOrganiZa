using Microsoft.EntityFrameworkCore;
using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganiZa.Services.Controladores
{
    public class Administrador : SQLRepository<AdministradorModels>, IRepositoryRegistroAdmi

    {
        public Administrador(AppDBContext context) : base(context) { }

        public int InsertE(AdministradorModels Administrador)
        {
            if (Administrador == null) throw new ArgumentNullException("Entity");
            entities.Add(Administrador);
            context.SaveChanges();
            return Administrador.Id;
        }
        public AdministradorModels Updates(AdministradorModels administrador)
        {
            var temp = context.Administrador.FirstOrDefault(x => x.Id == administrador.Id)
            ?? new AdministradorModels();
            if (temp.Id == 0)
                return temp;
            temp.Id = administrador.Id;
            temp.NombreAd = administrador.NombreAd;
            if (temp == null) throw new ArgumentNullException("Entity");
            if (temp.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return temp;
        }
        public AdministradorModels GetA(int Id)
        {
            return context.Administrador.FirstOrDefault(x => x.Id == Id);
        }
        public IEnumerable<AdministradorModels> GetW()
        {
            return context.Administrador.ToList() ?? new List<AdministradorModels>();
        }
    }
}
