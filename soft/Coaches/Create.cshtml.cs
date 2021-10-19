using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using isa3.Data.People;
using isa3.soft.Data;

namespace isa3.soft.Coaches
{
    public class CreateModel : PageModel
    {
        private readonly isa3.soft.Data.ApplicationDbContext _context;

        public CreateModel(isa3.soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CoachData CoachData { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CoachData.Add(CoachData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
