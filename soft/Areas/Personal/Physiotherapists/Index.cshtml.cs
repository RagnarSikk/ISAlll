using isa3.Data.People;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace isa3.soft.Areas.Personal.Physiotherapists {
    public class IndexModel : PageModel {
        private readonly isa3.Infra.ApplicationDbContext _context;

        public IndexModel(isa3.Infra.ApplicationDbContext context) {
            _context = context;
        }

        public IList<PhysiotherapistData> PhysiotherapistData { get; set; }

        public async Task OnGetAsync() {
            PhysiotherapistData = await _context.PhysiotherapistData.ToListAsync();
        }
    }
}
