
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Wallet;


namespace portfel
{
    /// <summary>Główne okno programu.</summary>
    public partial class MainForm : Form
    {
        #region public fields

        /// <summary>Profil uzytkownika.</summary>
        public UserProfile portfel;

        public Predicate<Expense> treeView_filter = elem => true;
        public Predicate<Expense> filterForm_filter = elem => true;

        public event Action ProfileChanged;

        #endregion


        #region private fields

        /// <summary>Czy zostały wprowadzone jakieś zmiany do profilu.</summary>
        private bool isProfileChanged;

        /// <summary>Lista wykorzystywanych dat.</summary>
        private List<Dates> dateList;

        /// <summary>Ustawienia okna aplikacji.</summary>
        private SettingsEntries settings;

        #endregion


        #region public properties

        /// <summary>Nazwa programu.</summary>
        /// <value>Zwraca nazwę programu.</value>
        /// <remarks>Wykorzystywana przy nazywaniu okien.</remarks>
        public static string caption
        {
            get
            {
                return "Portfel";
            }
        }

        #endregion


        #region constructors

        /// <summary>Towrzy okno programu.</summary>
        /// <remarks>Wywoływany, gdy uruchomieniu programu nie towarzyszy otwarcie pliku profilu.</remarks>
        public MainForm()
        {
            InitializeComponent();

            this.portfel = new UserProfile();
            this.dateList = new List<Dates>();
            this.settings = new SettingsEntries();
            this.ProfileChanged += this.OnChange;
            this.Reset();
            this.RefreshListView();
            this.UpdateForm();
        }

        /// <summary>Towrzy okno programu i wczytuje plik profilu.</summary>
        /// <param name="file">Plik profilu.</param>
        /// <remarks>Wywolywany gdy uruchomieniu programu towarzyszy otwarcie pliku profilu.</remarks>
        public MainForm(string file)
        {
            InitializeComponent();

            this.portfel = new UserProfile();
            this.dateList = new List<Dates>();
            this.settings = new SettingsEntries();
            this.ProfileChanged += this.OnChange;
            this.ReadFile(file);
            this.RefreshListView();
            this.UpdateForm();
        }

        #endregion
        

        #region window management methods

        /// <summary>Dodaje element do ListView.</summary>
        /// <param name="elem">Element do dodania.</param>
        /// <remarks>Nie dodaje wpisu, jeśli istnieje identyczny.</remarks>
        private void AddToListView(Expense elem)
        {
            Func<object, object> filter = i => (i as ListViewItem).GetExpense() == elem ? elem : null;
            object o = this.listView.Items.GetItem(filter);

            //jesli w kolekcji elem juz jest
            if(o != null)
                return;

            string[] list = new string[4] 
                {
                elem.date.ToString("dd-MM-yyyy"),
                elem.value.ToString("#,##0.00zł;-#,##0.00zł;0.00zł"),
                elem.category,
                elem.description
                };

            ListViewItem item = new ListViewItem(list);
            item.SetExpense(elem);

            int index;
            for(index = 0; index < this.listView.Items.Count; index++)
            {
                ListViewItem i = this.listView.Items[index];
                if(i.GetExpense().date.CompareTo(item.GetExpense().date) > 0)
                    break;
            }

            this.listView.Items.Insert(index, item);
        }

        /// <summary>Usuwa element z ListView.</summary>
        /// <param name="elem">Element do usunięcia.</param>
        private void RemoveFromListView(Expense elem)
        {
            Func<object, object> filter = o => (o as ListViewItem).GetExpense() == elem ? o : null;
            ListViewItem item = (ListViewItem)this.listView.Items.GetItem(filter);
            
            if(item != null)
                this.listView.Items.Remove(item);
        }

        /// <summary>Odświeża ListView.</summary>
        /// <remarks>Czyści ListView i dodaje wszystkie elementy z this.portfel.hist za pomocą AddToListView.</remarks>
        private void RefreshListView()
        {
            this.listView.Items.Clear();
            foreach(Expense elem in this.portfel.hist)
                this.AddToListView(elem);
        }

