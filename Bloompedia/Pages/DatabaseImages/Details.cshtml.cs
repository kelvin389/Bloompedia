using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bloompedia.Models;

namespace Bloompedia.Pages.DatabaseImages
{
    public class DetailsModel : PageModel
    {
        private readonly BloompediaContext _context;

        public DetailsModel(BloompediaContext context)
        {
            _context = context;
        }

        public Image Image { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Image = await _context.Image.FirstOrDefaultAsync(m => m.ImageID == id);

            if (Image == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
