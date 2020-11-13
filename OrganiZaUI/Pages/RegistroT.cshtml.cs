using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganiZa.Models;
using OrganiZa.Services;
using Microsoft.AspNetCore.Identity;

namespace OrganiZaUI.Pages
{
    public class RegistroTModel : PageModel
    {
        [BindProperty]
        public Users user { get; set; }
        [BindProperty]
        public TutorModels tutor { get; set; }
        public IRepositoryRegistroTutor repositorytutor;


        public IRepositoryUsuarios repositoryUsuario;
        public RegistroTModel(IRepositoryRegistroTutor repositoryTutor, IRepositoryUsuarios repositoryUsuario)
        {
            this.repositorytutor = repositoryTutor;
            this.repositoryUsuario = repositoryUsuario;

        }

        public IActionResult OnPost()
        {

            user.Rolusuario = "Tutor";
            tutor.Rolusuario = "Tutor";
            repositorytutor.InsertT(tutor);
            user.IdT = tutor.Id;
            
            repositoryUsuario.InsertU(user);

            return Redirect("/Login");

        }
    }
}
