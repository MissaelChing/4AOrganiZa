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
        public IRepositoryPagos repositoryPagos;
        public IRepositoryRegistroTutor repositorytutor;


        public PagosModel(IRepositoryPagos repositoryPagos, IRepositoryRegistroTutor repositorytutor)
        {
            this.repositoryPagos = repositoryPagos;
            this.repositorytutor = repositorytutor;


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
            if (Users.Rolusuario == "Tutor")
            {
                Tutor = repositorytutor.GetT(int.Parse(HttpContext.Session.GetString("1.1")));
                Tutores = new SelectList(repositorytutor.GetW(), nameof(Tutor.Id),
                nameof(Tutor.NombreT));
            }
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
            OnGet();
            if(file != null)
            {
                pagos.Fichapago = Tutor.FichaPago;
                if (pagos.Fichapago == null)
                {
                    return Redirect("/Error");
                }
                
                    pagos.voucher = GetByteArrayFromImage(file);
                    pagos.Fecha = DateTime.Now;
                    pagos.TutorId = int.Parse(HttpContext.Session.GetString("1.1"));
                    pagos.NombreT = Tutor.NombreT;
                    pagos.Alumno = Tutor.Alumno;
                    pagos.statusdepago = false;
                    repositoryPagos.InsertE(pagos);
                    return Redirect("/MenuPagos");

                
            }
            else
            {
                return Redirect("/Error");


            }

        }

      
    }
}
