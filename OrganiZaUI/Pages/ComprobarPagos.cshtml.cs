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
        public string file1 { get; set; }

        public PagosModels pago { get; set; }
        public PagosModels pagoB { get; set; }
        public SelectList Pagos { get; set; }

      

        public ComprobarPagosModel(IRepositoryPagos repositorypagos)
        {
            this.repositorypagos = repositorypagos;
            

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
                Pago = repositorypagos.GetTodo();
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

            Pagos = new SelectList(repositorypagos.GetW(), nameof(id),
            nameof(pago.NombreT));

        }

    }
}
