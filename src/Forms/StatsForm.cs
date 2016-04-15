
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Wallet;
using portfel.src.Forms;


namespace portfel
{
    public partial class StatsForm : Form
    {
        private List<Expense> expenses;

        public StatsForm(List<string> categories, List<Expense> expList)
        {
            InitializeComponent();

            this.expenses = expList;
            foreach(string c in categories)
                this.categoriesListView.Items.Add(new ListViewItem(c));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in this.categoriesListView.SelectedItems)
            {
                this.categoriesListView.Items.Remove(item);
                this.filterListView.Items.Add(item);
            }
        }

        private void addAllButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in this.categoriesListView.Items)
            {
                this.categoriesListView.Items.Remove(item);
                this.filterListView.Items.Add(item);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in this.filterListView.SelectedItems)
            {
                this.filterListView.Items.Remove(item);
                this.categoriesListView.Items.Add(item);
            }
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in this.filterListView.Items)
            {
                this.filterListView.Items.Remove(item);
                this.categoriesListView.Items.Add(item);
            }
        }

        private void startDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.startDate.Enabled = this.startDateCheckBox.Checked;
        }

        private void endDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.endDate.Enabled = this.endDateCheckBox.Checked;
        }

        private void minValCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.minValTextBox.Enabled = this.minValCheckBox.Checked;
        }

        private void maxValCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.maxValTextBox.Enabled = this.maxValCheckBox.Checked;
        }

        private void acceptButton_Click(object sender, EventArgs _)
        {
            double minVal = 0;
            double maxVal = 0;

            if(this.minValCheckBox.Checked)
            {
                try
                {
                    minVal = double.Parse(this.minValTextBox.Text);
                }
                catch(FormatException)
                {
                    MainForm.MessageBoxWrapper("Błędna kwota minimalna", MessageType.WOK);
                    return;
                }
            }
            if(this.maxValCheckBox.Checked)
            {
                try
                {
                    maxVal = double.Parse(this.maxValTextBox.Text);
                }
                catch(FormatException)
                {
                    MainForm.MessageBoxWrapper("Błędna kwota maksymalna", MessageType.WOK);
                    return;
                }
            }

            Func<Expense, bool> pred = delegate(Expense e)
            {
                if(this.startDateCheckBox.Checked && e.date < this.startDate.Value)
                    return false;
                if(this.endDateCheckBox.Checked && e.date > this.endDate.Value)
                    return false;
                if(this.minValCheckBox.Checked && e.value < minVal)
                    return false;
                if(this.maxValCheckBox.Checked && e.value > maxVal)
                    return false;
                if(this.filterListView.Items.Count > 0 && !this.filterListView.Items.ContainsKey(e.category))
                    return false;
                return true;
            };

            double max = this.expenses[0].value;
            double min = this.expenses[0].value;
            double sum = 0;
            int i = 0;
            foreach(Expense e in this.expenses)
            {
                if(pred(e))
                {
                    i++;
                    sum += e.value;
                    if(e.value > max)
                        max = e.value;
                    if(e.value < min)
                        min = e.value;
                }
            }

            ChartForm chartForm = new ChartForm();
            chartForm.SetUpPieChart(this.expenses);
            chartForm.ShowDialog(this);
        }
    }
}
