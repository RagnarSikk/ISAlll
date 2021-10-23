using System.Threading.Tasks;
using isa3.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace isa3.soft.Areas.Personal.Therapists
{
    public class CreateModel : PageModel
    {
        private readonly isa3.Infra.ApplicationDbContext _context;

        public CreateModel(isa3.Infra.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TherapistData TherapistData { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TherapistData.Add(TherapistData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
