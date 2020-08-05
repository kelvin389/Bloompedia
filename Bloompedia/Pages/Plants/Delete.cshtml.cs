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
    public class DeleteModel : PageModel
    {
        private readonly BloompediaContext _context;

        public DeleteModel(BloompediaContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plant = await _context.Plant.FindAsync(id);

            if (Plant != null)
            {
                _context.Plant.Remove(Plant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
