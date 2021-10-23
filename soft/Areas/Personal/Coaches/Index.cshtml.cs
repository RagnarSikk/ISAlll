using System.Collections.Generic;
using System.Threading.Tasks;
using isa3.Data.People;
using isa3.Infra;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace isa3.soft.Areas.Personal.Coaches
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CoachData> CoachData { get;set; }

        public async Task OnGetAsync()
        {
            CoachData = await _context.CoachData.ToListAsync();
        }
    }
}
