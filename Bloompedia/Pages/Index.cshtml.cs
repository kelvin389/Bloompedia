using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Bloompedia.Models;
using Microsoft.EntityFrameworkCore;

namespace Bloompedia.Pages
{
    public class IndexModel : BaseModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BloompediaContext _context;

        public IList<Plant> allPlantsList;

        public IndexModel(ILogger<IndexModel> logger, BloompediaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task OnGetAsync()
        {
            allPlantsList = await _context.Plant.ToListAsync();
        }
    }
}
