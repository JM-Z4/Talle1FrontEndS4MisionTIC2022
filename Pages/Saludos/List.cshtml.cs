using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pruebas1.App.FrontEnd.Pages
{
    public class ListModel : PageModel
    {
        private string[] Saludos={"Buen día","Buena tarde","Buena noche","Hola","Bienvenido","Hasta mañana"};
        public List<string> ListaSaludos{get;set;}

        public void OnGet()
        {
            ListaSaludos = new List<string>();
            ListaSaludos.AddRange(Saludos);
        }
    }
}
