﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuit_generator
{
    public partial class Nagruzka
    {
        private void SelectCosphi() // Выбирает cos phi
        {
            switch (Harakter1)
            {
                case Constants.StandartNagruzka.StandartHarakter.Value1:
                    Cosphi = Constants.StandartNagruzka.StandartCosf.Value2;
                    break;
                case Constants.StandartNagruzka.StandartHarakter.Value2:
                    Cosphi = Constants.StandartNagruzka.StandartCosf.Value1;
                    break;
                case Constants.StandartNagruzka.StandartHarakter.Value3:
                    Cosphi = Constants.StandartNagruzka.StandartCosf.Value3;
                    break;
                case Constants.StandartNagruzka.StandartHarakter.Value4:
                    Cosphi = Constants.StandartNagruzka.StandartCosf.Value2;
                    break;
                case Constants.StandartNagruzka.StandartHarakter.Value5:
                    Cosphi = Constants.StandartNagruzka.StandartCosf.Value5;
                    break;
                default:
                    MessageBox.Show("Выбран неверный характер нагрузки");
                    Cosphi = Constants.StandartNagruzka.StandartCosf.Value5;
                    break;
            }
        }
    }
}