        /// <summary>Czyści główne okno programu - nowy profil.</summary>
        /// <remarks>Wprowadza główne okno w stan po stworzeniu nowego profilu (chyba nie po Polsku :/).</remarks>
        private void EnableForm()
        {
            this.actionsGroupBox.Enabled = true;
            this.filtersButton.Enabled = true;
            this.removeFiltersButton.Enabled = false;
            this.listView.Enabled = true;
            this.treeView.Enabled = true;
            this.saveToolStripMenuItem.Enabled = true;
            this.toolStrip.Enabled = true;
            this.addButton.Enabled = true;
            this.editContextMenuItem.Enabled = false;
            this.removeContextMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Enabled = true;
        }

        /// <summary>Czyści główne okno programu - brak profilu.</summary>
        /// <remarks>Blokuje główne okno, gdy żaden profil nie jest wczytany.</remarks>
        private void DisableForm()
        {
            this.actionsGroupBox.Enabled = false;
            this.listView.Enabled = false;
            this.treeView.Enabled = false;
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Enabled = false;
            this.addButton.Enabled = false;
            this.removeButton.Enabled = false;
            this.saveButton.Enabled = false;
            this.filtersButton.Enabled = false;
            this.removeFiltersButton.Enabled = false;
            this.ChangesSaved();
        }

        /// <summary>Odświeza główne okno aplikacji.</summary>
        /// <remarks>Odświeza nazwę profilu, saldo i przewija listView w dół.</remarks>
        private void UpdateForm()
        {
            this.profileNameLabel.Text = this.portfel.profile;
            
            double val = this.portfel.Balance;
            this.balanceValueLabel.Text = val.ToString("#,##0.00zł;-#,##0.00zł;0.00zł");
            if(val < 0)
                this.balanceValueLabel.ForeColor = Color.Red;
            else
                this.balanceValueLabel.ForeColor = Color.Black;
        }

        /// <summary>Resetuje profil i okno aplikacji.</summary>
        /// <remarks>Usuwa wczytany proil.</remarks>
        private void Reset()
        {
            this.profileNameLabel.Text = "";
            this.balanceValueLabel.Text = "";
            this.balanceValueLabel.ForeColor = Color.Black;
            
            this.treeView.Nodes.Clear();
            TreeNode main_node = new TreeNode("wszystkie daty");
            main_node.Name = "wszystkie daty";
            this.treeView.Nodes.Add(main_node);
            
            this.listView.Items.Clear();
            this.dateList.Clear();
            this.portfel.Reset();

            this.AddCategory("brak");
            this.AddCategory("stałe");
            this.ChangesSaved();
            
            this.DisableForm();
            this.Text = MainForm.caption;
        }

        /// <summary>Definiuje zachowanie aplikacji po wprowadzeniu zmian do profilu.</summary>
        private void OnChange()
        {
            this.isProfileChanged = true;
            this.saveToolStripMenuItem.Enabled = true;
            this.saveButton.Enabled = true;
        }

        /// <summary>Definiuje zachowanie okna po zapisaniu zmian w profilu.</summary>
        /// <remarks>Działanie przeciwne do MainForm.OnChagne.</remarks>
        private void ChangesSaved()
        {
            this.isProfileChanged = false;
            this.saveToolStripMenuItem.Enabled = false;
            this.saveButton.Enabled = false;
        }

        /// <summary>Wywoływane przy zamykaniu programu.</summary>
        /// <remarks>Pyta o zapisanie profilu i zapisuje ustawienia okna.</remarks> 
        protected override void OnClosing(CancelEventArgs e)
        {
            string text;
            DialogResult result;

            if(this.isProfileChanged)
            {
                text = "Zapisać bieżący profil?";
                result = MainForm.MessageBoxWrapper(text, MessageType.QYesNoCancel);

                if(result == DialogResult.Yes)
                {
                    if(this.portfel.path != null)
                        this.SaveProfile(this.portfel, this.portfel.path);
                    else
                        this.SaveAs(this.portfel);
                }
                else if(result == DialogResult.Cancel)
                    e.Cancel = true;
            }

            if(this.portfel.profile != null)
                this.settings.SaveSettings(this);

            base.OnClosing(e);
        }

