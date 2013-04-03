
using System;
using System.Collections;
using System.Windows.Forms;
using Wallet;


namespace portfel
{
    /// <summary>
    /// Metody rozszerzające
    /// </summary>
    public static class Extensions
    {
        public static Expense GetExpense(this ListViewItem item)
        {
            return item.Tag as Expense;
        }

        public static void SetExpense(this ListViewItem item, Expense expense)
        {
            item.Tag = expense;
        }

        public static object GetItem(this ICollection collection, Func<object, object> filter)
        {
            foreach(object o in collection)
                if(filter(o) != null)
                    return filter(o);

            return null;
        }
    }
}
