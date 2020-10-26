using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganiZa.Models;
using OrganiZa.Services;

namespace OrganiZaUI.Pages
{
    public class RegistroModel : PageModel
    {
        [BindProperty]
        public Users user { get; set; }
        [BindProperty]
        public AdministradorModels administrador { get; set; }
        [BindProperty]
        public TutorModels tutor { get; set; }
        public IRepositoryRegistroAdmi repositoryAdmin;
        public IRepositoryRegistroTutor repositoryTutor;


        public IRepositoryUsuarios repositoryUsuario;
        public RegistroModel(IRepositoryRegistroAdmi repositoryAdmin, IRepositoryUsuarios repositoryUsuario, IRepositoryRegistroTutor repositoryTutor)
        {
            this.repositoryAdmin = repositoryAdmin;
            this.repositoryUsuario = repositoryUsuario;
            this.repositoryTutor = repositoryTutor;

        }

        public IActionResult OnPost()
        {
            
            if (user.Rolusuario == "Tutor")
            {
                repositoryUsuario.InsertU(user);
                tutor.UsersId = user.Id;
                repositoryTutor.InsertT(tutor);

            }
            else if(user.Rolusuario=="Administrador")
            {
                repositoryUsuario.InsertU(user);
                administrador.UsersId = user.Id;
                repositoryAdmin.InsertE(administrador);

            }
            return Redirect("/RegistroE");

        }
    }
}
