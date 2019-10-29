using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuit_generator
{
    public partial class Nagruzka
    {
        private void SelectVoltage() // Выбирает напряжение в зависимости от количества фаз
        {
            switch (NumbersOfPhases)
            {
                case 1:
                    Voltage = Constants.StandartNagruzka.StandartVoltage.Value1;
                    break;
                case 2:
                    Voltage = Constants.StandartNagruzka.StandartVoltage.Value2;
                    break;
                case 3:
                    Voltage = Constants.StandartNagruzka.StandartVoltage.Value2;
                    break;
                default:
                    MessageBox.Show("Выбрано неверное напряжение");
                    Voltage = Constants.StandartNagruzka.StandartVoltage.Value1;
                    break;
            }
        }
    }
}
