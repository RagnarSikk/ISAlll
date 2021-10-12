using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using isa3.Data.Others;
using isa3.soft.Data;

namespace isa3.soft
{
    public class DeleteModel : PageModel
    {
        private readonly isa3.soft.Data.ApplicationDbContext _context;

        public DeleteModel(isa3.soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TrainingData = await _context.TrainingData.FindAsync(id);

            if (TrainingData != null)
            {
                _context.TrainingData.Remove(TrainingData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
