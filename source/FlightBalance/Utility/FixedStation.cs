using FlightBalance.Utility.Enums;

namespace FlightBalance.Utility
{
    public class FixedStation : Station
    {
        #region Properties

        public override StationType Type
        {
            get
            {
                return StationType.Fixed;
            }
        }

        public float Weight { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Required for serialization
        /// </summary>
        public FixedStation()
        {

        }

        public FixedStation(string name, float arm, float weight) : base(name, arm)
        {
            Weight = weight;
        }

        #endregion

        #region Methods

        public override Station Clone()
        {
            return new FixedStation(Name, Arm, Weight);
        }

        #endregion
    }
}
