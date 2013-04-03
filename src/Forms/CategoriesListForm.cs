
using System;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;


namespace portfel
{
    public partial class CategoriesListForm : Form
    {
        public event Action<string> AddEvent;
        public event Action<string> RemoveEvent;
        public event Action<string, string> EditEvent;


        public CategoriesListForm(MainForm parent)
        {
            InitializeComponent();

            foreach(string cat in parent.portfel.categories)
                this.AddToListView(cat);

            this.editButton.Enabled = false;
            this.deleteButton.Enabled = false;
        }


        private void AddToListView(string cat)
        {
            Func<object, object> filter = it => ((ListViewItem)it).Text == cat ? it : null;
            if(this.listView.Items.GetItem(filter) != null)
                return;
                
            ListViewItem item = new ListViewItem(cat);
            this.listView.Items.Add(item);
        }

        private void listView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(this.listView.SelectedItems.Count < 1)
            {
                this.editButton.Enabled = false;
                this.deleteButton.Enabled = false;
            }
            else if(this.listView.SelectedItems.Count == 1)
            {
                string item = this.listView.SelectedItems[0].Text;

                if(item == "stałe" || item == "brak")
                {
                    this.editButton.Enabled = false;
                    this.deleteButton.Enabled = false;
                }
                else
                {
                    this.editButton.Enabled = true;
                    this.deleteButton.Enabled = true;
                }
            }
            else
            {
                this.editButton.Enabled = false;

                foreach(ListViewItem item in this.listView.SelectedItems)
                    if(item.Text == "brak" || item.Text == "stałe")
                    {
                        this.deleteButton.Enabled = false;
                        return;
                    }

                this.deleteButton.Enabled = true;
            }
        }


        #region button methods

        private void addButton_Click(object sender, System.EventArgs e)
        {
            string text = ": nowa kategoria";
            string label = "Podaj nową kategorię:";

            EditForm form = new EditForm(text, label);
            form.EditEvent += this.AddCategory;
            form.ShowDialog(this);

            this.editButton.Enabled = false;
            this.deleteButton.Enabled = false;
        }

        private void editButton_Click(object sender, System.EventArgs e)
        {
            string old = this.listView.SelectedItems[0].Text;
            string text = ": edycja";
            string label = "Podaj nazwę kategorii, która ma zastąpić '" + old + "'.";

            EditForm form = new EditForm(text, label);
            form.EditEvent += x => this.EditCategory(x, old);
            form.ShowDialog(this);
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            string text = "Zaznaczone kategorie zostaną usunięte i zastąpione w wydatkach przez 'brak'.\n";
            text += "Czy chcesz kontynuować?";

            DialogResult result = MainForm.MessageBoxWrapper(text, MessageType.QYesNo);

            if(result == DialogResult.Yes)
                foreach(ListViewItem item in this.listView.SelectedItems)
                    this.RemoveCategory(item);
            
            this.editButton.Enabled = false;
            this.deleteButton.Enabled = false;
        }

        #endregion


        #region events

        private void AddCategory(string cat)
        {
            if(cat == "stałe" || cat == "" || cat == "brak")
            {
                MainForm.MessageBoxWrapper("Niedozwolona nazwa kategorii!", MessageType.WOK);
                return;
            }

            this.AddEvent(cat);
            this.AddToListView(cat);
        }

        private void RemoveCategory(ListViewItem item)
        {
            this.RemoveEvent(item.Text);
            this.listView.Items.Remove(item);
        }

        private void EditCategory(string new_cat, string old_cat)
        {
            if(new_cat == "stałe" || new_cat == "" || new_cat == "brak")
            {
                MainForm.MessageBoxWrapper("Niedozwolona nazwa kategorii!", MessageType.WOK);
                return;
            }

            this.EditEvent(new_cat, old_cat);

            foreach(ListViewItem item in this.listView.Items)
                if(item.Text == old_cat)
                {
                    item.Text = new_cat;
                    break;
                }
        }

        #endregion
    }
}
