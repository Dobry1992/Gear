using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Gear.Models;
using Microsoft.AspNetCore.Authorization;

namespace Gear.Pages.Worms
{
    [Authorize(Roles = "Designer, Admin")]
    public class CreateModel : PageModel
    {
        private readonly Data.GearContext _context;

        public CreateModel(Data.GearContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Worm Worm { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            Worm.D1 = Math.Round((Worm.M * Worm.Q), 2); // делительный диаметр червяка
            Worm.D2 = Math.Round((Worm.M * Worm.Z2), 2); // делительный диаметр червячного колеса
            Worm.Gamma = Math.Round(Math.Atan((Worm.Z1/Worm.Q)), 2); // делительный угол подъема
            Worm.Da1 = Math.Round((Worm.D1 + 2*Worm.M), 2); // диаметр вершин витков червяка
            Worm.Da2 = Math.Round(Worm.D2 + 2*Worm.M); // диаметр вершин зубьев червячного колеса
            Worm.Dam2 = Math.Round(Worm.Da2 + 6*Worm.M/(Worm.Z1 + 2)); // наибольший диаметр червячного колеса
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Worm.Add(Worm);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
