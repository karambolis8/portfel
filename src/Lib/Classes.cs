
using System;
using System.Collections;
using System.Windows.Forms;

namespace portfel
{
    /// <summary>Klasa porównywania obiektów ListViewItem.</summary>
    class ListViewItemComparer : IComparer
    {
        /// <summary>Indeks kolumny określającej porządek sortowania.</summary>
        private int col;

        /// <summary>Konstruktor zerujący ListViewItemComparer.col.</summary>
        public ListViewItemComparer()
        {
            col = 0;
        }

        /// <remarks>Konstruktor ustalający ListViewItemComparer.col.</remarks>
        /// <param name="column">Kolumna.</param>
        public ListViewItemComparer(int column)
        {
            col = column;
        }

        /// <summary>Porównuje dwa elementy wg. wybranej kolumny.</summary>
        /// <param name="x">ListViewItem do porównania.</param>
        /// <param name="y">ListViewItem do porównania.</param>
        /// <remarks>Oba argumenty są rzutowane na ListViewItemEx.</remarks>
        public int Compare(object x, object y)
        {
            ListViewItem item1 = x as ListViewItem;
            ListViewItem item2 = y as ListViewItem;

            if(col == 0)
                return DateTime.Compare(item1.GetExpense().date, item2.GetExpense().date);

            if(col == 1)
            {
                double x1, y1;
                x1 = item1.GetExpense().value;
                y1 = item2.GetExpense().value;

                if(x1 > y1)
                    return 1;
                if(x1 < y1)
                    return -1;
                else
                    return 0;
            }

            else
                return String.Compare(item1.SubItems[col].Text, (item2.SubItems[col].Text));
        }
    }

    /// <summary>Klasa reprezentująca parę data i ilość wystąpień.</summary>
    class Dates
    {
        /// <summary>Data.</summary>
        public DateTime date;

        /// <summary>Ilość wystąpień.</summary>
        public int amount;

        /// <summary>Konstruktor tworzący instancję z podaną datą.</summary>
        /// <param name="date">Data.</param>
        /// <remarks>Tworzy parę z podaną datą i ilością równą 1.</remarks>
        public Dates(DateTime date)
        {
            this.amount = 1;
            this.date = date;
        }

        /// <summary>Porównuje daną instancję do danej daty.</summary>
        /// <param name="date_to_compare">Data, do której będzie porónywana dana instancja Dates.</param>
        public bool CompareTo(DateTime date_to_compare)
        {
            if(this.date.Day != date_to_compare.Day)
                return false;
            if(this.date.Month != date_to_compare.Month)
                return false;
            if(this.date.Year != date_to_compare.Year)
                return false;
            return true;
        }
    }

    /// <summary>Typ wyliczeniowy opisujacy typy okien komunikatow.</summary>
    /// <remarks>Wykorzystywany w MainForm.MessageBoxWrapper</remarks>
    public enum MessageType
    {
        /// <summary>pytanie, Tak/Nie</summary>
        QYesNo,
        /// <summary>pytanie, Tak/Nie/Anuluj</summary>
        QYesNoCancel,
        /// <summary>ostrzezenie, OK</summary>
        WOK,
        /// <summary>ostrzezenie, Tak/Nie</summary>
        WYesNo,
        /// <summary>informacja, OK</summary>
        IOK,
        /// <summary>błąd, Tak/Nie</summary>
        EYesNo,

        EOK
    }
}