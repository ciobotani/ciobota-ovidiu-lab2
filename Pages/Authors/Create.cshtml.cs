﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ciobota_ovidiu_lab2.Data;
using ciobota_ovidiu_lab2.Models;

namespace ciobota_ovidiu_lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly ciobota_ovidiu_lab2.Data.ciobota_ovidiu_lab2Context _context;

        public CreateModel(ciobota_ovidiu_lab2.Data.ciobota_ovidiu_lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
