using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrganiZa.Services
{
    public interface IRepositoryRegistroAdmi
    {
        public int InsertE(AdministradorModels administrador);
        public AdministradorModels GetA(int id);
        public IEnumerable<AdministradorModels> GetW();
        public AdministradorModels Updates(AdministradorModels administrador);
    }
}
