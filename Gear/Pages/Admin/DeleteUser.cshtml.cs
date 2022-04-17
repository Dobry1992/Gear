using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Gear.Pages.Admin
{
    public class DeleteUserModel : PageModel
    {
        private readonly Gear.Data.ApplicationDbContext _context;

        public DeleteUserModel (Gear.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IdentityUser User { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if(id == string.Empty)
            {
                return NotFound();
            }

            User = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if(User == null)
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

            User = await _context.Users.FindAsync(id);

            if(User != null)
            {
                _context.Users.Remove(User);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
