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
    public class IndexModel : PageModel
    {
        private readonly BloompediaContext _context;

        public IndexModel(BloompediaContext context)
        {
            _context = context;
        }

        public IList<Image> Image { get;set; }

        public async Task OnGetAsync()
        {
            Image = await _context.Image.ToListAsync();
        }
    }
}
