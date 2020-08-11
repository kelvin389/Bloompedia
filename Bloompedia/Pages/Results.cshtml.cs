using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bloompedia.Models;
using Microsoft.EntityFrameworkCore;

namespace Bloompedia.Pages
{
    public class ResultsModel : BaseModel
    {
        private readonly BloompediaContext _context;
        public IList<Plant> allPlantsList;
        public IList<Plant> searchedPlantsList = new List<Plant>();

        public ResultsModel(BloompediaContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            allPlantsList = await _context.Plant.ToListAsync();

            string query = search.ToLower();

            // iterate through plantsList
            for (int i = 0; i < allPlantsList.Count(); i++)
            {
                string c = allPlantsList[i].Colour.ToLower();
                if (c.Equals(query))
                {
                    searchedPlantsList.Add(allPlantsList[i]);
                }
            }
        }
    }
}