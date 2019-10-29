using System.Windows.Forms;

namespace circuit_generator
{
    public partial class Nagruzka
    {
        private void SelectNumberPhase() // Выбирает фазу, в зависимости от количества фаз
        {
            switch (NumbersOfPhases)
            {
                case 1:
                    NumberPhase = Constants.StandartNagruzka.NumberPhases.Value1;
                    break;
                case 2:
                    NumberPhase = Constants.StandartNagruzka.NumberPhases.Value5;
                    break;
                case 3:
                    NumberPhase = Constants.StandartNagruzka.NumberPhases.Value4;
                    break;
                default:
                    MessageBox.Show(text: "Количество фаз неверно");
                    NumberPhase = Constants.StandartNagruzka.NumberPhases.Value1;
                    break;
            }
        }
    }
}
