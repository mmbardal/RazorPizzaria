using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzaria.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
           
            if (string.IsNullOrWhiteSpace(PizzaName))
                PizzaName = "custom";
            if (string.IsNullOrWhiteSpace(ImageTitle))
                ImageTitle = "vecteezy_pizza-transparent-background_14033564_600";
        }
    }
}
