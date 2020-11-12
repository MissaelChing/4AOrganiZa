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
    public class ComprobarPagosModel : PageModel
    {
        [BindProperty]
        public IEnumerable<PagosModels> Pago { get; set; }
        public Users Users = new Users();
        public IRepositoryPagos repositorypagos;
        public IRepositoryRegistroEscuela repositoryRegistroEscuela;
        public string file1 { get; set; }

   
        public SelectList Admins { get; private set; }
        public AdministradorModels Administrador { get; private set; }


        private readonly AppDBContext _context;


        public IList<PagosModels> Movie { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public SelectList Escuela { get; private set; }
        public EscuelaModels Escuelas { get; private set; }


        public ComprobarPagosModel(IRepositoryPagos repositorypagos, AppDBContext context, IRepositoryRegistroEscuela repositoryRegistroEscuela)
        {
            this.repositorypagos = repositorypagos;
            this.repositoryRegistroEscuela = repositoryRegistroEscuela;
            _context = context;

        }


        public IActionResult OnGet()
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
            if (Users.Rolusuario != null && Users.Rolusuario == "Administrador")
            {
                Escuelas = repositoryRegistroEscuela.GetEA(Users.Id);
                Escuela = new SelectList(repositoryRegistroEscuela.GetW(), nameof(Users.Id),
                nameof(Escuelas.NombreE));

                var movies = from m in _context.Pagos where m.IdE == Escuelas.Id
                             select m ;
                if (!string.IsNullOrEmpty(SearchString))
                {
                    movies = movies.Where(s => s.NombreT.Contains(SearchString));
                }
               
                Movie = movies.ToList();
            }
            else
            {
                return Redirect("/Error");
            }



            return Page();

        }

        public string ImageSource(byte[] yourImageBytes)
        {


            string mimeType = ("image/png");
            string base64 = Convert.ToBase64String(yourImageBytes);
            return string.Format("data:{0};base64,{1}", mimeType, base64);

        }
    

    }
}
