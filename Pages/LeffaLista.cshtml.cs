using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Pages
{
    public class LeffaListaModel : PageModel
    {
        //Muuttujat
        private readonly LeffaService _service;

        //Konstruktori, alustaa muuttujat
        public LeffaListaModel(LeffaService service)
        {
            _service = service;
        }

        //Leffalista leffoille
        public IList<Leffa> LeffaLista { get; set; } = default!;

        //Leffa-class
        [BindProperty]
        public Leffa NewLeffa { get; set; } = new Leffa();

        //HTTP saa leffalistan
        public void OnGet()
        {
            LeffaLista = _service.GetLeffa();
        }

        //HTTP POSTin käsittely
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || NewLeffa == null)
            {
                return Page();
            }

            _service.AddLeffa(NewLeffa);

            return RedirectToPage("LeffaLista");
        }

        //Leffojen poistaminen, HTTP pyynnön käsittely
        public IActionResult OnPostDelete(int id)
        {
            _service.DeleteLeffa(id);

            return RedirectToAction("LeffaLista");
        }

    }
}
