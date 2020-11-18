using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrganiZa.Models;
using OrganiZa.Services;

namespace OrganiZaUI.Pages
{
    public class ComprobarelpagoModel : PageModel
    {
        public Users Users = new Users();
        public IRepositoryPagos repositorypagos;
        public string file1 { get; set; }
        public PagosModels pago { get; set; }
        public SelectList Pagos { get; set; }
        public IFormFile file;
        public ComprobarelpagoModel(IRepositoryPagos repositorypagos)
        {
            this.repositorypagos = repositorypagos;


        }


        public IActionResult OnGet(int Id)
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

                OnGetID(Id);

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
        public void OnGetID(int id)
        {

            pago = repositorypagos.GetP(id);
            Pagos = new SelectList(repositorypagos.GetW(), nameof(id),
            nameof(pago.NombreT));

        }
        private byte[] GetByteArrayFromImage(IFormFile file)
        {
            using (var target = new MemoryStream())
            {
                file.CopyTo(target);
                return target.ToArray();
            }
        }
        public IActionResult OnPost(PagosModels Pago, int id)
        {
            OnGet(id);
            repositorypagos.UpdatesP(Pago);

            return Page();
        }
    }
}
