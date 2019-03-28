using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageMovie2.Models;

namespace RazorPageMovie2.Pages.Movie
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageMovie2.Models.RazorPageMovie2Context _context;

        public DetailsModel(RazorPageMovie2.Models.RazorPageMovie2Context context)
        {
            _context = context;
        }

        public Movies Movies { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            { 
                Movies = await _context.Movies.FirstOrDefaultAsync(m => m.ID == id);
            }
            if (Movies == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
