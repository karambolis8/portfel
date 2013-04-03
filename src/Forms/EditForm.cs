
using System;
using System.Windows.Forms;


namespace portfel
{
    public partial class EditForm : Form
    {
        public event Action<string> EditEvent;

        public EditForm(string text, string label)
        {
            InitializeComponent();
            this.Text += text;
            this.label.Text = label;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.EditEvent(this.textBox.Text);
        }
    }
}
