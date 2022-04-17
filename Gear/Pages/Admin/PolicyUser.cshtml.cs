using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Gear.Pages.Admin
{
    public class PolicyUserModel : PageModel
    {
        private readonly Gear.Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public PolicyUserModel (Gear.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public IdentityUser User { get; set; }

        [BindProperty]
        public IdentityRole Role { get; set; }

        [BindProperty]
        public IList<IdentityRole> RoleName { get; set; }
        [BindProperty]
        public string RName { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if(id == string.Empty)
            {
                return NotFound();
            }

            RoleName = await _context.Roles.ToListAsync();
            User = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if(User == null)
            {
                return NotFound();
            }
            return Page();
        }
        
        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if(id == string.Empty)
            {
                return NotFound();
            }

            User = await _userManager.FindByIdAsync(id);

            if(User != null)
            {
                await _userManager.AddToRoleAsync(User, RName);
            }
            return RedirectToPage("./Index");
        }
    }
}
