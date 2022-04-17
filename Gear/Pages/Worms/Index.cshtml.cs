using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gear.Data;
using Gear.Models;

namespace Gear.Pages.Worms
{
    public class IndexModel : PageModel
    {
        private readonly Gear.Data.GearContext _context;

        public IndexModel(Gear.Data.GearContext context)
        {
            _context = context;
        }

        public IList<Worm> Worm { get;set; }

        public async Task OnGetAsync()
        {
            Worm = await _context.Worm.ToListAsync();
        }
    }
}
