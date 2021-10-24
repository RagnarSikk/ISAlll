﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using isa3.Data.Others;
using isa3.Infra;

namespace isa3.soft.Areas.Trainings
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
        public TrainingData TrainingData { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TrainingData.Add(TrainingData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
