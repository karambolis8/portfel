
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Wallet;


namespace portfel
{
    public partial class ExpenseForm : Form
    {
        public event Action<Expense, Expense> EditEvent;
        public event Action<Expense> AddEvent;

        private double value;
        private string desc, cat;

        private Expense to_edit;
        private DateTime date;
        private MainForm parent;

        private const string CALC = "calc";
        private const string CMD = "cmd";
        private const string PARAM = "/c ";


        public ExpenseForm(MainForm parent, Expense selected, string accept)
        {
            InitializeComponent();

            this.parent = parent;
            this.acceptButton.Text = accept;

            this.categoriesComboBox.Items.Clear();
            foreach(string s in parent.portfel.categories)
                this.categoriesComboBox.Items.Add(s);
            this.categoriesComboBox.Items.Remove("stałe");
            this.categoriesComboBox.SelectedItem = this.categoriesComboBox.Items[0];

            if(selected != null)
            {
                this.groupBox.Text = "Edytuj";
                this.dateTimePicker.Value = selected.date;

                this.categoriesComboBox.Text = selected.category;
                foreach(object item in this.categoriesComboBox.Items)
                    if(item as string == selected.category)
                    {
                        this.categoriesComboBox.SelectedItem = item;
                        break;
                    }

                if(selected.value < 0)
                {
                    this.valueTextBox.Text = (selected.value * -1).ToString();
                    this.outcopmRadioButton.Checked = true;
                }
                else
                {
                    this.valueTextBox.Text = selected.value.ToString();
                    this.incomeRadioButton.Checked = true;
                }

                this.descTextBox.Text = selected.description;
            }
            else
            {
                this.groupBox.Text = "Dodaj";
                this.acceptButton.Enabled = false;
            }

            this.to_edit = selected;
            this.valueTextBox.Focus();
        }
        
        
        private void okButton_Click(object sender, EventArgs e)
        {
            string text;

            this.date = this.dateTimePicker.Value.Date;
            this.desc = this.descTextBox.Text;

            if(this.value == 0)
            {
                text = "Czy na pewno chcesz dodać wydatek z zerową kwotą?";
                DialogResult result = MainForm.MessageBoxWrapper(text, MessageType.QYesNo);

                if(result != DialogResult.Yes)
                {
                    this.valueTextBox.Text = "";
                    return;
                }
            }

            if(this.categoriesComboBox.SelectedItem != null)
            {
                this.cat = this.categoriesComboBox.SelectedItem.ToString();
            }

            if(this.outcopmRadioButton.Checked)
                this.value = this.value * -1;

            Expense e2 = new Expense(this.value, this.desc, this.cat, this.date);
            
            if(this.EditEvent != null)
                this.EditEvent(this.to_edit, e2);
            
            if(this.AddEvent != null)
                this.AddEvent(e2);

            if(this.to_edit != null)
                this.Close();

            this.valueTextBox.Text = "";
            this.descTextBox.Text = "";
            this.valueTextBox.Focus();
        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.value = Convert.ToDouble(this.valueTextBox.Text);

                if(this.value < 0)
                    throw new FormatException();

                this.errorProvider.SetError(this.valueTextBox, "");
                this.acceptButton.Enabled = true;
            }
            catch(FormatException)
            {
                this.errorProvider.SetError(this.valueTextBox, "Nieprawidłowa kwota");
                this.acceptButton.Enabled = false;
            }
        }

        /// <summary>
        /// Określa zachowanie po zmianie propercji Text.
        /// </summary>
        /// <remarks>Zaznacza kategorię po wpisaniu, 
        /// lub blokuje zaakceptowanie zmian jesli wpisana kategoria nie istnieje.</remarks>
        public void comboBox_TextChanged(object sender, EventArgs e)
        {
            string c = this.categoriesComboBox.Text;

            if(this.categoriesComboBox.Items.Contains(c))
            {
                this.categoriesComboBox.SelectedIndex = this.categoriesComboBox.FindStringExact(c);
                int i = this.categoriesComboBox.Items.IndexOf(c);
                this.categoriesComboBox.SelectedItem = this.categoriesComboBox.Items[i];
                this.acceptButton.Enabled = true;
            }
            else
                this.acceptButton.Enabled = false;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ParameterizedThreadStart(this.ExecuteCommandSync));
                thread.IsBackground = true;
                thread.Priority = ThreadPriority.AboveNormal;
                thread.Start(CALC);
            }
            catch(Exception ex)
            {
                string text = "Uruchomienie kalkulatora nie powiodło się.";
                #if DEBUG
                text += "\n\n" + ex.ToString();
                #endif

                MainForm.MessageBoxWrapper(text, MessageType.EOK);
            }
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            CategoriesListForm form = new CategoriesListForm(parent);

            form.AddEvent += parent.AddCategory;
            form.EditEvent += parent.EditCategory;
            form.RemoveEvent += parent.RemoveCategory;

            form.ShowDialog(this);

            this.categoriesComboBox.Items.Clear();
            foreach(string s in parent.portfel.categories)
                this.categoriesComboBox.Items.Add(s);
            this.categoriesComboBox.Items.Remove("stałe");
            this.categoriesComboBox.SelectedItem = this.categoriesComboBox.Items[0];
        }

        /// <summary>
        /// Wykonuje polecenie synchronicznie
        /// </summary>
        /// <param name="command">Polecenie (string)</param>
        public void ExecuteCommandSync(object command)
        {
            ProcessStartInfo procStartInfo;
            procStartInfo = new ProcessStartInfo(CMD, PARAM + command);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            Process proc = new Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }
    }
}
