using System.Threading.Tasks;
using isa3.Data.Others;
using isa3.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace isa3.soft.Areas.Services
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public ServicesData ServicesData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ServicesData = await _context.ServicesData.FirstOrDefaultAsync(m => m.Id == id);

            if (ServicesData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
