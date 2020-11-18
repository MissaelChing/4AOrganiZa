using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using OrganiZa.Models;
using OrganiZa.Services;

namespace OrganiZaUI.Pages
{
    public class PRealizadosModel : PageModel
    {
        [BindProperty]
        public TutorModels Tutor { get; private set; }
        [BindProperty]
        public IEnumerable<PagosModels> Pago { get; set; }
        public Users Users = new Users();
        public IRepositoryPagos repositorypagos;
        public IRepositoryRegistroTutor repositorytutor;
        public IRepositoryRegistroEscuela repositoryRegistroEscuela;
        public string file1 { get; set; }

        public SelectList Tutores { get; private set; }
        public SelectList Admins { get; private set; }
        public AdministradorModels Administrador { get; private set; }


        private readonly AppDBContext _context;

        public PagosModels pago { get; set; }
        public SelectList Pagos { get; set; }
        public IList<PagosModels> Movie { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public SelectList Escuela { get; private set; }
        public EscuelaModels Escuelas { get; private set; }


        public PRealizadosModel(IRepositoryPagos repositorypagos, AppDBContext context, IRepositoryRegistroEscuela repositoryRegistroEscuela, IRepositoryRegistroTutor repositorytutor)
        {
            this.repositorypagos = repositorypagos;
            this.repositorytutor = repositorytutor;
            this.repositoryRegistroEscuela = repositoryRegistroEscuela;
            _context = context;

        }


        public IActionResult OnGet(int id)
        {
            if (HttpContext.Session.GetString("1.1") == null)
            {
                return Redirect("/Error");
            }
            else
            {
                Users.Usuario = HttpContext.Session.GetString("1");
                Users.Id = int.Parse(HttpContext.Session.GetString("1.1"));
                Users.Rolusuario = HttpContext.Session.GetString("1.2");
            }
            OnGetID(id);
            Tutor = repositorytutor.GetT(Users.Id);
            Tutores = new SelectList(repositorytutor.GetW(), nameof(Users.Id),
            nameof(Tutor.NombreT));

            var movies = from m in _context.Pagos where m.TutorId == Users.Id select m;


            Movie = movies.ToList();



            return Page();

        }
        public void OnGetID(int id)
        {

            pago = repositorypagos.GetP(id);
            Pagos = new SelectList(repositorypagos.GetW(), nameof(id),
            nameof(pago.NombreT));

        }
    }
}
