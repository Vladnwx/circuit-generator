using System.Collections.Generic;

namespace circuit_generator
{
    public partial class Avtomat
    {
        public static List<string> polus = new List<string>() { "1P", "2P", "3P", "4P" };

        public static List<string> har_type = new List<string>() { "A", "B", "C", "D" };

        public static List<string> type = new List<string>() { "Автоматический выключатель", "Устройство защитного отключения", "Выключатель нагрузки", "Автоматический выключатель + Устройство защитного отключения", "Дифференциальный автоматический выключатель" };

        public static List<string> manufacturer = new List<string>() { "Schneider Electric", "Siemens", "ABB", "IEK" };

        public static List<string> series = new List<string>() { "IC60N" };

        public static List<string> setpoint = new List<string>() { "6A", "10A", "16A", "20A", "25A", "32A", "40A", "50A", "63A", "80A", "100A", "125A", "160A", "200A", "250A", "315A", "355A", "400A", "500A", "630A", "800A", "1000A", "1200A", "1600A", "2000A", "2500A", "3200A", "4000A", "5000A", "6300A" };
    }
}
