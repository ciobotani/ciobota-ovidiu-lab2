using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ciobota_ovidiu_lab2.Models;

namespace ciobota_ovidiu_lab2.Data
{
    public class ciobota_ovidiu_lab2Context : DbContext
    {
        public ciobota_ovidiu_lab2Context (DbContextOptions<ciobota_ovidiu_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<ciobota_ovidiu_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<ciobota_ovidiu_lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<ciobota_ovidiu_lab2.Models.Author> Author { get; set; }
    }
}
