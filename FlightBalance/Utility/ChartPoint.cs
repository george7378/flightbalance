
namespace FlightBalance.Utility
{
    public class ChartPoint
    {
        #region Properties

        public float Arm { get; set; }

        public float Weight { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Required for serialization
        /// </summary>
        public ChartPoint()
        {

        }

        public ChartPoint(float arm, float weight)
        {
            Arm = arm;
            Weight = weight;
        }

        #endregion

        #region Methods

        public ChartPoint Clone()
        {
            return new ChartPoint(Arm, Weight);
        }

        #endregion
    }
}
