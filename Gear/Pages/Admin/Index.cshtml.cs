using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace Gear.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly Gear.Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public IndexModel (Gear.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IList<IdentityUser> User { get; set; }
        public IList<IdentityRole> Role { get; set; }
        public async Task OnGetAsync()
        {
            Role = await _context.Roles.ToListAsync();
            User = await _context.Users.ToListAsync();
        }
    }
}
