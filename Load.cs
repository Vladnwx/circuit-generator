using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuit_generator
{
    class Load
    {
        public string number_of_phases { get; set; } // Количество фаз
        public double power { get; set; } // Мощность в кВт
        public double cosphi { get; set; } // Косинус нагрузки 
        public string Source_load { get; set; } // Местоположение нагрузки
        public string Type_load { get; set; } // Тип нагрузки (конечная или промежуточная) 
    }
}
