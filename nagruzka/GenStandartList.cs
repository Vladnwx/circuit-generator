using System;
using System.Collections.Generic;

namespace circuit_generator
{
    public partial class Nagruzka
    {

        public void GenStandartList()
        {
            
            listsorted.Add(Constants.Fider.Row.Phase, Convert.ToString(NumbersOfPhases));

           // listsorted.Add(Constants.Fider.Row.Phase, Convert.ToString(NumberPhase));

            listsorted.Add(Constants.Fider.Row.Voltage, Convert.ToString(Voltage));

            listsorted.Add(Constants.Fider.Row.Power, Convert.ToString(Power));

            listsorted.Add(Constants.Fider.Row.Cosphi, Convert.ToString(Cosphi));

            listsorted.Add(Constants.Fider.Row.Current, Convert.ToString(Current));

            // listsorted.Add(Constants.Fider.Row.Current, Convert.ToString(StartInBox));

            listsorted.Add(Constants.Fider.Row.Start, Convert.ToString(Start));

            listsorted.Add(Constants.Fider.Row.Destenation, Convert.ToString(Destenation));

            //listsorted.Add(Constants.Fider.Row.Destenation, Convert.ToString(Harakter));
            //listsorted.Add(Constants.Fider.Row.Destenation, Convert.ToString(TypeNetwork));
            //listsorted.Add(Constants.Fider.Row.Destenation, Convert.ToString(Type));
            listsorted.TrimExcess();
            ICollection<int> keys = listsorted.Keys;
        }


    }
}
