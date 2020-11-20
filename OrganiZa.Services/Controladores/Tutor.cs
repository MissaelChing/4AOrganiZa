using Microsoft.EntityFrameworkCore;
using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganiZa.Services.Controladores
{
    public class Tutor : SQLRepository<TutorModels>, IRepositoryRegistroTutor
    {
        public Tutor(AppDBContext context) : base(context) { }

        public int InsertT(TutorModels tutor)
        {
            if (tutor == null) throw new ArgumentNullException("Entity");
            entities.Add(tutor);
            context.SaveChanges();
            return tutor.Id;
        }
        public TutorModels GetT(int Id)
        {
            return context.Tutor.FirstOrDefault(x => x.Id == Id);
        }
        public IEnumerable<TutorModels> GetW()
        {
            return context.Tutor.ToList() ?? new List<TutorModels>();
        }
        public TutorModels Updates(TutorModels Tutor)
        {
            var temp = context.Tutor.FirstOrDefault(x => x.Id == Tutor.Id)
            ?? new TutorModels();
            if (temp.Id == 0)
                return temp;
            temp.Id = Tutor.Id;
            temp.NombreT = Tutor.NombreT;
            temp.Alumno = Tutor.Alumno;
            if (temp == null) throw new ArgumentNullException("Entity");
            if (temp.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return temp;
        }
        public int BuscarEscuela(TutorModels Tutor)
        {

            var escuelas = context.Tutor.ToList();
            int id = 0;
            foreach (var items in escuelas)
            {
                if (Tutor.Id == items.Id)
                {
                    Tutor.IdE = items.IdE;
                    Tutor.Id = items.Id;
                    Tutor.NombreE = items.NombreE;
                    id = items.Id;
                    break;
                }
            }
            return id;
        }

    }
}
