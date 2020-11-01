using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrganiZa.Models;
using OrganiZa.Services;

namespace OrganiZaUI.Pages
{
    public class DetallesdelacuentaModel : PageModel
    {

        [BindProperty]
        public TutorModels Tutor { get; private set; }
        [BindProperty]

        public AdministradorModels Admi { get; private set; }

        public Users Users = new Users();
        public SelectList Tutores { get; private set; }
        public SelectList Admins { get; private set; }

        public IRepositoryRegistroTutor repositorytutor;
        public IRepositoryRegistroAdmi repositorioadmi;

        public DetallesdelacuentaModel(IRepositoryRegistroTutor repositorytutor, IRepositoryRegistroAdmi repositorioadmi)
        {
            this.repositorytutor = repositorytutor;
            this.repositorioadmi = repositorioadmi;


        }
        public void OnGet()
        {
            if (HttpContext.Session.GetString("1.1") == null)
            {
                Users.Usuario = HttpContext.Session.GetString("1");
                Users.Rolusuario = HttpContext.Session.GetString("1.2");

            }
            else
            {
                Users.Usuario = HttpContext.Session.GetString("1");
                Users.Id = int.Parse(HttpContext.Session.GetString("1.1"));
                Users.Rolusuario = HttpContext.Session.GetString("1.2");
                

            }
            if (Users.Rolusuario =="Administrador")
            {
                Admi = repositorioadmi.GetA(Users.Id);
                Admins = new SelectList(repositorioadmi.GetW(), nameof(Users.Id),
                nameof(Admi.NombreAd));
            }
            else
            {
                Tutor = repositorytutor.GetT(Users.Id);
                Tutores = new SelectList(repositorytutor.GetW(), nameof(Users.Id),
                nameof(Tutor.NombreT));
            }
        }
        public IActionResult OnPostCerrar()
        {
             HttpContext.Session.Remove("1");
             HttpContext.Session.Remove("1.1");
             HttpContext.Session.Remove("1.2");
            return Redirect("/Index");
        }
    }
}
