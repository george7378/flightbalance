using System.Drawing;
using System.Xml.Serialization;

namespace FlightBalance.Utility
{
    public class SerializableColour
    {
        #region Properties

        [XmlIgnore]
        public Color Colour { get; set; }

        public string ColourHtml
        {
            get
            {
                return ColorTranslator.ToHtml(Colour);
            }
            set
            {
                Colour = ColorTranslator.FromHtml(value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Required for serialization
        /// </summary>
        public SerializableColour()
        {

        }

        public SerializableColour(Color colour)
        {
            Colour = colour;
        }

        #endregion

        #region Methods

        public SerializableColour Clone()
        {
            return new SerializableColour(Colour);
        }

        #endregion
    }
}
