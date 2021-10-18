using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GourmetPizza.Data;
using GourmetPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GourmetPizza.Pages
{
    public class IndexModel : PageModel
    {

        private readonly GourmetPizzaContext _db;

        public IndexModel(GourmetPizzaContext db)
        {
            _db = db;
        }

        [BindProperty(SupportsGet = true)]
        public List<Pizza> PizzaBases { get; set; }

        public void OnGet()
        {
            PizzaBases = _db.Pizza.ToList();

        }
    }
}
