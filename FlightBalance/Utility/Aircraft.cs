using System.Collections.Generic;
using FlightBalance.Utility.Enums;

namespace FlightBalance.Utility
{
    public class Aircraft
    {
        #region Properties

        public string Callsign { get; set; }

        public string Type { get; set; }

        public UnitType LengthUnitType { get; set; }

        public UnitType WeightUnitType { get; set; }

        public string LengthUnits
        {
            get
            {
                return LengthUnitType == UnitType.Imperial ? "in" : "cm";
            }
        }

        public string WeightUnits
        {
            get
            {
                return WeightUnitType == UnitType.Imperial ? "lb" : "kg";
            }
        }

        public List<Station> Stations { get; set; }

        public List<Envelope> Envelopes { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Required for serialization
        /// </summary>
        public Aircraft()
        {

        }

        public Aircraft(string callsign, string type, UnitType lengthUnitType, UnitType weightUnitType, List<Station> stations, List<Envelope> envelopes)
        {
            Callsign = callsign;
            Type = type;
            LengthUnitType = lengthUnitType;
            WeightUnitType = weightUnitType;
            Stations = stations;
            Envelopes = envelopes;
        }

        #endregion

        #region Methods

        public Aircraft Clone()
        {
            List<Station> resultStations = new List<Station>();
            Stations.ForEach(station => resultStations.Add(station.Clone()));

            List<Envelope> resultEnvelopes = new List<Envelope>();
            Envelopes.ForEach(envelope => resultEnvelopes.Add(envelope.Clone()));

            return new Aircraft(Callsign, Type, LengthUnitType, WeightUnitType, resultStations, resultEnvelopes);
        }

        #endregion
    }
}
