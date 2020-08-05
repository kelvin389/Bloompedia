using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bloompedia.Models;

namespace Bloompedia.Pages.Plants
{
    public class DetailsModel : PageModel
    {
        private readonly BloompediaContext _context;

        public DetailsModel(BloompediaContext context)
        {
            _context = context;
        }

        public Plant Plant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plant = await _context.Plant.FirstOrDefaultAsync(m => m.PlantID == id);

            if (Plant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
