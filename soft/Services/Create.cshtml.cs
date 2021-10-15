using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using isa3.Data.Others;
using isa3.soft.Data;

namespace isa3.soft.Services
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
        public ServicesData ServicesData { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ServicesData.Add(ServicesData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
