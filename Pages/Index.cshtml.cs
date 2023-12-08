using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adv_bus_final.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace adv_bus_final.Pages;

public class IndexModel : PageModel
{
    private readonly Context _context;
    public List<Recipe> Recipes {get; set;}

    public IndexModel(Context context)
        {
            _context = context;
        }

    public void OnGet()
    {
        Recipes = _context.Recipes.ToList();
    }
}


