using OrganiZa.Models;
using System;
using System.Collections.Generic;
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

    }
}
