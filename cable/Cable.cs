using System.Collections.Generic;

namespace circuit_generator
{
    public partial class Cable
    {
        private static  List<string> MetalType = new List<string>() { Constants.Cable.MetalType.Value1, Constants.Cable.MetalType.Value2 };
        private static  List<string> Insulation_material = new List<string>() { Constants.Cable.InsulationMaterial.Value1, Constants.Cable.InsulationMaterial.Value2 };
        private static  List<string> Environment = new List<string>() { Constants.Cable.Environment.Value1, Constants.Cable.Environment.Value2 };
        private static  List<string> CurrentType = new List<string>() { Constants.Cable.CurrentType.Value1, Constants.Cable.CurrentType.Value2 };
        private static  List<string> CoreConstruction = new List<string>() { Constants.Cable.CoreConstruction.Value1, Constants.Cable.CoreConstruction.Value2 };


    }
}
