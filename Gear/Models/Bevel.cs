using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gear.Models
{
    public class Bevel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Z1 { get; set; } // число зубьев ведущей шестерни
        public int Z2 { get; set; } // число зубьев ведомой шестерни
        public double Mt { get; set; } // модуль
        public double Zc { get; set; } // число зубьев плоского колеса
        public double Re { get; set; } // внешнее конусное расстояние
        public double B { get; set; } // ширина зубчатого венца
        public double Mm { get; set; } // средний окружной модуль
        public double Rm { get; set; } // среднее конусное расстояние
        public double Dm1 { get; set; } // средний делительный диаметр ведущей шестерни
        public double Dm2 { get; set; } // средний делительный диаметр ведомой шестерни
        public double Delta1 { get; set; } // угол делительного конуса
        public double Delta2 { get; set; }
        public double De1 { get; set; } // внешний делительный диаметр ведущей шестерни
        public double De2 { get; set; } // внешний делительный диаметр ведомой шестерни
        public double Dae1 { get; set; } // внешний диаметр вершин зубьев ведущей шестерни
        public double Dae2 { get; set; } // внешний диаметр вершин зубьев ведомой шестерни
    }
}
