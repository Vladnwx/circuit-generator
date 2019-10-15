using System.Collections.Generic;

namespace circuit_generator
{
    public partial class Cable
    {
        private static readonly List<string> MetalType = new List<string>() { "медь", "алюминий" };
        private static readonly List<string> Insulation_material = new List<string>() { "ПВХ", "ПЭ" };
        private static readonly List<string> Environment = new List<string>() { "воздух", "земля" };
        private static readonly List<string> CurrentType = new List<string>() { "постоянный", "переменный" };
        private static readonly List<string> CoreConstruction = new List<string>() { "однопроволочный", "многопроволочный" };

        public Cable()
        {
        }
    }
}
