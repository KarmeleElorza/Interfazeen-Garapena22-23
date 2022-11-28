using Microsoft.AspNetCore.Mvc;
using WineShop.Services;

namespace WineShop.ViewComponents
{
    public class ArdoakViewComponents : ViewComponent

    {
        private readonly IArdoaService _ardoaService;
        public ArdoakViewComponents(IArdoaService ardoaService)
        {
            _ardoaService = ardoaService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _ardoaService.GetMota(id));
        }
    }
}
