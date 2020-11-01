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
