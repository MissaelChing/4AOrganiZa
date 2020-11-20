using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrganiZa.Services
{
   public interface IRepositoryUsuarios
    {
        public int InsertU(Users users);
        public int BuscarIdT(Users users);


    }
}
