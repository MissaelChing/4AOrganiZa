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
        public AdministradorModels admin2 { get; private set; }
        [BindProperty]
        public EscuelaModels escuela { get; set; }
        public EscuelaModels escuelas = new EscuelaModels();
        public IRepositoryCalendario repositoryCalendario;
        public Users Users = new Users();
        public CalendarioModels calendarios = new CalendarioModels();
        public CalendarioModels calendario2 { get; set; }
        public IRepositoryRegistroAdmi repositorioadmi;
        public IRepositoryRegistroEscuela repositorioEscuela;
        public SelectList Admins { get; private set; }
        public SelectList Escuelas { get; private set; }
        public SelectList Calen { get;  set; }

        public IList<CalendarioModels> Movie { get; set; }
        public IList<CalendarioModels> Mov { get; set; }
        public CalendarioModels Calen2 { get; private set; }

        CalendarioModels cal = new CalendarioModels();
        private readonly AppDBContext _context;

        public GCalendarioModel(IRepositoryCalendario repositoryCalendario, IRepositoryRegistroEscuela repositorioEscuela, AppDBContext context)
        {
            this.repositoryCalendario = repositoryCalendario;
            this.repositorioEscuela = repositorioEscuela;
            _context = context;
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
                escuelas.IdA = Users.Id;
            }
            repositorioEscuela.BuscarEscuela(escuelas);
            escuela = repositorioEscuela.GetE(escuelas.Id);
            Escuelas = new SelectList(repositorioEscuela.GetW(), nameof(escuelas.Id),
            nameof(escuela.ModoP));
            var movies = from m in _context.Calendario
                         where m.IdE == escuela.Id
                         select m;

        }
        public void OnGetID(int id)
        {

            calendario2 = repositoryCalendario.GetA(id);
            Calen = new SelectList(repositoryCalendario.GetW(), nameof(id),
            nameof(calendario2.ModoP));


            var movies = from m in _context.Calendario
                         where m.IdA == Users.Id
                         select m;

            Mov = movies.ToList();
        }


        public IActionResult OnPost(int id)
        {
            
            OnGet();
            calendario.IdE = escuela.Id;
            calendario.ModoP = escuela.ModoP;
            calendario.IdA = Users.Id;
            calendario.Colegiatura = escuela.Colegiatura;
            repositoryCalendario.InsertC(calendario);


            return Redirect("/GCalendario"); 

        }
        public IActionResult OnPostVer(int id)
        {
            OnGetID(id);

            return Page();
        }
        public IActionResult OnPostVolver()
        {
            return Redirect("/Index");
        }
    }
}
