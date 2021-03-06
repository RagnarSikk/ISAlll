using isa3.Data.Others;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace isa3.soft.Areas.Trainings {
    public class DeleteModel : PageModel {
        private readonly isa3.Infra.ApplicationDbContext _context;

        public DeleteModel(isa3.Infra.ApplicationDbContext context) {
            _context = context;
        }

        [BindProperty]
        public TrainingData TrainingData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            TrainingData = await _context.TrainingData.FirstOrDefaultAsync(m => m.Id == id);

            if (TrainingData == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            TrainingData = await _context.TrainingData.FindAsync(id);

            if (TrainingData != null) {
                _context.TrainingData.Remove(TrainingData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
