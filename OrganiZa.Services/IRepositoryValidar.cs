using System;
using System.Collections.Generic;
using System.Text;
using OrganiZa.Models;
using OrganiZa.Services.Controladores;

namespace OrganiZa.Services
{
    public interface IRepositoryValidar 
    {

        public int Validar(Users users);
    }
}
