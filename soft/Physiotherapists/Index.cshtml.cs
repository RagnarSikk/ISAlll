using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using isa3.Data.People;
using isa3.Infra;

namespace isa3.soft.Physiotherapists
{
    public class IndexModel : PageModel
    {
        private readonly isa3.Infra.ApplicationDbContext _context;

        public IndexModel(isa3.Infra.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PhysiotherapistData> PhysiotherapistData { get;set; }

        public async Task OnGetAsync()
        {
            PhysiotherapistData = await _context.PhysiotherapistData.ToListAsync();
        }
    }
}
