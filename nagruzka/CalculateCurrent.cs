using System;
using System.Windows.Forms;

namespace circuit_generator
{
    public partial class Nagruzka
    {
        private void CalculateCurrent() //Рассчитывает ток в нагрузке
        {
            try
            {
                Current = (Power * 1000) / (1.73D * Voltage * Cosphi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
