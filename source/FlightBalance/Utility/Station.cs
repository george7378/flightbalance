using FlightBalance.Utility.Enums;
using System.Xml.Serialization;

namespace FlightBalance.Utility
{
    [XmlInclude(typeof(FixedStation))]
    [XmlInclude(typeof(VariableStation))]
    public abstract class Station
    {
        #region Properties

        public abstract StationType Type { get; }

        public string Name { get; set; }

        public float Arm { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Required for serialization
        /// </summary>
        protected Station()
        {

        }

        protected Station(string name, float arm)
        {
            Name = name;
            Arm = arm;
        }

        #endregion

        #region Methods

        public abstract Station Clone();

        #endregion
    }
}
