using isa3.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace isa3.soft.Areas.Personal.Physiotherapists {
    public class CreateModel : PageModel {
        private readonly isa3.Infra.ApplicationDbContext _context;

        public CreateModel(isa3.Infra.ApplicationDbContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            return Page();
        }

        [BindProperty]
        public PhysiotherapistData PhysiotherapistData { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.PhysiotherapistData.Add(PhysiotherapistData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
