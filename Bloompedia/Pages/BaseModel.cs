using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bloompedia.Pages
{
    public class BaseModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string search { get; set; }

        public IActionResult OnPost()
        {
            return RedirectToPage("/Results", new { search });
        }
    }
}
