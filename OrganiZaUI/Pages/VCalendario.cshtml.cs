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
    public class VCalendarioModel : PageModel
    {
        [BindProperty]
        public CalendarioModels calendario { get; set; }
        [BindProperty]
        public AdministradorModels administrador { get; set; }
        [BindProperty]
        public EscuelaModels escuela { get; set; }
        public EscuelaModels escuelas = new EscuelaModels();
        public CalendarioModels calendarios = new CalendarioModels();
        public IRepositoryCalendario repositoryCalendario;
        public Users Users = new Users();
        public IRepositoryRegistroAdmi repositorioadmi;
        public IRepositoryRegistroEscuela repositorioEscuela;
        public SelectList Escuelas { get; private set; }
        public SelectList Calen { get; private set; }
        
        private readonly IRepository<CalendarioModels> repository;
        public IEnumerable<CalendarioModels> Movie { get; private set; }

        CalendarioModels cal = new CalendarioModels();


        public VCalendarioModel(IRepositoryCalendario repositoryCalendario, IRepositoryRegistroEscuela repositorioEscuela, IRepository<CalendarioModels> repository)
        {
            this.repositoryCalendario = repositoryCalendario;
            this.repositorioEscuela = repositorioEscuela;
            this.repository = repository;
        }
        public IActionResult OnGet()
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
                calendarios.IdT = Users.Id;
            }
            repositoryCalendario.BuscarCalendario(calendarios);
            calendario = repositoryCalendario.GetA(calendarios.Id);
            Calen = new SelectList(repositoryCalendario.GetW(), nameof(calendarios.Id),
            nameof(calendario.IdE));
            Movie = repository.GetAll();






            return Page();

        }

        public IActionResult OnPostVolver()
        {
            return Redirect("/Index");
        }
    }
}