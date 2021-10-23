using System.Collections.Generic;
using System.Threading.Tasks;
using isa3.Data.People;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace isa3.soft.Areas.Personal.Therapists
{
    public class IndexModel : PageModel
    {
        private readonly isa3.Infra.ApplicationDbContext _context;

        public IndexModel(isa3.Infra.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<TherapistData> TherapistData { get;set; }

        public async Task OnGetAsync()
        {
            TherapistData = await _context.TherapistData.ToListAsync();
        }
    }
}
