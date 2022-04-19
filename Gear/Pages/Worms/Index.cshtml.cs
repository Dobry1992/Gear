using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gear.Models;

namespace Gear.Pages.Worms
{
    public class IndexModel : PageModel
    {
        private readonly Data.GearContext _context;

        public IndexModel(Data.GearContext context)
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
