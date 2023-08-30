using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;
using WebApp.Services;


namespace WebApp.Pages
{
    public class LeffaListaModel : PageModel
    {
        private readonly LeffaService _service;
        public IList<Leffa> LeffaLista { get; set; } = default!;

        public LeffaListaModel(LeffaService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            LeffaLista = _service.GetLeffa();
        }
    }
}
