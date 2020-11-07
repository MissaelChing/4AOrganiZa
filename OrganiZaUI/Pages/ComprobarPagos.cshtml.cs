using System;
using System.Collections.Generic;
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
    public class ComprobarPagosModel : PageModel
    {
        [BindProperty]
        public IEnumerable<PagosModels> Pago { get; set; }
        public Users Users = new Users();
        public IRepositoryPagos repositorypagos;
        public IFormFile file { get; set; }
        public PagosModels pago { get; set; }
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
            if (Users.Rolusuario != null && Users.Rolusuario =="Administrador")
            {
                Pago = repositorypagos.GetTodo();
          

            }
            else
            {
                return Redirect("/Error");
            }

            return Page();

        }
        public void OnGetID(int id)
        {
           
            Pagos = new SelectList(repositorypagos.GetW(), nameof(id),
            nameof(pago.NombreT));

        }
    }
}
