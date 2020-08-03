using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bloompedia.Pages
{
    public class ResultsModel : BaseModel
    {
        public void OnGet()
        {
            ViewData["test"] = search;
            // search using searchQuery
        }
    }
}