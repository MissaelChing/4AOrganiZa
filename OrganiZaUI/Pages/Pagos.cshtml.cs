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

namespace OrganiZaUI.Pages
{
    public class PagosModel : PageModel
    {
        public Users Users = new Users();
        [BindProperty]
        public PagosModels pagos { get; set; }
        public PagosModels Pagos { get; set; }
        public IFormFile file { get; set; }

        [Obsolete]
        private IHostingEnvironment _environment;

        public IRepositoryPagos repositoryPagos;

        [Obsolete]
        public PagosModel(IRepositoryPagos repositoryPagos, IHostingEnvironment environment)
        {
            this.repositoryPagos = repositoryPagos;
            _environment = environment;


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
        }
    }
}
