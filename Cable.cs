using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuit_generator
{
    class Cable
    {
        /*  private SortedList<string, string> conductor_material = new SortedList<string, string>(); // Сортированный список материалов жил кабеля
          conductor_material.Add("cu", "медь");
          conductor_material.Add("al", "алюминий");

          SortedList<string, string> insulation_material =
              new SortedList<string, string>(); //Сортированный список материалов изоляции кабеля
          insulation_material.Add("pvh", "ПВХ");
          insulation_material.Add("pe", "ПЭ");

          SortedList<string, string> environment =
              new SortedList<string, string>(); //Сортированный список среды, в которой прокладывается кабель
          environment.Add("air", "воздух");
           environment.Add("ground", "земля");

          SortedList<string, string> current_type =
              new SortedList<string, string>(); //Сортированный список рода тока
          current_type.Add("dc", "постоянный");
           current_type.Add("ac", "переменный");

          SortedList<string, string> core_сonstruction =
              new SortedList<string, string>(); //Сортированный список конструкций жилы
          core_сonstruction.Add("mo", "однопроволочный");
           core_сonstruction.Add("mn", "многопроволочный");

          SortedList<string, string> number_of_cores_in_cable =
              new SortedList<string, string>(); //Сортированный список количество жил в кабеле

          public SortedList<string, string> Conductor_material { get => conductor_material; set => conductor_material = value; }

          number_of_cores_in_cable.Add("odnojil", "одножильный");
           number_of_cores_in_cable.Add("mnogojil", "многожильный");


     

        SortedList<string, string> Cable_metal_type = new SortedList<string, string>();

        Cable_metal_type.

        Cable_metal_type.Add("cu", "Cu");
            Cable_metal_type.Add("al", "Al");
            ICollection<string> Keys_cable_metal_type = Cable_metal_type.Keys;
            foreach (string i in Keys_cable_metal_type)
            Console.WriteLine("Key: {0}, Value: {1}", i, Cable_metal_type[i]);
        
         SortedList<string, string> Cable_insulation_type = new SortedList<string, string>();
        Cable_insulation_type.Add("pvc", "ПВХ");
            Cable_insulation_type.Add("pe", "ПЭ");
            ICollection<string> Keys_cable_insulation_type = Cable_insulation_type.Keys;
            foreach (string i in Keys_cable_insulation_type)
            Console.WriteLine("Key: {0}, Value: {1}", i, Cable_insulation_type[i]);
        
        SortedList<string, string> Cabel_jila = new SortedList<string, string>();
        Cabel_jila.Add("single_core", "одножильный");
            Cabel_jila.Add("stranded", "многожильный");
            ICollection<string> Keys_cabel_jila = Cabel_jila.Keys;
            foreach (string i in Keys_cabel_jila)
            Console.WriteLine("Key: {0}, Value: {1}", i, Cabel_jila[i]);
       
        SortedList<string, string> Current_type = new SortedList<string, string>();
        Current_type.Add("ac", "переменный");
            Current_type.Add("dc", "постоянный");
            ICollection<string> Keys_current_type = Current_type.Keys;
            foreach (string i in Keys_current_type)
            Console.WriteLine("Key: {0}, Value: {1}", i, Current_type[i]);
        
        SortedList<string, string> Environment_type = new SortedList<string, string>();
        Environment_type.Add("earth", "земля");
            Environment_type.Add("air", "воздух");
            ICollection<string> Keys_environment_type = Environment_type.Keys;
            foreach (string i in Keys_environment_type)
            Console.WriteLine("Key: {0}, Value: {1}", i, Environment_type[i]);
        
        SortedList<string, string> Prokladka_type = new SortedList<string, string>();
        Prokladka_type.Add("single", "одиночная");
            Prokladka_type.Add("group", "групповая");
            ICollection<string> Keys_prokladka_type = Prokladka_type.Keys;
            foreach (string i in Keys_prokladka_type)
            Console.WriteLine("Key: {0}, Value: {1}", i, Prokladka_type[i]);
        
        SortedList<string, string> Number_of_phases = new SortedList<string, string>();
        Number_of_phases.Add("1", "однофазная");
            Number_of_phases.Add("2", "двухфазная");
            Number_of_phases.Add("3", "трехфазная");
            ICollection<string> Keys_number_of_phases = Number_of_phases.Keys;
            foreach (string i in Keys_number_of_phases)
            Console.WriteLine("Key: {0}, Value: {1}", i, Number_of_phases[i]);
        
           SortedList<string, string> Standart_voltage = new SortedList<string, string>();
        Standart_voltage.Add("220", "220");
            Standart_voltage.Add("380", "380");
            Standart_voltage.Add("24", "24");
            ICollection<string> Keys_standart_voltage = Standart_voltage.Keys;
            foreach (string i in Keys_standart_voltage)
            Console.WriteLine("Key: {0}, Value: {1}", i, Standart_voltage[i]);
        
        SortedList<string, string> QF_p_fider = new SortedList<string, string>();
        QF_p_fider.Add("1", "1P");
            QF_p_fider.Add("2", "2P");
            QF_p_fider.Add("3", "3P");
            QF_p_fider.Add("4", "4P");
            ICollection<string> Keys_QF_p_fider = QF_p_fider.Keys;
            foreach (string i in Keys_QF_p_fider)
            Console.WriteLine("Key: {0}, Value: {1}", i, QF_p_fider[i]);
        
        SortedList<string, string> QF_har_type = new SortedList<string, string>();
        QF_har_type.Add("A", "A");
            QF_har_type.Add("B", "B");
            QF_har_type.Add("C", "C");
            QF_har_type.Add("D", "D");
            ICollection<string> Keys_QF_har_type = QF_har_type.Keys;
            foreach (string i in Keys_QF_har_type)
            Console.WriteLine("Key: {0}, Value: {1}", i, QF_har_type[i]);
        
        SortedList<string, string> QF_har_type = new SortedList<string, string>();
        QF_har_type.Add("QF", "Автоматический выключатель");
            QF_har_type.Add("QD", "Устройство защитного отключения");
            QF_har_type.Add("QS", "Выключатель нагрузки");
            QF_har_type.Add("QF+QD", "Автоматический выключатель + Устройство защитного отключения");
            QF_har_type.Add("QFD", "Дифференциальный автоматический выключатель");
            ICollection<string> Keys_QF_har_type = QF_har_type.Keys;
            foreach (string i in Keys_QF_har_type)
            Console.WriteLine("Key: {0}, Value: {1}", i, QF_har_type[i]);
        
        SortedList<string, string> QF_manufacturer = new SortedList<string, string>();
        QF_manufacturer.Add("SE", "Schneider Electric");
            QF_manufacturer.Add("Si", "Siemens");
            QF_manufacturer.Add("ABB", "ABB");
            QF_manufacturer.Add("IEK", "IEK");
            ICollection<string> Keys_QF_manufacturer = QF_manufacturer.Keys;
            foreach (string i in Keys_QF_manufacturer)
            Console.WriteLine("Key: {0}, Value: {1}", i, QF_manufacturer[i]);
        
        SortedList<string, string> QF_type_fider = new SortedList<string, string>();
        QF_type_fider.Add("IC60N", "IC60N");
            ICollection<string> Keys_QF_type_fider = QF_type_fider.Keys;
            foreach (string i in Keys_QF_type_fider)
            Console.WriteLine("Key: {0}, Value: {1}", i, QF_type_fider[i]);
        
        SortedList<string, string> QF_setpoint_fider = new SortedList<string, string>();
        QF_setpoint_fider.Add("6", "6A");
            QF_setpoint_fider.Add("10", "10A");
            QF_setpoint_fider.Add("16", "16A");
            QF_setpoint_fider.Add("20", "20A");
            QF_setpoint_fider.Add("25", "25A");
            QF_setpoint_fider.Add("32", "32A");
            QF_setpoint_fider.Add("40", "40A");
            QF_setpoint_fider.Add("50", "50A");
            QF_setpoint_fider.Add("63", "63A");
            QF_setpoint_fider.Add("80", "80A");
            QF_setpoint_fider.Add("100", "100A");
            QF_setpoint_fider.Add("125", "125A");
            QF_setpoint_fider.Add("160", "160A");
            QF_setpoint_fider.Add("200", "200A");
            QF_setpoint_fider.Add("250", "250A");
            QF_setpoint_fider.Add("315", "315A");
            QF_setpoint_fider.Add("355", "330A");
            QF_setpoint_fider.Add("400", "400A");
            QF_setpoint_fider.Add("500", "500A");
            QF_setpoint_fider.Add("630", "630A");
            QF_setpoint_fider.Add("800", "800A");
            QF_setpoint_fider.Add("1000", "1000A");
            QF_setpoint_fider.Add("1200", "1200A");
            QF_setpoint_fider.Add("1600", "1600A");
            QF_setpoint_fider.Add("2000", "2000A");
            QF_setpoint_fider.Add("2500", "2500A");
            QF_setpoint_fider.Add("3200", "3200A");
            QF_setpoint_fider.Add("4000", "4000A");
            QF_setpoint_fider.Add("5000", "5000A");
            QF_setpoint_fider.Add("6300", "6300A");
            ICollection<string> Keys_QF_setpoint_fider = QF_setpoint_fider.Keys;
            foreach (string i in Keys_QF_setpoint_fider)
            Console.WriteLine("Key: {0}, Value: {1}", i, QF_setpoint_fider[i]);
    
    */

    }
}
