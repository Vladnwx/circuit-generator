using System.Collections.Generic;

namespace circuit_generator
{
    public partial class Nagruzka
    {

        private static readonly List<double> StandartNumbersOfPhases = new List<double>() { Constants.StandartNagruzka.StandartNumbersOfPhases.Value1, Constants.StandartNagruzka.StandartNumbersOfPhases.Value2, Constants.StandartNagruzka.StandartNumbersOfPhases.Value3 }; //число фаз
                                                                                                                                                                                                                                                                               //private static readonly List<string> NumberPhases = new List<string>() { "L1", "L2", "L3", "L1 L2 L3" }; // номер фазы

        public static List<double> GetNumberOfPhases()
        {
            return StandartNumbersOfPhases;
        }
        private static readonly List<double> StandartVoltage = new List<double>() { 220D, 380D, 24D, 12D, 230D, 400D };
        public static List<double> GetStandartVoltage()
        {
            return StandartVoltage;
        }
        private static readonly List<double> StandartPower = new List<double>() { 1, 1.5D, 2D, 2.5D, 3D, 0.5D, 0.1D }; //добавить список типовых мощностей в зависимости от выбранных характеров
        public static List<double> GetStandartPower()
        {
            return StandartPower;
        }
        private static readonly List<string> Harakter = new List<string>() { "Светильники", "Розетки", "Двигатель", "Шкаф", "Комплексная нагрузка" };
        public static List<string> GetHarakter()
        {
            return Harakter;
        }
        // Характер нагрузки (двигатель, розетка, светильник, шкафчик), добавить рекомендации по ограничению одной группы освещения не более 10А. 
        //Елси нагрузка комплексная то давать возможность ввести косинус. Если розетка, то давать ввести количество розеток. 
        //Если светильники, то давать ввести количество светильников и мощность одного. 
        //Если двигатель, то запрашивать данные об установленном выключаетел в шкафу управления двигателем.

        private static readonly List<string> TypeNetwork = new List<string>() { "трехфазная разводка с ответвлением в коробке пофазно", "однофазная прямо от щита" }; // Тип применяемой сети на комплексную нагрузку
        public static List<string> GetTypeNetwork()
        {
            return TypeNetwork;
        }
        private static readonly List<double> StandartCosf = new List<double>() { 0.8, 0.85, 0.9, 0.95, 1 }; // Тип нагрузки
        public static List<double> GetStandartCosf()
        {
            return StandartCosf;
        }
        private static readonly List<string> Type = new List<string>() { "конечная", "промежуточная" }; // Тип нагрузки
        public static List<string> GetType()
        {
            return Type;
        }

    }
}
