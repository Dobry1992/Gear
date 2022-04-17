using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gear.Models;
using Microsoft.AspNetCore.Authorization;

namespace Gear.Pages.Bevels
{
    [Authorize(Roles = "Designer, Admin, Master")]
    public class DetailsModel : PageModel
    {
        private readonly Gear.Data.GearContext _context;

        public DetailsModel(Gear.Data.GearContext context)
        {
            _context = context;
        }

        public Bevel Bevel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bevel = await _context.Bevel.FirstOrDefaultAsync(m => m.ID == id);

            if (Bevel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
