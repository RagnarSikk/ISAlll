using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using isa3.Data.People;
using isa3.soft.Data;

namespace isa3.soft.Coaches
{
    public class EditModel : PageModel
    {
        private readonly isa3.soft.Data.ApplicationDbContext _context;

        public EditModel(isa3.soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CoachData CoachData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CoachData = await _context.CoachData.FirstOrDefaultAsync(m => m.Id == id);

            if (CoachData == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CoachData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoachDataExists(CoachData.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CoachDataExists(int id)
        {
            return _context.CoachData.Any(e => e.Id == id);
        }
    }
}
