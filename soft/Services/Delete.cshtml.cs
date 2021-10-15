using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using isa3.Data.Others;
using isa3.soft.Data;

namespace isa3.soft.Services
{
    public class DeleteModel : PageModel
    {
        private readonly isa3.soft.Data.ApplicationDbContext _context;

        public DeleteModel(isa3.soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ServicesData ServicesData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ServicesData = await _context.ServicesData.FirstOrDefaultAsync(m => m.Id == id);

            if (ServicesData == null)
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

            ServicesData = await _context.ServicesData.FindAsync(id);

            if (ServicesData != null)
            {
                _context.ServicesData.Remove(ServicesData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
