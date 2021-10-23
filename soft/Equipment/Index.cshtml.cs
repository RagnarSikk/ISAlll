using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using isa3.Data.Others;
using isa3.Infra;

namespace isa3.soft.Equipment
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<EquipmentData> EquipmentData { get;set; }

        public async Task OnGetAsync()
        {
            EquipmentData = await _context.EquipmentData.ToListAsync();
        }
    }
}
