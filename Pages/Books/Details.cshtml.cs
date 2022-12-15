using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ciobota_ovidiu_lab2.Data;
using ciobota_ovidiu_lab2.Models;

namespace ciobota_ovidiu_lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly ciobota_ovidiu_lab2.Data.ciobota_ovidiu_lab2Context _context;

        public DetailsModel(ciobota_ovidiu_lab2.Data.ciobota_ovidiu_lab2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
