using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganiZa.Models;
using OrganiZa.Services;
using System.Drawing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OrganiZaUI.Pages
{
    public class PagosModel : PageModel
    {
        public Users Users = new Users();
        [BindProperty]
        public TutorModels Tutor { get; private set; }
        [BindProperty]
        public PagosModels pagos { get; set; }
        public PagosModels Pagos { get; set; }
        public SelectList Tutores { get; private set; }
        public IFormFile file { get; set; }

        [Obsolete]
        private IHostingEnvironment _environment;

        public IRepositoryPagos repositoryPagos;
        public IRepositoryRegistroTutor repositorytutor;


        [Obsolete]
        public PagosModel(IRepositoryPagos repositoryPagos, IHostingEnvironment environment, IRepositoryRegistroTutor repositorytutor)
        {
            this.repositoryPagos = repositoryPagos;
            _environment = environment;
            this.repositorytutor = repositorytutor;


        }
        private byte[] GetByteArrayFromImage(IFormFile file)
        {
            using (var target = new MemoryStream())
            {
                file.CopyTo(target);
                return target.ToArray();
            }
        }
        public IActionResult OnPost()
        {
            if(file != null)
            {
                pagos.voucher = GetByteArrayFromImage(file); 
                pagos.Fecha = DateTime.Now;
                pagos.TutorId = int.Parse(HttpContext.Session.GetString("1.1"));
                pagos.Fichapago = Tutor.FichaPago;
                pagos.NombreT = Tutor.NombreT;
                pagos.Alumno = Tutor.Alumno;
                repositoryPagos.InsertE(pagos);
                return Redirect("/MenuPagos");
            }

            return Redirect("/Error");


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
            if (Users.Rolusuario == "Administrador")
            {
                Tutor = repositorytutor.GetT(Users.Id);
                Tutores = new SelectList(repositorytutor.GetW(), nameof(Users.Id),
                nameof(Tutor.NombreT));
            }
         
        }
    }
}
