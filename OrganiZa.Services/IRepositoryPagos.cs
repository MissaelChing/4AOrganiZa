using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrganiZa.Services
{
    public interface IRepositoryPagos
    {
        public int InsertE(PagosModels Pagos);
        public PagosModels GetP(int id);
        public IEnumerable<PagosModels> GetW();
        public PagosModels Updates(PagosModels Pago);
        public PagosModels UpdatesP(PagosModels Pago);
        public IEnumerable<PagosModels> GetTodo();
        public void Index(string A);

    }
}
