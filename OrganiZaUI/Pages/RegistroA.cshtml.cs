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
    public class RegistroModel : PageModel
    {
        [BindProperty]
        public Users user { get; set; }
        [BindProperty]
        public AdministradorModels administrador { get; set; }
        public IRepositoryRegistroAdmi repositoryAdmin;


        public IRepositoryUsuarios repositoryUsuario;
        public RegistroModel(IRepositoryRegistroAdmi repositoryAdmin, IRepositoryUsuarios repositoryUsuario)
        {
            this.repositoryAdmin = repositoryAdmin;
            this.repositoryUsuario = repositoryUsuario;

        }

        public IActionResult OnPost()
        {

            user.Rolusuario = "Administrador";
            administrador.Rolusuario = "Administrador";
            repositoryAdmin.InsertE(administrador);
            user.IdA = administrador.Id;
            repositoryUsuario.InsertU(user);
            return Redirect("/Login");

        }
    }
}
