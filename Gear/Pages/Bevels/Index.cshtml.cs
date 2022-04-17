using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gear.Models;

namespace Gear.Pages.Bevels
{
    public class IndexModel : PageModel
    {
        private readonly Gear.Data.GearContext _context;

        public IndexModel(Gear.Data.GearContext context)
        {
            _context = context;
        }

        public IList<Bevel> Bevel { get;set; }

        public async Task OnGetAsync()
        {
            Bevel = await _context.Bevel.ToListAsync();
        }
    }
}
