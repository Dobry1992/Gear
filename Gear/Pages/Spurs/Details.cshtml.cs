using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gear.Models;
using Microsoft.AspNetCore.Authorization;

namespace Gear.Pages.Spurs
{
    [Authorize(Roles = "Designer, Admin, Master")]
    public class DetailsModel : PageModel
    {
        private readonly Data.GearContext _context;

        public DetailsModel(Data.GearContext context)
        {
            _context = context;
        }

        public Spur Spur { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Spur = await _context.Spur.FirstOrDefaultAsync(m => m.ID == id);

            if (Spur == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
