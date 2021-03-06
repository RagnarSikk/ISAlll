using isa3.Data.People;
using isa3.Infra;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace isa3.soft.Areas.Personal.Nutritionists {
    public class IndexModel : PageModel {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context) {
            _context = context;
        }

        public IList<NutritionistData> NutritionistData { get; set; }

        public async Task OnGetAsync() {
            NutritionistData = await _context.NutritionistData.ToListAsync();
        }
    }
}