        /// <summary>Dodaje datę wydaktu do listy.</summary>
        /// <param name="date">Data do dodania.</param>
        /// <remarks>Zwiększa ilość wpisów dla istniejącej daty lub dodaje nowy element na liscie.</remarks>
        private void AddToDateList(DateTime date)
        {
            foreach(Dates pair in this.dateList)
                if(pair.CompareTo(date))
                {
                    pair.amount++;
                    return;
                }

            this.dateList.Add(new Dates(date));
            this.AddToTreeView(date);
        }

        /// <summary>Usuwa datę wydatku z listy.</summary>
        /// <param name="date">Data do usunięcia.</param>
        /// <remarks>Zmniejsza ilość wpisów, lub usuwa wpis z listy.</remarks>
        private void RemoveFromDateList(DateTime date)
        {            
            foreach(Dates pair in this.dateList)
                if(pair.CompareTo(date))
                {
                    if(pair.amount == 1)
                        this.dateList.Remove(pair);
                    else
                        pair.amount--;
                    break;
                }
        }

        /// <summary>Dodaje datę do TreeView.</summary>
        /// <param name="date">Data do dodania.</param>
        private void AddToTreeView(DateTime date)
        {
            string d_year = date.ToString("yyyy");
            string d_month = date.ToString("MMM");
            string d_day = date.ToString("MMM-dd");

            if(!this.treeView.Nodes[0].Nodes.ContainsKey(d_year))
            {
                TreeNode day = new TreeNode(d_day);
                day.Name = d_day;
                day.Tag = date;

                TreeNode month = new TreeNode(d_month);
                month.Name = d_month;
                month.Nodes.Add(day);
                month.Tag = date;

                TreeNode year = new TreeNode(d_year);
                year.Name = d_year;
                year.Nodes.Add(month);
                year.Tag = date;

                this.treeView.Nodes[0].Nodes.Add(year);
            }

            else
            {
                Func<object, object> filter = node => (node as TreeNode).Name == d_year ? node : null;
                TreeNode year = this.treeView.Nodes[0].Nodes.GetItem(filter) as TreeNode;

                if(!year.Nodes.ContainsKey(d_month))
                {
                    TreeNode day = new TreeNode(d_day);
                    day.Name = d_day;
                    day.Tag = date;

                    TreeNode month = new TreeNode(d_month);
                    month.Name = d_month;
                    month.Nodes.Add(day);
                    month.Tag = date;

                    year.Nodes.Add(month);
                }

                else
                {
                    filter = node => (node as TreeNode).Name == d_month ? node : null;
                    TreeNode month = year.Nodes.GetItem(filter) as TreeNode;

                    if(!month.Nodes.ContainsKey(d_day))
                    {
                        TreeNode day = new TreeNode(d_day);
                        day.Name = d_day;
                        day.Tag = date;

                        month.Nodes.Add(day);
                    }
                }
            }
        }

        private void ApplyFilters()
        {
            foreach(Expense elem in this.portfel.hist)
                if(this.treeView_filter(elem))
                    this.AddToListView(elem);
        }

        #endregion


        #region buttons methods

        /// <summary>Wyświetla okno edycji kategorii.</summary>
        private void categoriesButton_Click(object sender, EventArgs e)
        {
            CategoriesListForm form = new CategoriesListForm(this);
            
            form.AddEvent += this.AddCategory;
            form.EditEvent += this.EditCategory;
            form.RemoveEvent += this.RemoveCategory;
            
            form.ShowDialog(this);
        }

