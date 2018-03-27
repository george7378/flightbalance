using System.Collections.Generic;

namespace FlightBalance.Utility
{
    public class Envelope
    {
        #region Properties

        public string Name { get; set; }

        public List<ChartPoint> ChartPoints { get; set; }

        public SerializableColour ChartColour { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Required for serialization
        /// </summary>
        public Envelope()
        {

        }

        public Envelope(string name, List<ChartPoint> chartPoints, SerializableColour chartColour)
        {
            Name = name;
            ChartPoints = chartPoints;
            ChartColour = chartColour;
        }

        #endregion

        #region Methods

        public Envelope Clone()
        {
            List<ChartPoint> resultChartPoints = new List<ChartPoint>();
            ChartPoints.ForEach(chartPoint => resultChartPoints.Add(chartPoint.Clone()));

            return new Envelope(Name, resultChartPoints, ChartColour.Clone());
        }

        #endregion
    }
}
