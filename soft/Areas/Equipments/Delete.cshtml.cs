using isa3.Data.Others;
using isa3.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace isa3.soft.Equipments {
    public class DeleteModel : PageModel {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context) {
            _context = context;
        }

        [BindProperty]
        public EquipmentData EquipmentData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            EquipmentData = await _context.EquipmentData.FirstOrDefaultAsync(m => m.Id == id);

            if (EquipmentData == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            EquipmentData = await _context.EquipmentData.FindAsync(id);

            if (EquipmentData != null) {
                _context.EquipmentData.Remove(EquipmentData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
