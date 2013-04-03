
using System.Windows.Forms;
using System;
using Wallet;


namespace portfel
{
    public partial class ConstExpenseForm : Form
    {
        private double value;
        private string name;
        private bool c_name;
        private bool c_value;
        private bool c_domain;
        

        public ConstExpenseForm(string text, string button)
        {
            InitializeComponent();

            this.dateDomainUpDown.Enabled = false;
            this.Text += text;
            this.acceptButton.Text = button;
            this.acceptButton.Enabled = false;
            this.c_name = false;
            this.c_value = false;
            this.c_domain = false;
        }


        private void acceptButton_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void valueTextBox_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.value = Convert.ToDouble(this.valueTextBox.Text);
                this.c_value = true;
                
                if(this.c_name && this.c_domain)
                    this.acceptButton.Enabled = true;
            }
            catch(FormatException)
            {
                this.acceptButton.Enabled = false;
                this.c_value = false;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(this.nameTextBox.Text == "")
                this.c_name = false;
            else
            {
                this.name = this.nameTextBox.Text;
                this.c_name = true;
            }

            if(this.c_name && this.c_value && this.c_domain)
                this.acceptButton.Enabled = true;
            else
                this.acceptButton.Enabled = false;
        }

        private void dayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(this.dayRadioButton.Checked)
            {
                this.dateDomainUpDown.Enabled = false;
                this.date_label.Text = "";
                this.c_domain = true;
            }
        }

        private void weekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(this.weekRadioButton.Checked)
            {
                this.dateDomainUpDown.Enabled = true;
                this.dateDomainUpDown.Text = "";
                this.date_label.Text = "dzień tygodnia";

                this.dateDomainUpDown.Items.Clear();
                this.dateDomainUpDown.Items.Add("poniedziałek");
                this.dateDomainUpDown.Items.Add("wtorek");
                this.dateDomainUpDown.Items.Add("środa");
                this.dateDomainUpDown.Items.Add("czwartek");
                this.dateDomainUpDown.Items.Add("piątek");
                this.dateDomainUpDown.Items.Add("sobota");
                this.dateDomainUpDown.Items.Add("niedziela");
            }
        }

        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(this.monthRadioButton.Checked)
            {
                this.dateDomainUpDown.Enabled = true;
                this.date_label.Text = "dzień miesiąca";
                this.dateDomainUpDown.Text = "";

                this.dateDomainUpDown.Items.Clear();
                for(int i = 1; i <= 31; i++)
                    this.dateDomainUpDown.Items.Add(i);
            }
        }

        private void dateDomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            if(this.dateDomainUpDown.Text == "")
            {
                this.c_domain = false;
                this.acceptButton.Enabled = false;
            }
            else
                this.c_domain = true;

            if(this.c_domain && this.c_name && this.c_value)
                this.acceptButton.Enabled = true;
        }
    }
}
