using Microsoft.AspNetCore.Mvc;
using Wineshop.Services;

namespace Wineshop.ViewComponents
{
    public class ErosketaViewComponent : ViewComponent
    {
        private readonly ISaskiaService _saskiaService;
        public ErosketaViewComponent(ISaskiaService saskiaService)
        {
            _saskiaService = saskiaService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string saskiaId)
        {
            ViewBag.SaskiaAlea = saskiaId;
            return View(await _saskiaService.SaskiaLortuAleak(saskiaId));
        }
    }
}
