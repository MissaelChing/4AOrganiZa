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

    }
}
