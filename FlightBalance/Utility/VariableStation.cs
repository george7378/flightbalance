using FlightBalance.Utility.Enums;

namespace FlightBalance.Utility
{
    public class VariableStation : Station
    {
        #region Properties

        public override StationType Type
        {
            get
            {
                return StationType.Variable;
            }
        }

        public int MinWeight { get; set; }

        public int MaxWeight { get; set; }

        public int LastSetWeight { get; set; }

        public bool IsFuel { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Required for serialization
        /// </summary>
        public VariableStation()
        {

        }

        public VariableStation(string name, float arm, int minWeight, int maxWeight, int lastSetWeight, bool isFuel) : base(name, arm)
        {
            MinWeight = minWeight;
            MaxWeight = maxWeight;
            LastSetWeight = lastSetWeight;
            IsFuel = isFuel;
        }

        #endregion

        #region Methods

        public override Station Clone()
        {
            return new VariableStation(Name, Arm, MinWeight, MaxWeight, LastSetWeight, IsFuel);
        }

        #endregion
    }
}
