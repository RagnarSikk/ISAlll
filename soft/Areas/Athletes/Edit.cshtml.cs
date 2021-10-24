﻿using System.Linq;
using System.Threading.Tasks;
using isa3.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace isa3.soft.Areas.Athletes
{
    public class EditModel : PageModel
    {
        private readonly isa3.Infra.ApplicationDbContext _context;

        public EditModel(isa3.Infra.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AthleteData AthleteData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AthleteData = await _context.AthleteData.FirstOrDefaultAsync(m => m.Id == id);

            if (AthleteData == null)
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

            _context.Attach(AthleteData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AthleteDataExists(AthleteData.Id))
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

        private bool AthleteDataExists(int id)
        {
            return _context.AthleteData.Any(e => e.Id == id);
        }
    }
}