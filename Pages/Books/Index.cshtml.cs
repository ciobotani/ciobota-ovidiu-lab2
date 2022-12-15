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
    public class IndexModel : PageModel
    {
        private readonly ciobota_ovidiu_lab2.Data.ciobota_ovidiu_lab2Context _context;

        public IndexModel(ciobota_ovidiu_lab2.Data.ciobota_ovidiu_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .Include(b => b.Author)
                    .ToListAsync();

            }
        }
    }
