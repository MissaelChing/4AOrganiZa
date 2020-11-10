using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganiZa.Models;
using OrganiZa.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OrganiZaUI.Pages
{
    public class GCalendarioModel : PageModel
    {
        [BindProperty]
        public CalendarioModels calendario { get; set; }
        [BindProperty]
        public AdministradorModels administrador { get; set; }
        [BindProperty]
        public EscuelaModels escuela { get; set; }
        [BindProperty]
        public EscuelaModels escuelas { get; set; }
        public IRepositoryCalendario repositoryCalendario;
        public Users Users = new Users();
        public IRepositoryRegistroAdmi repositorioadmi;
        public IRepositoryRegistroEscuela repositorioEscuela;
        public SelectList Admins { get; private set; }
        public SelectList Escuelas { get; private set; }
       

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
            escuelas.IdA = Users.Id;
            repositorioEscuela.BuscarEscuela(escuelas);
            
            escuela = repositorioEscuela.GetE(escuelas.Id);
            Escuelas = new SelectList(repositorioEscuela.GetW(), nameof(escuelas.Id),
            nameof(escuela.ModoP));
           

        }

        public GCalendarioModel(IRepositoryCalendario repositoryCalendario)
        {
            this.repositoryCalendario = repositoryCalendario;

        }

        public IActionResult OnPost()
        {
            OnGet();
            calendario.IdE = escuela.Id;
            repositoryCalendario.InsertC(calendario);


            return Redirect("/Index");

        }
        public IActionResult OnPostVolver()
        {
            return Redirect("/Index");
        }
    }
}
