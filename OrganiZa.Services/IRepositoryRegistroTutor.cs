using OrganiZa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrganiZa.Services
{
    public interface IRepositoryRegistroTutor
    {
        public int InsertT(TutorModels tutor);
        public TutorModels GetT(int id);
        public IEnumerable<TutorModels> GetW();
        public TutorModels Updates(TutorModels tutor);
        public int BuscarEscuela(TutorModels Tutor);
    }
}
