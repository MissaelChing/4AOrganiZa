using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganiZa.Models;
using OrganiZa.Services;

namespace OrganiZaUI.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Users users { get; set; }
        public Users users2 { get; set; }


        public IRepositoryValidar repositorycuentas;

        public int i;
        public string Rol;
     
        public LoginModel(IRepositoryValidar repositorycuentas)
        {
            this.repositorycuentas = repositorycuentas;
            

        }

        public string b;
        public string c;

        public IActionResult OnPost()
        {

            i = repositorycuentas.Validar(users);
            if (i >= 1 & users.Rolusuario == "Administrador")
            {
                HttpContext.Session.SetString("1", users.Usuario);
                HttpContext.Session.SetString("1.1", users.IdA.ToString());
                HttpContext.Session.SetString("1.2", users.Rolusuario);


                return Redirect("/Index");
            }
            else
            {
                if (i >= 1 & users.Rolusuario == "Tutor")
                {
                    HttpContext.Session.SetString("1", users.Usuario);
                    HttpContext.Session.SetString("1.1", users.IdT.ToString());
                    HttpContext.Session.SetString("1.2", users.Rolusuario);
                    return Redirect("/Index");
                }
            }
            return Redirect("/Login");
        }
        public void Index(string a)
        {
        }

       
    }
}

