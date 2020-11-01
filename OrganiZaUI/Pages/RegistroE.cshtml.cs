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
    public class RegistroEModel : PageModel
    {

        [BindProperty]
        public EscuelaModels escuela { get; set; }
        public IRepositoryRegistroEscuela repositoryEscuela;


        public RegistroEModel(IRepositoryRegistroEscuela repositoryEscuela)
        {
            this.repositoryEscuela = repositoryEscuela;

        }

        public IActionResult OnPost()
        {


            repositoryEscuela.InsertEs(escuela);


            return Redirect("/RegistroA");

        }
    }
}
