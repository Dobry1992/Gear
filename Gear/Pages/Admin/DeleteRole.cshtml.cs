using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Gear.Pages.Admin
{
    public class DeleteRoleModel : PageModel
    {
        private readonly Data.ApplicationDbContext _context;

        public DeleteRoleModel (Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IdentityRole Role { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == string.Empty)
            {
                return NotFound();
            }

            Role = await _context.Roles.FirstOrDefaultAsync(m => m.Id == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == string.Empty)
            {
                return NotFound();
            }

            Role = await _context.Roles.FindAsync(id);

            if (User != null)
            {
                _context.Roles.Remove(Role);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
