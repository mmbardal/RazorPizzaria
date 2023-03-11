using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaria.Models;


namespace RazorPizzaria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> Pizzaha { get; set; }= new List<PizzasModel>()
        {
            new PizzasModel(){PizzaName="hey", ImageTitle="vecteezy_pizza-transparent-background_14033659_718"
                ,BasePrice=2,
                TomatoSause=true,Peperoni=true
            ,FinalPrice=4},
            new PizzasModel(){PizzaName="hello", ImageTitle="vecteezy_pizza-transparent-background_14033564_600",
                BasePrice=2,
                Cheese=true,TomatoSause=true
            ,Ham=true
            ,FinalPrice=5},
            new PizzasModel(){PizzaName="salam", ImageTitle="vecteezy_pizza-png-graphic-clipart-design_19606530_656",
            BasePrice=2,Cheese=true,Ham=true,Mushroom=true,FinalPrice=5}

        };
        public void OnGet()
        {
        }
    }
}
