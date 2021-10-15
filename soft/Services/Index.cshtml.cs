using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using isa3.Data.Others;
using isa3.soft.Data;

namespace isa3.soft.Services
{
    public class IndexModel : PageModel
    {
        private readonly isa3.soft.Data.ApplicationDbContext _context;

        public IndexModel(isa3.soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ServicesData> ServicesData { get;set; }

        public async Task OnGetAsync()
        {
            ServicesData = await _context.ServicesData.ToListAsync();
        }
    }
}
