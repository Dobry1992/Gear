using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Gear.Models;
using Microsoft.AspNetCore.Authorization;

namespace Gear.Pages.Bevels
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
        public Bevel Bevel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            Bevel.Zc = Math.Round((double)Math.Sqrt(Bevel.Z1*Bevel.Z1 + Bevel.Z2*Bevel.Z2), 2); // Число зубьев плоского колеса
            Bevel.Re = Math.Round((0.5*Bevel.Mt*Bevel.Zc), 2); // Внешнее конусное расстояние
            Bevel.B = Math.Round((0.3*Bevel.Re), 2); // Ширина зубчатого венца
            Bevel.Rm = Math.Round((Bevel.Re - 0.5*Bevel.B), 2); // Среднее конусное расстояние
            Bevel.Mm = Math.Round((Bevel.Mt*Bevel.Rm/Bevel.Re), 2); // Средний окружной модуль
            Bevel.Dm1 = Math.Round((Bevel.Mm*Bevel.Z1), 2); // Средний делительный диаметр ведущей шестерни
            Bevel.Dm2 = Math.Round((Bevel.Mm*Bevel.Z2), 2); // Средний делительный диаметр ведомой шестерни
            Bevel.Delta1 = Math.Round((Math.Atan(Bevel.Z1/Bevel.Z2)), 2); // Угол делительного конуса
            Bevel.Delta2 = Math.Round((Math.PI/2 - Bevel.Delta1), 2);
            Bevel.De1 = Math.Round((Bevel.Mt*Bevel.Z1), 2); // Внешний делительный диаметр ведущей шестерни
            Bevel.De2 = Math.Round((Bevel.Mt * Bevel.Z2), 2); // Внешний делительный диаметр ведомой шестерни
            Bevel.Dae1 = Math.Round((Bevel.De1 + 2*Bevel.Mt*Math.Cos(Bevel.Delta1)), 2); // Внешний диаметр вершин зубьев ведущей шестерни
            Bevel.Dae2 = Math.Round((Bevel.De2 + 2*Bevel.Mt*Math.Cos(Bevel.Delta2)), 2); // Внешний диаметр вершин зубьев ведомой шестерни
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bevel.Add(Bevel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
