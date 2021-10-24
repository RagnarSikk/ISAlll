using isa3.Data.Others;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace isa3.soft.Areas.Trainings {
    public class IndexModel : PageModel {
        private readonly isa3.Infra.ApplicationDbContext _context;

        public IndexModel(isa3.Infra.ApplicationDbContext context) {
            _context = context;
        }

        public IList<TrainingData> TrainingData { get; set; }

        public async Task OnGetAsync() {
            TrainingData = await _context.TrainingData.ToListAsync();
        }
    }
}
