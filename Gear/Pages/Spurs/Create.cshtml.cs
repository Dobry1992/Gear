using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Gear.Models;
using Microsoft.AspNetCore.Authorization;

namespace Gear.Pages.Spurs
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
        public Spur Spur { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {


            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Spur.Mn * (Spur.Z1 + Spur.Z2) / (2 * Spur.Aw) > 1 || Spur.Mn * (Spur.Z1 + Spur.Z2) / (2 * Spur.Aw) < -1)
            {
                return Content("Передача с заданными параметрами невозможна!"); // условие
            }
            else
            {
                Spur.Betta = Math.Round((Math.Acos(Spur.Mn * (Spur.Z1 + Spur.Z2) / (2 * Spur.Aw))), 2); // угол наклона
                Spur.D1 = Math.Round(((Spur.Mn * Spur.Z1) / Math.Cos(Spur.Betta)), 2); // делительный диаметр шестерни
                Spur.D2 = Math.Round(((Spur.Mn * Spur.Z2) / Math.Cos(Spur.Betta)), 2); // делительный диаметр колеса
                Spur.Da1 = Spur.D1 + 2 * Spur.Mn; // диаметр вершин зубьев шестерни
                Spur.Da2 = Spur.D2 + 2 * Spur.Mn; // диаметр вершин зубьев колеса
                Spur.Df1 = Spur.D1 - 2 * (0.25 + Spur.Mn); // диаметр впадин зубьев шестерни
                Spur.Df2 = Spur.D2 - 2 * (0.25 + Spur.Mn); // диаметр впадин зубьев колеса
                Spur.Sc = Math.Round((((Math.PI / 2) * Math.Cos(0.35) * Math.Cos(0.35)) * Spur.Mn), 2); // постоянная хорда
                Spur.Hc = Math.Round((0.5 * (2 * Spur.Mn - Spur.Sc) * Math.Tan(0.35)), 2); // высота до постоянной хорды
            }

            _context.Spur.Add(Spur);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
