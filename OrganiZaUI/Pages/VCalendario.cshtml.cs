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
        public Users Users = new Users();
        public IRepositoryRegistroAdmi repositorioadmi;
        public IRepositoryRegistroEscuela repositorioEscuela;
        public SelectList Escuelas { get; private set; }
        public SelectList Calen { get; private set; }
        
        private readonly IRepository<CalendarioModels> repository;
        public IEnumerable<CalendarioModels> Movie { get; private set; }
        public IList<PagosModels> Mov { get; set; }
        public CalendarioModels Calen2 { get; private set; }

        CalendarioModels cal = new CalendarioModels();
        private readonly AppDBContext _context;

        public VCalendarioModel(IRepositoryCalendario repositoryCalendario, IRepositoryRegistroEscuela repositorioEscuela, IRepository<CalendarioModels> repository, AppDBContext context)
        {
            this.repositoryCalendario = repositoryCalendario;
            this.repositorioEscuela = repositorioEscuela;
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
            repositoryCalendario.BuscarCalendario(calendarios);
            calendario = repositoryCalendario.GetA(calendarios.Id);
            Calen = new SelectList(repositoryCalendario.GetW(), nameof(calendarios.Id),
            nameof(calendario.IdE));
            Calen2 = repositoryCalendario.GetCT(Users.Id);
            Calen = new SelectList(repositoryCalendario.GetW(), nameof(Users.Id),
            nameof(Calen2.fecha));

            var movies = from m in _context.Pagos
                         where m.TutorId == Users.Id
                         select m;
            Movie = repository.GetAll();

            Mov = movies.ToList();




            return Page();

        }

        public IActionResult OnPostVolver()
        {
            return Redirect("/Index");
        }
    }
}