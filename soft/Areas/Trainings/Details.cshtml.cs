using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using isa3.Data.Others;
using isa3.Infra;

namespace isa3.soft.Areas.Trainings
{
    public class DetailsModel : PageModel
    {
        private readonly isa3.Infra.ApplicationDbContext _context;

        public DetailsModel(isa3.Infra.ApplicationDbContext context)
        {
            _context = context;
        }

        public TrainingData TrainingData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TrainingData = await _context.TrainingData.FirstOrDefaultAsync(m => m.Id == id);

            if (TrainingData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
