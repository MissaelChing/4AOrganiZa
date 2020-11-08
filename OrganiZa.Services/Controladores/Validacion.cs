using Microsoft.EntityFrameworkCore;
using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel;

namespace OrganiZa.Services.Controladores
{
    public class Validacion : SQLRepository<Users>, IRepositoryValidar
    {
      

        public Validacion(AppDBContext context) : base(context)
        {

        }
        public IEnumerable<Users> GetUsers()
        {
            return context.Set<Users>().AsEnumerable();
        }

        public AdministradorModels getusuarios(int id)
        {

            return context.Administrador.Include(x => x.Id).FirstOrDefault(x => x.Id == id);

        }
        public TutorModels getusuariosE(int id)
        {

            return context.Tutor.Include(x => x.Id).FirstOrDefault(x => x.Id == id);

        }
   


        public int Validar(Users users)
        {
           
            var cuenta2 = context.Users.ToList();
            int i = 0;
            foreach (var items in cuenta2)
            {
                if (users.Usuario == items.Usuario && users.Contraseña == items.Contraseña)
                {
                    users.Rolusuario = items.Rolusuario;
                    users.Id = items.Id;
                    users.Usuario = items.Usuario;
                    users.Id = items.Id;
                    users.IdT = items.IdT;
                    users.IdA = items.IdA;
                    i = items.Id;
                    break;
                }

            }
            return i;
        }

    }
}
