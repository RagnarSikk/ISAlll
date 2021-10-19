using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using isa3.Data.Others;
using isa3.soft.Data;

namespace isa3.soft.Equipment
{
    public class DeleteModel : PageModel
    {
        private readonly isa3.soft.Data.ApplicationDbContext _context;

        public DeleteModel(isa3.soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EquipmentData EquipmentData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EquipmentData = await _context.EquipmentData.FirstOrDefaultAsync(m => m.Id == id);

            if (EquipmentData == null)
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

            EquipmentData = await _context.EquipmentData.FindAsync(id);

            if (EquipmentData != null)
            {
                _context.EquipmentData.Remove(EquipmentData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
