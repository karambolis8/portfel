
using System.Windows.Forms;
using System.Xml.Serialization;


namespace portfel
{
    [XmlRoot("ApplicationSettings")]
    public struct ApplicationSettings
    {
        [XmlElement("Width")]
        public int Width;

        [XmlElement("Height")]
        public int Height;

        [XmlElement("X")]
        public int X;

        [XmlElement("Y")]
        public int Y;

        [XmlElement("WindowState")]
        public FormWindowState WindowState;

        [XmlElement("DateColumn")]
        public int DateColumn;

        [XmlElement("ValueColumn")]
        public int ValueColumn;

        [XmlElement("CategoryColumn")]
        public int CategoryColumn;

        [XmlElement("DescriptionColumn")]
        public int DescriptionColumn;
    }
}
