using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gear.Models;
using Microsoft.AspNetCore.Authorization;

namespace Gear.Pages.Spurs
{
    [Authorize(Roles = "Designer, Admin")]
    public class DeleteModel : PageModel
    {
        private readonly Gear.Data.GearContext _context;

        public DeleteModel(Gear.Data.GearContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Spur = await _context.Spur.FindAsync(id);

            if (Spur != null)
            {
                _context.Spur.Remove(Spur);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
