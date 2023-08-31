using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Pages
{
    public class LeffaListaModel : PageModel
    {
        private readonly LeffaService _service;

        public LeffaListaModel(LeffaService service)
        {
            _service = service;
        }

        public IList<Leffa> LeffaLista { get; set; } = default!;

        [BindProperty]
        public Leffa NewLeffa { get; set; } = new Leffa();

        public void OnGet()
        {
            LeffaLista = _service.GetLeffa();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || NewLeffa == null)
            {
                return Page();
            }

            _service.AddLeffa(NewLeffa);

            return RedirectToPage("LeffaLista");
        }

        public IActionResult OnPostDelete(int id)
        {
            _service.DeleteLeffa(id);

            return RedirectToAction("LeffaLista");
        }

    }
}
