using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using isa3.Data.People;
using isa3.Infra;

namespace isa3.soft.Coaches
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
