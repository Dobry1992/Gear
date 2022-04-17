using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gear.Models;
using Microsoft.AspNetCore.Authorization;

namespace Gear.Pages.Worms
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Worm = await _context.Worm.FindAsync(id);

            if (Worm != null)
            {
                _context.Worm.Remove(Worm);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
