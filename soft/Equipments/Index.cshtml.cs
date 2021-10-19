using System.Collections.Generic;
using System.Threading.Tasks;
using isa3.Data.Others;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace isa3.soft.Equipments
{
    public class IndexModel : PageModel
    {
        private readonly isa3.soft.Data.ApplicationDbContext _context;

        public IndexModel(isa3.soft.Data.ApplicationDbContext context)
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
