using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gear.Models
{
    public class Worm
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double M { get; set; } // модуль зацепления
        public double Aw { get; set; } // межосевое расстояние
        public ushort Z1 { get; set; } // число витков червяка
        public ushort Z2 { get; set; } // число зубьев червячного колеса
        public double Q { get; set; } // коэффициент диамтра червяка
        public string WormName { get; set; } // вид червяка
        public double D1 { get; set; } // делительный диаметр червяка
        public double D2 { get; set; } // делительный диаметр червячного колеса
        public double Gamma { get; set; } // делительный угол подъёма
        public double Da1 { get; set; } // диаметр вершин червяка
        public double Da2 { get; set; } // диаметр вершин червячного колеса
        public double Dam2 { get; set; } // наибольший диаметр червячного колеса
        public double B1 { get; set; } // длина нарезной части червяка
        public double B2 { get; set; } // ширина венца червячного колеса                            
    }
}
