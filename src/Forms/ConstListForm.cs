
using System;
using System.Windows.Forms;
using Wallet;


namespace portfel
{
    public partial class ConstListForm : Form
    {
        public ConstListForm(MainForm parent)
        {
            InitializeComponent();

            throw new NotImplementedException();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listViewSelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listView.SelectedItems.Count < 1)
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
    }
}
