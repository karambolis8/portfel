
using System.Windows.Forms;


namespace portfel
{
    public partial class CategoriesForm : Form
    {
        public event GenDelegate<string> AddEvent;
        public event GenDelegate<string> RemoveEvent;
        public event GenPairDelegate<string> EditEvent;


        public CategoriesForm(MainForm parent)
        {
            InitializeComponent();

            foreach(string cat in parent.portfel.categories)
                this.AddToListView(cat);

            this.edit_button.Enabled = false;
            this.delete_button.Enabled = false;
        }


        private void AddToListView(string cat)
        {
            ObjectDelegate filter = it => ((ListViewItem)it).Text == cat ? it : null;
            if(this.listView.Items.GetItem(filter) != null)
                return;
                
            ListViewItem item = new ListViewItem(cat);
            this.listView.Items.Add(item);
        }

        //selection changed lepiej
        private void listView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(this.listView.SelectedItems.Count < 1)
            {
                this.edit_button.Enabled = false;
                this.delete_button.Enabled = false;
            }
            else if(this.listView.SelectedItems.Count == 1)
            {
                string item = this.listView.SelectedItems[0].Text;

                if(item == PL.CAT_CONST || item == PL.CAT_NONE)
                {
                    this.edit_button.Enabled = false;
                    this.delete_button.Enabled = false;
                }
                else
                {
                    this.edit_button.Enabled = true;
                    this.delete_button.Enabled = true;
                }
            }
            else
            {
                this.edit_button.Enabled = false;

                foreach(ListViewItem item in this.listView.SelectedItems)
                    if(item.Text == PL.CAT_NONE || item.Text == PL.CAT_CONST)
                    {
                        this.delete_button.Enabled = false;
                        return;
                    }

                this.delete_button.Enabled = true;
            }
        }


        #region button methods

        private void add_button_Click(object sender, System.EventArgs e)
        {
            string text = ": nowa kategoria";
            string label = "Podaj nową kategorię:";

            EditForm form = new EditForm(text, label);
            form.EditEvent += this.AddCategory;
            form.ShowDialog(this);

            this.edit_button.Enabled = false;
            this.delete_button.Enabled = false;
        }

        private void edit_button_Click(object sender, System.EventArgs e)
        {
            string old = this.listView.SelectedItems[0].Text;
            string text = ": edycja";
            string label = "Podaj nazwę kategorii, która ma zastąpić '" + old + "'.";

            EditForm form = new EditForm(text, label);
            form.EditEvent += x => this.EditCategory(x, old);
            form.ShowDialog(this);
        }

        private void delete_button_Click(object sender, System.EventArgs e)
        {
            string text = "Zaznaczone kategorie zostaną usunięte i zastąpione w wydatkach przez '" + PL.CAT_NONE + "'.\n";
            text += "Czy chcesz kontynuować?";

            DialogResult result = MainForm.MessageBoxWrapper(text, MessageType.QYesNo);

            if(result == DialogResult.Yes)
                foreach(ListViewItem item in this.listView.SelectedItems)
                    this.RemoveCategory(item);
            
            this.edit_button.Enabled = false;
            this.delete_button.Enabled = false;
        }

        #endregion


        #region events

        private void AddCategory(string cat)
        {
            if(cat == PL.CAT_CONST || cat == "" || cat == PL.CAT_NONE)
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
            if(new_cat == PL.CAT_CONST || new_cat == "" || new_cat == PL.CAT_NONE)
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
