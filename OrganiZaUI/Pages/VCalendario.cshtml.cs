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
        public TutorModels Tutor { get; private set; }
        [BindProperty]
        public IEnumerable<PagosModels> Pago { get; set; }
        [BindProperty]
        public CalendarioModels calendario { get; set; }
        [BindProperty]
        public AdministradorModels administrador { get; set; }
        [BindProperty]
        public EscuelaModels escuela { get; set; }
        public EscuelaModels escuelas = new EscuelaModels();
        public CalendarioModels calendarios = new CalendarioModels();
        public IRepositoryCalendario repositoryCalendario;
        public SelectList Tutores { get; private set; }
        public Users Users = new Users();
        public IRepositoryRegistroAdmi repositorioadmi;
        public IRepositoryRegistroEscuela repositoryRegistroEscuela;
        public IRepositoryRegistroTutor repositorytutor;

        public SelectList Escuela { get; private set; }
        public EscuelaModels Escuelas { get; private set; }
        public SelectList Calen { get; private set; }
        
        private readonly IRepository<CalendarioModels> repository;
        public IEnumerable<CalendarioModels> Movie { get; private set; }
        public IList<CalendarioModels> Mov { get; set; }
        public CalendarioModels Calen2 { get; private set; }

        CalendarioModels cal = new CalendarioModels();
        private readonly AppDBContext _context;

        public VCalendarioModel(IRepositoryCalendario repositoryCalendario, IRepositoryRegistroEscuela repositoryRegistroEscuela, IRepository<CalendarioModels> repository, AppDBContext context, IRepositoryRegistroTutor repositorytutor)
        {
            this.repositoryCalendario = repositoryCalendario;
            this.repositoryRegistroEscuela = repositoryRegistroEscuela;
            this.repositorytutor = repositorytutor;
            this.repository = repository;
            _context = context;
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

            Escuelas = repositoryRegistroEscuela.GetEA(Users.Id);
            Escuela = new SelectList(repositoryRegistroEscuela.GetW(), nameof(Users.Id),
            nameof(Escuelas.NombreE));

            var movies = from m in _context.Calendario
                         where m.IdE == Escuelas.Id
                         select m;
          

            Mov = movies.ToList();




            return Page();

        }

        public IActionResult OnPostVolver()
        {
            return Redirect("/Index");
        }
    }
}