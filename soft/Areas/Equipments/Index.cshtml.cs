using System.Collections.Generic;
using System.Threading.Tasks;
using isa3.Data.Others;
using isa3.Infra;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace isa3.soft.Equipments
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
