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
    public class DeleteModel : PageModel
    {
        private readonly adv_bus_final.Models.Context _context;

        public DeleteModel(adv_bus_final.Models.Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Recipe Recipe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Recipes == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes.FirstOrDefaultAsync(m => m.RecipeId == id);

            if (recipe == null)
            {
                return NotFound();
            }
            else 
            {
                Recipe = recipe;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Recipes == null)
            {
                return NotFound();
            }
            var recipe = await _context.Recipes.FindAsync(id);

            if (recipe != null)
            {
                Recipe = recipe;
                _context.Recipes.Remove(Recipe);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
