using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gear.Models;

namespace Gear.Pages.Spurs
{
    public class IndexModel : PageModel
    {
        private readonly Data.GearContext _context;

        public IndexModel(Data.GearContext context)
        {
            _context = context;
        }

        public IList<Spur> Spur { get;set; }

        public async Task OnGetAsync()
        {
            Spur = await _context.Spur.ToListAsync();
        }
    }
}
