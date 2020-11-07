using Microsoft.EntityFrameworkCore;
using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public PagosModels GetP(int Id)
        {
            return context.Pagos.FirstOrDefault(x => x.Id == Id);
        }
        public IEnumerable<PagosModels> GetW()
        {
            return context.Pagos.ToList() ?? new List<PagosModels>();
        }
        public IEnumerable<PagosModels> GetTodo()
        {
            return entities.AsEnumerable();
        }

        public PagosModels Updates(PagosModels pagos)
        {
            var temp = context.Pagos.FirstOrDefault(x => x.Id == pagos.Id)
            ?? new PagosModels();
            if (temp.Id == 0)
                return temp;
            temp.Id = pagos.Id;
            temp.NombreT = pagos.NombreT;
            temp.Alumno = pagos.Alumno;
            temp.TutorId = pagos.TutorId;
            temp.voucher = pagos.voucher;
            temp.Mespagado = pagos.Mespagado;
            temp.Fecha = pagos.Fecha;
            temp.Fichapago = pagos.Fichapago;
            if (temp == null) throw new ArgumentNullException("Entity");
            if (temp.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return temp;
        }

    }
}
