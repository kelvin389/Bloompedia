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

        // executes whenever a post occurs on any page
        public IActionResult OnPost()
        {
            // if string contains anything
            if (!String.IsNullOrEmpty(search))
            {
                // redirect to the search results page
                return RedirectToPage("/Results", new { search });
            }
            // otherwise, don't do anything
            return Page();
        }
    }
}
