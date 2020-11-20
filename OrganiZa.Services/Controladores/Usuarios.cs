using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganiZa.Services.Controladores
{
    public class Usuarios :SQLRepository<Users>,IRepositoryUsuarios
    {
        public Usuarios(AppDBContext context) : base(context) { }

        public int InsertU(Users users)
        {
            if (users == null) throw new ArgumentNullException("Entity");
            entities.Add(users);
            context.SaveChanges();
            return users.Id;
        }
        public int BuscarIdT(Users users)
        {

            var Calendario = context.Users.ToList();
            int id = 0;
            foreach (var items in Calendario)
            {
                if (users.Id == items.Id)
                {
                    users.IdT = items.IdT;
                    id = items.IdT;
                    break;
                }
            }
            return id;
        }



    }
}
