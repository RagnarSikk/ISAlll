using isa3.Data.People;
using isa3.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace isa3.soft.Areas.Personal.Nutritionists {
    public class DetailsModel : PageModel {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context) {
            _context = context;
        }

        public NutritionistData NutritionistData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            NutritionistData = await _context.NutritionistData.FirstOrDefaultAsync(m => m.Id == id);

            if (NutritionistData == null) {
                return NotFound();
            }
            return Page();
        }
    }
}
