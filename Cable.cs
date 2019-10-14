using System.Collections.Generic;

namespace circuit_generator
{
    public partial class Cable
    {
        //public string[] metal_type = { "медь", "алюминий" };

        public static List<string> metal_type = new List<string>() { "медь", "алюминий" };

        public static List<string> insulation_material = new List<string>() { "ПВХ", "ПЭ" };

        public static List<string> Environment = new List<string>() { "воздух", "земля" };

        public static List<string> Current_type = new List<string>() { "постоянный", "переменный" };

        public static List<string> Core_сonstruction = new List<string>() { "однопроволочный", "многопроволочный" };


    }
}
