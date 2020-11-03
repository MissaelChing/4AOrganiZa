using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrganiZa.Services.Controladores
{
   public class Pagos : SQLRepository<PagosModels>, IRepositoryPagos

    {
        public Pagos(AppDBContext context) : base(context) { }

        public int InsertE(PagosModels pagos)
        {
            if (pagos == null) throw new ArgumentNullException("Entity");
            entities.Add(pagos);
            context.SaveChanges();
            return pagos.Id;
        }
    
    }
}
