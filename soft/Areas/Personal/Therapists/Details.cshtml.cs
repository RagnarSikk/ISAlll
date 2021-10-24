using isa3.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace isa3.soft.Areas.Personal.Therapists {
    public class DetailsModel : PageModel {
        private readonly isa3.Infra.ApplicationDbContext _context;

        public DetailsModel(isa3.Infra.ApplicationDbContext context) {
            _context = context;
        }

        public TherapistData TherapistData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            TherapistData = await _context.TherapistData.FirstOrDefaultAsync(m => m.Id == id);

            if (TherapistData == null) {
                return NotFound();
            }
            return Page();
        }
    }
}