        /// <summary>Wyświetla statystyki wydatków.</summary>
        private void stats_button_Click(object sender, EventArgs e)
        {
#if DEBUG
            new StatsForm(this.portfel.categories, this.portfel.hist).ShowDialog(this);
#else
            MainForm.MessageBoxWrapper("Niedostępne w tej wersji", MessageType.IOK);
#endif

        }

        /// <summary>Umożliwa zdefiniowanie stałch wydatków.</summary>
        /// <remarks>Stałe wydatki są dodawane automatycznie w zdefiniowanym czasie.</remarks>
        private void const_button_Click(object sender, EventArgs e)
        {
            MainForm.MessageBoxWrapper("Niedostępne w tej wersji", MessageType.IOK);
        }

        #endregion


        #region menu strip methods

        /// <summary>Kończy działanie programu.</summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>Wywoływane po kliknięciu menu newProfileToolStripMenuItem.</summary>
        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NewProfile();
        }

        /// <summary>Informacje o programie.</summary>
        /// <remarks>Wywoluje instancję PortfelAboutBox.</remarks>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PortfelAboutBox().ShowDialog(this);
        }
        
        /// <summary>Otwiera plik profilu.</summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenFile();
        }

        /// <summary>Zapisuje profil do wybranego pliku.</summary>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveAs(this.portfel);
        }

        /// <summary>Zapisuje profil bez potwierdzenia.</summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportForm form = new ExportForm();
            form.ExportAccepted += this.ExportExpenses;
            form.Show(this);
        }

        #endregion


        #region GUI methods

        /// <summary>
        /// Otwiera plik profilu.
        /// </summary>
        private void OpenFile()
        {
            if(this.isProfileChanged)
            {
                string text = "Zapisać bieżący profil?";
                DialogResult result = MainForm.MessageBoxWrapper(text, MessageType.QYesNo);

                if(result == DialogResult.Yes)
                    this.SaveAs(this.portfel);
            }

            if(this.portfel.profile != null)
                this.settings.SaveSettings(this);

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Plik profilu (*.pr)|*.pr";
            dialog.Multiselect = false;
            dialog.ShowDialog(this);

            if(dialog.FileName != "")
            {
                this.ReadFile(dialog.FileName);
            }
        }

        /// <summary>
        /// Zapisuje profil z wyborem ścieżki zapisu.
        /// </summary>
        private void SaveAs(UserProfile profile)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Plik profilu (*.pr)|*.pr";
            dialog.ShowDialog(this);
            if(dialog.FileName != "")
            {
                this.SaveProfile(profile, dialog.FileName);
                profile.path = dialog.FileName;
            }
        }

        /// <summary>
        /// Zapisuje profil do dotychczas używanego pliku.
        /// </summary>
        private void Save()
        {
            if(this.portfel.path != null)
                this.SaveProfile(this.portfel, this.portfel.path);
            else
                this.SaveAs(this.portfel);
        }

        /// <summary>
        /// Wyświetla okno tworzenia nowego profilu.
        /// </summary>
        /// <remarks>
        /// Ostrzega o możliwości utraty danych.
        /// </remarks>
        private void NewProfile()
        {
            DialogResult result = DialogResult.None;
            bool create = false;

            if(this.isProfileChanged)
            {
                string text = "Na pewno chcesz utowrzyć nowy profil?\nNiezapisane dane zostaną utracone.";
                result = MainForm.MessageBoxWrapper(text, MessageType.WYesNo);

                create = result == DialogResult.Yes;
            }
            else
                create = true;

            if(create)
            {
                string text = ": nowy profil";
                string label = "Podaj nazwę nowego profilu:";
                EditForm form = new EditForm(text, label);
                form.EditEvent += this.CreateNewProfile;
                form.ShowDialog(this);
            }
        }

        #endregion


        #region context menu methods

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddExpenseClick();
        }

        /// <summary>Kliknięcie na Edytuj w menu kontekstowym.</summary>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.listView.SelectedItems.Count > 0)
                this.EditExpenseClick(this.listView.SelectedItems[0].GetExpense());
        }

        /// <summary>Kliknięcie na Usuń w menu kontekstowym.</summary>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RemoveExpenseClick();
        }

        /// <summary>Filtrowanie wydatków po datach.</summary>
        private void showSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView.Items.Clear();
            this.ApplyFilters();
        }

        /// <summary>Usunięcie filtrów.</summary>
        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.treeView_filter = elem => true;

            this.listView.Items.Clear();
            this.ApplyFilters();
        }

        #endregion


        #region toolstrip methods

        /// <summary>Kliknięcie na zapisz w toolstrip.</summary>
        private void save_button_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        /// <summary>Kliknięcie na nowy profil w toolstrip.</summary>
        private void new_button_Click(object sender, EventArgs e)
        {
            this.NewProfile();
        }

        /// <summary>Kliknięcie na otwórz w toolstrip.</summary>
        private void open_button_Click(object sender, EventArgs e)
        {
            this.OpenFile();
        }

        /// <summary>Kliknięcie na usuń w toolstrip.</summary>
        private void remove_button_Click(object sender, EventArgs e)
        {
            this.RemoveExpenseClick();
        }

        /// <summary>Kliknięcie na dodaj w toolstrip.</summary>
        private void add_button_Click(object sender, EventArgs e)
        {
            this.AddExpenseClick();
        }

        /// <summary>Kliknięcie na filtruj w toolstrip.</summary>
        private void filters_button_Click(object sender, EventArgs e)
        {
            MainForm.MessageBoxWrapper("Niedostępne w tej wersji", MessageType.IOK);
        }

        /// <summary>Kliknięcie na usuń filtry w toolstrip.</summary>
        private void remove_filters_button_Click(object sender, EventArgs e)
        {
            this.RefreshListView();
            this.removeFiltersButton.Enabled = false;
        }

        #endregion


        #region click methods

        private void AddExpenseClick()
        {
            ExpenseForm form = new ExpenseForm(this, null, "Dodaj");
            form.AddEvent += this.AddExpense;
            form.ShowDialog(this);
        }

        /// <summary>Edycja wydatku.</summary>
        /// <remarks>Pobiera zaznaczony wydatek z ListView i towrzy instancję ExpenseForm.
        /// Metoda nie jest odporna na brak zaznaczenia na ListView.</remarks>
        private void EditExpenseClick(Expense to_edit)
        {
            if(to_edit.category == "stałe")
            {
                string text = "Wydatki z kategorii 'stałe' można edytować tylko z menu Stałe.";
                MainForm.MessageBoxWrapper(text, MessageType.WOK);
            }
            else
            {
                ExpenseForm form = new ExpenseForm(this, to_edit, "Edytuj");
                form.EditEvent += this.EditExpense;
                form.ShowDialog(this);
            }
        }

        /// <summary>Usunięcie wydatku.</summary>
        /// <remarks>Usuwa wszystkie zaznaczone wydatki. Nieodporne na brak zaznaczenia.</remarks>
        private void RemoveExpenseClick()
        {
            string text = "Na pewno chcesz usunąć znaznaczone wpisy?";
            DialogResult result = MainForm.MessageBoxWrapper(text, MessageType.QYesNo);

            if(result == DialogResult.Yes)
            {
                foreach(ListViewItem item in this.listView.SelectedItems)
                    this.RemoveExpense(item.GetExpense());
            }
        }

        #endregion


        #region profile file management

        /// <summary>Wczytuje plik profilu.</summary>
        /// <param name="file">Plik do wczytania.</param>
        /// <remarks>W zależności od rozszerzenia, wywołuje odpowiednią metodę do wczytania danych.</remarks>
        private void ReadFile(string file)
        {
            try
            {
                this.ReadXmlFile(file);
            }
            catch
            {
                try
                {
                    this.ReadTextFile(file);
                }
                catch(Exception ex)
                {
                    string text = "Odczyt z pliku " + file + " nie powiódł się. Plik wygląda na uszkodzony.";
#if DEBUG
                    text += "\n\n" + ex.ToString();
#endif

                    MainForm.MessageBoxWrapper(text, MessageType.WOK);
                    this.Reset();
                    this.DisableForm();
                }
            }

            if(this.listView.Items.Count > 0)
                this.listView.Items[this.listView.Items.Count - 1].EnsureVisible();

#if DEBUG
            //zapamietywac IsExpandes i zapisywac razem z ustawieniami okna - uwaga bo wpisy moga znikac
            this.treeView.Nodes[0].Expand();
#endif
        }

        /// <summary>
        /// Czyta profil z pliku XML.
        /// </summary>
        /// <param name="file">Plik profilu</param>
        /// <remarks>Nie obsługuje wyjątków.</remarks>
        private void ReadXmlFile(string file)
        {
            XmlTextReader reader = new XmlTextReader(file);

            this.Reset();

            XmlSerializer serializer = new XmlSerializer(typeof(UserProfile));

            this.portfel = serializer.Deserialize(reader) as UserProfile;

            this.portfel.path = file;

            this.portfel.categories.Sort();
            this.portfel.categories.Insert(0, "stałe");
            this.portfel.categories.Insert(0, "brak");

            this.settings.ReadSettings(this);

            this.EnableForm();
            this.UpdateForm();
            this.RefreshListView();
            this.ChangesSaved();

            this.Text = MainForm.caption + " - " + this.portfel.profile;

            foreach(Expense elem in this.portfel.hist)
                this.AddToDateList(elem.date);

            reader.Close();
        }

        /// <summary>
        /// Czyta profil z pliku txt
        /// </summary>
        /// <param name="file">Plik profilu</param>
        /// <remarks>
        /// Nie obsługuje wyjątków.</remarks>
        private void ReadTextFile(string file)
        {
            TextReader tr = new StreamReader(file);
            this.Reset();
            this.portfel.Read(tr);
            tr.Close();

            this.portfel.path = file;

            this.portfel.categories.Sort();
            this.portfel.categories.Add("stałe");
            this.portfel.categories.Add("brak");

            this.settings.ReadSettings(this);

            this.EnableForm();
            this.UpdateForm();
            this.RefreshListView();
            this.ChangesSaved();

            this.Text = MainForm.caption + " - " + this.portfel.profile;

            foreach(Expense elem in this.portfel.hist)
                this.AddToDateList(elem.date);
        }

        /// <summary>Zapisuje plik profilu.</summary>
        /// <param name="file">Ścieżka do zapisu.</param>
        private void SaveProfile(UserProfile profile, string file)
        {
            XmlTextWriter writer = new XmlTextWriter(file, Encoding.UTF8);

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UserProfile));

                writer.Formatting = Formatting.Indented;

                profile.categories.Remove("stałe");
                profile.categories.Remove("brak");

                serializer.Serialize(writer, profile);

                profile.categories.Insert(0, "stałe");
                profile.categories.Insert(0, "brak");

                this.ChangesSaved();
            }
            catch(Exception ex)
            {
                string text = "Zapis do pliku " + file + " nie powiódł się.";

#if DEBUG
                text = ex.ToString();
#endif

                MainForm.MessageBoxWrapper(text, MessageType.WOK);

                if(this.ProfileChanged != null)
                    this.ProfileChanged();
            }
            finally
            {
                writer.Close();
            }
        }

        /// <summary>Eksportuje gałąź do pliku</summary>
        /// <param name="start">Data początkowa</param>
        /// <param name="end">Data końcowa</param>
        private void ExportExpenses(DateTime start, DateTime end)
        {
            List<Expense> tmp = new List<Expense>();

            foreach(Expense e in this.portfel.hist)
#warning tu jest dobrze porownania?
                if(e.date.CompareTo(start) > 0 && e.date.CompareTo(end) < 0)
                    tmp.Add(e);

#warning dodac do Balance zeby sie kwoty zgadzaly
            foreach(Expense e in tmp)
                this.portfel.hist.Remove(e);

            UserProfile branch = new UserProfile();
            branch.categories = this.portfel.categories;
            branch.hist = tmp;
            branch.profile = this.portfel.profile;
            branch.path = null;

            this.SaveAs(branch);
            this.Save();
        }

        #endregion


        #region other

        /// <summary>Wrapper na okna komunikatow.</summary>
        /// <param name="text">Tekst do wyswietlenia w komunikacie.</param>
        /// <param name="type">Typ komunikatu.</param>
        /// <returns>Zwraca wynik okna dialogowego.</returns>
        public static DialogResult MessageBoxWrapper(string text, MessageType type)
        {
            MessageBoxButtons buttons;
            MessageBoxIcon icon;

            switch(type)
            {
                case MessageType.IOK:
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Information;
                    break;

                case MessageType.QYesNo:
                    buttons = MessageBoxButtons.YesNo;
                    icon = MessageBoxIcon.Question;
                    break;

                case MessageType.QYesNoCancel:
                    buttons = MessageBoxButtons.YesNoCancel;
                    icon = MessageBoxIcon.Question;
                    break;

                case MessageType.WOK:
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Warning;
                    break;

                case MessageType.WYesNo:
                    buttons = MessageBoxButtons.YesNo;
                    icon = MessageBoxIcon.Warning;
                    break;

                case MessageType.EYesNo:
                    buttons = MessageBoxButtons.YesNo;
                    icon = MessageBoxIcon.Error;
                    break;

                case MessageType.EOK:
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Error;
                    break;

                default:
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Information;
                    break;
            }

            return MessageBox.Show(text, MainForm.caption, buttons, icon);
        }

        /// <summary>Tworzy pusty profil.</summary>
        /// <param name="profile">Nazwa profilu.</param>
        private void CreateNewProfile(string profile)
        {
            if(profile == "")
            {
                string text = "Niedozwolona nazwa profilu!";
                MainForm.MessageBoxWrapper(text, MessageType.WOK);
                return;
            }

            this.Reset();
            this.EnableForm();
            this.Text = MainForm.caption + " - " + profile;
            this.portfel.profile = profile;
            this.portfel.path = null;
            this.UpdateForm();
        }

        /// <summary>Dodanie kategorii wydatków.</summary>
        /// <param name="cat">Nazwa kategorii.</param>
        public void AddCategory(string cat)
        {
            this.portfel.categories.Remove("brak");
            this.portfel.categories.Remove("stałe");
            this.portfel.AddCategory(cat);
            this.portfel.categories.Sort();
            this.portfel.categories.Insert(0, "stałe");
            this.portfel.categories.Insert(0, "brak");

            if(this.ProfileChanged != null)
                this.ProfileChanged();
        }

        /// <summary>Edycja kategorii wydatków.</summary>
        /// <param name="nu">Nowa kategoria.</param>
        /// <param name="old">Kategoria do nadpisania.</param>
        public void EditCategory(string nu, string old)
        {
            this.portfel.EditCategory(nu, old);

            this.RefreshListView();
            this.removeFiltersButton.Enabled = false;

            if(this.ProfileChanged != null)
                this.ProfileChanged();
        }

        /// <summary>Usunięcie kategorii.</summary>
        /// <param name="cat">Kategoria do usunięcia.</param>
        public void RemoveCategory(string cat)
        {
            this.EditCategory("brak", cat);
        }

        /// <summary>Dodanie wydatku.</summary>
        /// <param name="elem">Element reprezentujacy nowy wydatek.</param>
        private void AddExpense(Expense elem)
        {
            this.portfel.AddExpense(elem);
            this.AddToListView(elem);
            this.UpdateForm();
            if(this.ProfileChanged != null)
                this.ProfileChanged();
            this.AddToDateList(elem.date);
            this.listView.Items[this.listView.Items.Count - 1].EnsureVisible();
        }

        /// <summary>Usunięcie wydatku.</summary>
        /// <param name="elem">Element reprezentujacy wydatek do usuniecia.</param>
        private void RemoveExpense(Expense elem)
        {
            this.portfel.RemoveExpense(elem);
            this.RemoveFromListView(elem);
            this.UpdateForm();
            if(this.ProfileChanged != null)
                this.ProfileChanged();
            this.removeButton.Enabled = false;
            this.RemoveFromDateList(elem.date);
        }

        /// <summary>Edycja wydatku.</summary>
        /// <param name="to_edit">Wydatek edytowany.</param>
        /// <param name="changes">Wydatek reprezentujący zmiany.</param>
        private void EditExpense(Expense to_edit, Expense changes)
        {
            this.portfel.EditExpense(to_edit, changes);
            this.UpdateForm();
            if(this.ProfileChanged != null)
                this.ProfileChanged();
            this.RemoveFromDateList(to_edit.date);
            this.AddToDateList(changes.date);

            ListViewItem to_update = null;


            Func<object, object> filter = item => (item as ListViewItem).GetExpense() == to_edit ? item : null;
            to_update = this.listView.Items.GetItem(filter) as ListViewItem;

            to_update.SubItems[0].Text = changes.date.ToString("dd-MM-yyyy");
            to_update.SubItems[1].Text = changes.value.ToString("#,##0.00zł;-#,##0.00zł;0.00zł");
            to_update.SubItems[2].Text = changes.category;
            to_update.SubItems[3].Text = changes.description;
        }

        #endregion


        #region event methods

        /// <summary>Opisuje zachowanie okna po zaznaczeniu wydatków na ListView.</summary>
        /// <remarks>Blokuje/odblokowuje odpowiednie buttony i menu kontekstowe.</remarks>
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listView.SelectedItems.Count < 1)
            {
                this.editContextMenuItem.Enabled = false;
                this.removeContextMenuItem.Enabled = false;
                this.removeButton.Enabled = false;
            }
            else
            {
                this.editContextMenuItem.Enabled = true;
                this.removeContextMenuItem.Enabled = true;
                this.removeButton.Enabled = true;
            }

            if(this.listView.SelectedItems.Count != 1)
                this.editContextMenuItem.Enabled = false;
        }

        /// <summary>Opisuje zachowanie okna po kliknięciu kolumny w ListView.</summary>
        /// <remarks>Sortuje wg. kolumny.</remarks>
        private void listView_ColumnClick(object o, ColumnClickEventArgs e)
        {
            this.listView.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        /// <summary>Opisuje zachowanie okna po podwójnym kliknięciu na ListView.</summary>
        /// <remarks>Edytuje zaznaczony wydatek.</remarks>
        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if(this.listView.SelectedItems.Count > 0)
                this.EditExpenseClick(this.listView.SelectedItems[0].GetExpense());
            else
                this.AddExpenseClick();
        }

        /// <summary>Opisuje zachowanie okna po zaznaczeniu daty na TreeView.</summary>
        /// <remarks>Tworzy odpowiednią delegację i przypisuje ją do MainForm.filter.</remarks>
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Name == "wszystkie daty")
                this.treeView_filter = x => true;
            else
            {
                int e_year, e_month;
                switch(e.Node.Level)
                {
                    case 1:
                        e_year = ((DateTime)e.Node.Tag).Year;
                        this.treeView_filter = x => x.date.Year == e_year;
                        break;

                    case 2:
                        e_year = ((DateTime)e.Node.Tag).Year;
                        e_month = ((DateTime)e.Node.Tag).Month;
                        this.treeView_filter = x => (x.date.Year == e_year) && (x.date.Month == e_month);
                        break;

                    case 3:
                        this.treeView_filter = (x => x.date.CompareTo((DateTime)e.Node.Tag) == 0);
                        break;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(this.listView.Items.Count > 0)
                this.listView.Items[this.listView.Items.Count - 1].EnsureVisible();
        }

        #endregion
    }
}
