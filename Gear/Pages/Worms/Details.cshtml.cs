using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gear.Models;
using Microsoft.AspNetCore.Authorization;

namespace Gear.Pages.Worms
{
    [Authorize(Roles = "Master, Designer, Admin")]
    public class DetailsModel : PageModel
    {
        private readonly Gear.Data.GearContext _context;

        public DetailsModel(Gear.Data.GearContext context)
        {
            _context = context;
        }

        public Worm Worm { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Worm = await _context.Worm.FirstOrDefaultAsync(m => m.ID == id);

            if (Worm == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
