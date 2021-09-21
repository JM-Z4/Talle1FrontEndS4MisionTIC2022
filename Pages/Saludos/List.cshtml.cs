using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pruebas1.App.Persistencia;
using Pruebas1.App.Dominio;

namespace Pruebas1.App.FrontEnd.Pages
{
    public class ListModel : PageModel
    {
        //private string[] Saludos={"Buen día","Buena tarde","Buena noche","Hola","Bienvenido","Hasta mañana"};
        //public List<string> ListaSaludos{get;set;}
        private readonly IRespositorioSaludos repsitoriosaludos;
        public IEnumerable<Saludo> Saludos {get;set;}

        public ListModel(IRespositorioSaludos repsitoriosaludos)
        {
            this.repsitoriosaludos=repsitoriosaludos;
        }

        public void OnGet()
        {
            //ListaSaludos = new List<string>();
            //ListaSaludos.AddRange(Saludos);
            Saludos=repsitoriosaludos.GetAll();
        }
    }
}
