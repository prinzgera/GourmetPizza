using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GourmetPizza.Data;
using GourmetPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GourmetPizza.Pages.PizzaTest
{
    public class PurchaseModel : PageModel
    {
        private readonly GourmetPizzaContext _db;

        public PurchaseModel(GourmetPizzaContext db)
        {
            _db = db;
        }

        //[BindProperty]
        //public InputModel Input { get; set; }

        //public class InputModel
        //{

        //    [Required]
        //    public int PizzaType { get; set; }


        //    [Required]
        //    public string PizzaName { get; set; }

        //    [Required]
        //    public float Price { get; set; }
        //}

        [BindProperty(SupportsGet = true)]
        public string PizzaType { get; set; }


        [BindProperty(SupportsGet = true)]
        public string PizzaCount { get; set; }

        public void OnGet()
        {
            if (!string.IsNullOrWhiteSpace(PizzaType) || !string.IsNullOrWhiteSpace(PizzaCount))
            {
                Pizza pizzaDb = _db.Pizza.Where(x => x.PizzaType == Convert.ToInt32(PizzaType)).SingleOrDefault();

                if (pizzaDb != null)
                {
                    ViewData["pizzaname"] = pizzaDb.PizzaName;
                    ViewData["totalprice"] = pizzaDb.Price*Convert.ToInt32(PizzaCount);
                    ViewData["imagename"] = pizzaDb.ImageName;

                }
            }

        }
    }
}
