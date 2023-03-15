using Microsoft.AspNetCore.Mvc;
using Mission09_cji23.Models;
namespace Mission09_cji23.Components
{
    public class PurchaseSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public PurchaseSummaryViewComponent(Basket basketService)
        {
            basket = basketService;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
