using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuit_generator
{
    public partial class Fider
    {
        public void SelectQFCurrent()  //Выбирает автомат по мощности фидера, добавить возможность ручного выбора автомата
        {
            // Проверка что ток не равен нулю и если он равен нулю то писать резерв
            if (this.Current > 0)
            {
            }
            else
                MessageBox.Show("Ошибка"); // Exeption Вывод ошибки тока
        }
    }
}
