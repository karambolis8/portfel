
using System;
using System.IO;
using System.Xml.Serialization;


namespace Wallet
{
    /// <summary>Klasa reprezentujaca wydatek.</summary>
    public class Expense
    {
        #region public fields

        /// <summary>Wartosc wydatku.</summary>
        [XmlAttribute("value")]
        public double value;

        /// <summary>Opis.</summary>
        [XmlAttribute("description")]
        public string description;
        
        /// <summary>Kategoria.</summary>
        [XmlAttribute("category")]
        public string category;
        
        /// <summary>Data.</summary>
        [XmlAttribute("date")]
        public DateTime date;

        #endregion


        /// <summary>Konstruktor towrzący nowy wydatek.</summary>
        /// <param name="value">Wartosc.</param>
        /// <param name="description">Opis.</param>
        /// <param name="category">Kategoria.</param>
        /// <param name="date">Data.</param>
        public Expense(double value, string description, string category, DateTime date)
        {
            this.value = value;
            this.description = description;
            this.category = category;
            this.date = date;
        }

        public Expense() {}
    }
}
