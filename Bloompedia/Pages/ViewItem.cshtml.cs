using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bloompedia.Models;
using Microsoft.EntityFrameworkCore;

namespace Bloompedia.Pages
{
    public class ViewItemModel : BaseModel
    {
        private readonly BloompediaContext _context;
        public IList<Plant> allPlantsList;
        public Plant selectedPlant { get; set; }

        public ViewItemModel(BloompediaContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            // get all plants from database
            allPlantsList = await _context.Plant.ToListAsync();

            // read id from url
            int id;
            bool parseSuccess = Int32.TryParse(Request.Query["id"].ToString(), out id);
            if (parseSuccess)
            {
                // try to find a plant in the database with the matching id
                for (int i = 0; i < allPlantsList.Count(); i++)
                {
                    Plant p = allPlantsList[i];
                    if (p.PlantID == id)
                    {
                        selectedPlant = p;
                        break;
                    }
                }
            }
            else
            {
                selectedPlant = new Plant();
            }

            
        }
    }
}