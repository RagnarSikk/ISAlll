﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using isa3.Data.Others;
using isa3.soft.Data;

namespace isa3.soft.Equipment
{
    public class DetailsModel : PageModel
    {
        private readonly isa3.soft.Data.ApplicationDbContext _context;

        public DetailsModel(isa3.soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public EquipmentData EquipmentData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EquipmentData = await _context.EquipmentData.FirstOrDefaultAsync(m => m.Id == id);

            if (EquipmentData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
