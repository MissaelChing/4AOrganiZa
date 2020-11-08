using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganiZa.Models;
using OrganiZa.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace OrganiZaUI.Pages
{
    public class RegistroEModel : PageModel
    {

        [BindProperty]
        public EscuelaModels escuela { get; set; }

        public Users Users = new Users();

        public IRepositoryRegistroEscuela repositoryEscuela;

        public RegistroEModel(IRepositoryRegistroEscuela repositoryEscuela)
        {
            this.repositoryEscuela = repositoryEscuela;
        }
        public void OnGet()
        {
            if (HttpContext.Session.GetString("1.1") == null)
            {
                Redirect("/Error");

            }
            else
            {
                Users.Usuario = HttpContext.Session.GetString("1");
                Users.Id = int.Parse(HttpContext.Session.GetString("1.1"));
                Users.Rolusuario = HttpContext.Session.GetString("1.2");
            }
        }

        public IActionResult OnPost()
        {
            OnGet();

            escuela.IdA = Users.Id;
            repositoryEscuela.InsertEs(escuela);
            return Redirect("/Menu");
        }
    }
}
