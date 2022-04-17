using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gear.Models
{
    public class Spur
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Mn { get; set; } // модуль зацепления
        public double Aw { get; set; } // межосевое расстояние
        public ushort Z1 { get; set; } // число зубьев ведущей шестерни
        public ushort Z2 { get; set; } // число зубьев ведомого колеса
        public double B1 { get; set; } // ширина зубчатого венца шестерни
        public double B2 { get; set; } // ширина зубчатого венца колеса
        public double Betta { get; set; } // угол наклона зуба
        public double D1 { get; set; } // делительный диаметр шестерни
        public double D2 { get; set; } // делительный диаметр колеса
        public double Da1 { get; set; } // диаметр вершин шестерни
        public double Da2 { get; set; } // диаметр вершин колеса
        public double Df1 { get; set; } // диаметр впадин шестерни
        public double Df2 { get; set; } // диаметр впадин колеса
        public double Sc { get; set; } // постоянная хорда
        public double Hc { get; set; } // высота до постоянной хорды
    }
}
