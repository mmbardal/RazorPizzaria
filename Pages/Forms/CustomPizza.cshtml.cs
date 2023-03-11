using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaria.Models;
namespace RazorPizzaria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        
        public  PizzasModel Pizzas { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            PizzaPrice = Pizzas.BasePrice;
            if (Pizzas.TomatoSause) PizzaPrice += 1;
            if (Pizzas.Cheese) PizzaPrice += 1;
            if (Pizzas.Peperoni) PizzaPrice += 1;
            if (Pizzas.Mushroom) PizzaPrice +=1;
            if(Pizzas.Tuna) PizzaPrice += 1;    
            if(Pizzas.Pineapple) PizzaPrice += 10;
            if(Pizzas.Ham) PizzaPrice += 1;
            Console.WriteLine(PizzaPrice);
            Console.WriteLine(Pizzas.PizzaName);
            return RedirectToPage("/Checkout/Checkout",new{Pizzas.PizzaName, PizzaPrice });
        }
    }
}
