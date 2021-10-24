using isa3.Data.Others;
using isa3.Infra;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace isa3.soft.Equipments {
    public class IndexModel : PageModel {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context) {
            _context = context;
        }

        public IList<EquipmentData> EquipmentData { get; set; }

        public async Task OnGetAsync() {
            EquipmentData = await _context.EquipmentData.ToListAsync();
        }
    }
}
