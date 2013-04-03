
using System;
using System.Windows.Forms;
using Wallet;


namespace portfel
{
    public partial class ConstForm : Form
    {
        public ConstForm(MainForm parent)
        {
            InitializeComponent();

            this.edit_button.Enabled = false;
            this.delete_button.Enabled = false;

            /*foreach(ConstExpense expense in parent.portfel.const_list)
            {
                ListViewItem item = new ListViewItem(expense.name);
                item.Tag = expense;
                this.listView.Items.Add(item);
            }*/
        }


        private void add_button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listView.SelectedItems.Count < 1)
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
    }
}
