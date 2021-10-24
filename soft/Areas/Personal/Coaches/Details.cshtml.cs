using isa3.Data.People;
using isa3.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace isa3.soft.Areas.Personal.Coaches {
    public class DetailsModel : PageModel {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context) {
            _context = context;
        }

        public CoachData CoachData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            CoachData = await _context.CoachData.FirstOrDefaultAsync(m => m.Id == id);

            if (CoachData == null) {
                return NotFound();
            }
            return Page();
        }
    }
}
