using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using adv_bus_final.Models;

namespace adv_bus_final.Pages.Recipe
{
    public class IndexModel : PageModel
    {
        private readonly adv_bus_final.Models.Context _context;

        public IndexModel(adv_bus_final.Models.Context context)
        {
            _context = context;
        }

        // public int SortOrder { get; set; } 
        // public int PageIndex { get; set; }
        // public int TotalPages { get; set; }
        // public bool HasPreviousPage => PageIndex > 1;
        // public bool HasNextPage => PageIndex < TotalPages;

        // public async Task OnGetAsync()
        // {

        // }

        //Scaffolding messed this up
        public IList<Recipe> Recipe { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Recipes != null)
            {
                Recipe = await _context.Recipes.ToListAsync();
            }
        }

        //  public class PaginatedList<T> : List<T>
        // {
        //     public int PageIndex { get; private set; }
        //     public int TotalPages { get; private set; }
        // }
        }
}
