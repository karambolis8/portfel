
using System;
using System.Collections.Generic;
using System.IO;
using portfel;
using System.Xml.Serialization;


namespace Wallet
{
    /// <summary>Klasa reprezentuj¹ca profil u¿ytkownika w programie.</summary>
    [XmlRoot("UserProfile")]
    public class UserProfile
    {
        #region public fields

        /// <summary>Nazwa profilu</summary>
        [XmlElement("profile")]
        public string profile;
        
        /// <summary>Sciezka ostatniego zapisu.</summary>
        /// <remarks>Nie jest zapisywana do pliku profilu.</remarks>
        [XmlIgnore()]
        public string path;
        
        /// <summary>Lista wydatków.</summary>
        [XmlArray("hist")]
        [XmlArrayItem("Expense", typeof(Expense))]
        public List<Expense> hist;
        
        /// <summary>Lista kategorii wydatków.</summary>
        [XmlArray("categories")]
        [XmlArrayItem("category", typeof(string))]
        public List<string> categories;

        #endregion


        #region private fields
        
        /// <summary>Przechowuje aktualne saldo profilu.</summary>
        /// <remarks>Wykorzysytwane w propercji balance.</remarks>
        private double _bal;

        #endregion


        #region constructors

        /// <summary>Konstruktor towrz¹cy nowy profil.</summary>
        /// <remarks>Tworzy psut¹ historiê wydatków, pust¹ listê kategorii, zeruje Wallet.bal, Wallet.profile i Wallet.path.</remarks>
        public UserProfile()
        {
            this.hist = new List<Expense>();
            this.categories = new List<string>();
            //this.const_expenses = new List<ConstExpense>();
            this._bal = 0;
            this.profile = null;
            this.path = null;
        }

        #endregion


        #region public properties

        /// <summary>Saldo profilu.</summary>
        /// <value>Zwraca aktualne saldo profilu.</value>
        /// <remarks>U¿ycie settera dodaje przypisywan¹ kwotê do salda.</remarks>
        [XmlAttribute("balance")]
        public double Balance
        {
            get
            {
                return Math.Round(this._bal, 2);
            }

            set
            {
                this._bal += value;
            }
        }

        #endregion

        
        /// <summary>Resetuje profil.</summary>
        /// <remarks>Wywo³uje Wallet.hist.Clear, Walle.categories.Clear, Wallet.const_expenses.Clear.</remarks>
        public void Reset()
        {
            this.hist.Clear();
            this.categories.Clear();
            this._bal = 0;
            this.profile = null;
            this.path = null;
        }

        /// <summary>Wczytuje profil z pliku.</summary>
        /// depracated!!!!!
        /// <param name="tr">Strumieñ z którego bêd¹ czytane dane.</param>
        /// <remarks>Wczytuje Wallet.profile, Wallet.hist i Wallet.categories.</remarks>
        public void Read(TextReader tr)
        {
            this.Reset();

            this.profile = tr.ReadLine();
            int elem_amount = Convert.ToInt32(tr.ReadLine());
            int category_amount = Convert.ToInt32(tr.ReadLine());

            while(category_amount > 0)
            {
                this.categories.Add(tr.ReadLine());
                category_amount--;
            }

            while(elem_amount > 0)
            {
                double val = Convert.ToDouble(tr.ReadLine());
                string desc = tr.ReadLine();
                string cat = tr.ReadLine();
                int d = Convert.ToInt32(tr.ReadLine());
                int m = Convert.ToInt32(tr.ReadLine());
                int y = Convert.ToInt32(tr.ReadLine());
                Expense e = new Expense(val, desc, cat, new DateTime(y, m, d));
                elem_amount--;

                this.AddExpense(e);
            }
        }

        /// <summary>Dodaje nowy wydatek.</summary>
        /// <param name="elem">Element dodawany do listy wydatków.</param>
        /// <remarks>Dodaje element do listy i ustala now¹ wartoœæ salda.</remarks>
        public void AddExpense(Expense elem)
        {
            this.hist.Add(elem);
            this.Balance = elem.value;
        }

        /// <summary>Usuwa wydatek.</summary>
        /// <param name="elem">Element usuwany z listy wydatków.</param>
        /// <remarks>Usuwa element z listy i ustala now¹ wartoœæ salda.</remarks>
        public void RemoveExpense(Expense elem)
        {
            this.Balance = -elem.value;
            this.hist.Remove(elem);
        }

        /// <summary>Edytuje wydatek.</summary>
        /// <param name="to_edit">Wydatek to edycji.</param>
        /// <param name="changes">Element reprezentuj¹cy zmiany.</param>
        /// <remarks>Wprowadza zmiany i ustala saldo.</remarks>
        public void EditExpense(Expense to_edit, Expense change)
        {
            this.Balance = -to_edit.value;
            this.Balance = change.value;

            to_edit.value = change.value;
            to_edit.category = change.category;
            to_edit.date = change.date;
            to_edit.description = change.description;
        }

        /// <summary>Dodaje now¹ kategoriê.</summary>
        public void AddCategory(string cat)
        {
            if(!this.categories.Contains(cat))
                this.categories.Add(cat);
        }

        /// <summary>Edytuje kategoriê.</summary>
        /// <param name="nu">Nowa kategoria.</param>
        /// <param name="old">Kategoria do nadpisania.</param>
        /// <remarks>Zamienia odpowiednim elementom star¹ kategoriê now¹, usuwa star¹ i dodaje now¹.</remarks>
        public void EditCategory(string nu, string old)
        {
            foreach(Expense elem in this.hist)
                if(elem.category.CompareTo(old) == 0)
                    elem.category = nu;

            this.categories.Remove(old);
            this.categories.Add(nu);
        }
    }
}
