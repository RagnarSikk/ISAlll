using isa3.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace isa3.soft.Areas.Personal.Therapists {
    public class DeleteModel : PageModel {
        private readonly isa3.Infra.ApplicationDbContext _context;

        public DeleteModel(isa3.Infra.ApplicationDbContext context) {
            _context = context;
        }

        [BindProperty]
        public TherapistData TherapistData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            TherapistData = await _context.TherapistData.FirstOrDefaultAsync(m => m.Id == id);

            if (TherapistData == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            TherapistData = await _context.TherapistData.FindAsync(id);

            if (TherapistData != null) {
                _context.TherapistData.Remove(TherapistData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
