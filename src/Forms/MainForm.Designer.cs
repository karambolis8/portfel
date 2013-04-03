
namespace portfel
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.constButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.treeViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showSelectedContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.dateColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.valueColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.categoryColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.descriptionColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.listViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.balanceValueLabel = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.removeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.filtersButton = new System.Windows.Forms.ToolStripButton();
            this.removeFiltersButton = new System.Windows.Forms.ToolStripButton();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsGroupBox.SuspendLayout();
            this.treeViewContextMenuStrip.SuspendLayout();
            this.listViewContextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.constButton);
            this.actionsGroupBox.Controls.Add(this.statsButton);
            this.actionsGroupBox.Controls.Add(this.categoriesButton);
            this.actionsGroupBox.Location = new System.Drawing.Point(12, 62);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(149, 152);
            this.actionsGroupBox.TabIndex = 0;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Akcje";
            // 
            // constButton
            // 
            this.constButton.Image = ((System.Drawing.Image)(resources.GetObject("constButton.Image")));
            this.constButton.Location = new System.Drawing.Point(7, 105);
            this.constButton.Name = "constButton";
            this.constButton.Size = new System.Drawing.Size(136, 37);
            this.constButton.TabIndex = 3;
            this.constButton.Text = "Stałe wydatki";
            this.constButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.constButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.constButton.UseVisualStyleBackColor = true;
            this.constButton.Click += new System.EventHandler(this.const_button_Click);
            // 
            // statsButton
            // 
            this.statsButton.Image = ((System.Drawing.Image)(resources.GetObject("statsButton.Image")));
            this.statsButton.Location = new System.Drawing.Point(7, 62);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(136, 37);
            this.statsButton.TabIndex = 2;
            this.statsButton.Text = "Statystyki";
            this.statsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.statsButton.UseVisualStyleBackColor = true;
            this.statsButton.Click += new System.EventHandler(this.stats_button_Click);
            // 
            // categoriesButton
            // 
            this.categoriesButton.Image = ((System.Drawing.Image)(resources.GetObject("categoriesButton.Image")));
            this.categoriesButton.Location = new System.Drawing.Point(6, 19);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(136, 37);
            this.categoriesButton.TabIndex = 0;
            this.categoriesButton.Text = "Kategorie";
            this.categoriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categoriesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.categoriesButton.UseVisualStyleBackColor = true;
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView.ContextMenuStrip = this.treeViewContextMenuStrip;
            this.treeView.Location = new System.Drawing.Point(12, 220);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(149, 334);
            this.treeView.TabIndex = 1;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            // 
            // treeViewContextMenuStrip
            // 
            this.treeViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSelectedContextMenuItem,
            this.showAllContextMenuItem});
            this.treeViewContextMenuStrip.Name = "treeViewContextMenuStrip";
            this.treeViewContextMenuStrip.Size = new System.Drawing.Size(183, 48);
            // 
            // showSelectedContextMenuItem
            // 
            this.showSelectedContextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showSelectedContextMenuItem.Image")));
            this.showSelectedContextMenuItem.Name = "showSelectedContextMenuItem";
            this.showSelectedContextMenuItem.Size = new System.Drawing.Size(182, 22);
            this.showSelectedContextMenuItem.Text = "Filtruj wybrane daty";
            this.showSelectedContextMenuItem.Click += new System.EventHandler(this.showSelectedToolStripMenuItem_Click);
            // 
            // showAllContextMenuItem
            // 
            this.showAllContextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showAllContextMenuItem.Image")));
            this.showAllContextMenuItem.Name = "showAllContextMenuItem";
            this.showAllContextMenuItem.Size = new System.Drawing.Size(182, 22);
            this.showAllContextMenuItem.Text = "Nie filtruj dat";
            this.showAllContextMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateColumnHeader,
            this.valueColumnHeader,
            this.categoryColumnHeader,
            this.descriptionColumnHeader});
            this.listView.ContextMenuStrip = this.listViewContextMenuStrip;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(215, 72);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(265, 426);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "data";
            this.dateColumnHeader.Width = 65;
            // 
            // valueColumnHeader
            // 
            this.valueColumnHeader.Text = "kwota";
            this.valueColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // categoryColumnHeader
            // 
            this.categoryColumnHeader.Text = "kategoria";
            this.categoryColumnHeader.Width = 67;
            // 
            // descriptionColumnHeader
            // 
            this.descriptionColumnHeader.Text = "opis";
            this.descriptionColumnHeader.Width = 69;
            // 
            // listViewContextMenuStrip
            // 
            this.listViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContextMenuItem,
            this.editContextMenuItem,
            this.removeContextMenuItem});
            this.listViewContextMenuStrip.Name = "contextMenuStrip";
            this.listViewContextMenuStrip.Size = new System.Drawing.Size(117, 70);
            // 
            // addContextMenuItem
            // 
            this.addContextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addContextMenuItem.Image")));
            this.addContextMenuItem.Name = "addContextMenuItem";
            this.addContextMenuItem.Size = new System.Drawing.Size(116, 22);
            this.addContextMenuItem.Text = "Dodaj";
            this.addContextMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editContextMenuItem
            // 
            this.editContextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editContextMenuItem.Image")));
            this.editContextMenuItem.Name = "editContextMenuItem";
            this.editContextMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editContextMenuItem.Text = "Edytuj";
            this.editContextMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeContextMenuItem
            // 
            this.removeContextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeContextMenuItem.Image")));
            this.removeContextMenuItem.Name = "removeContextMenuItem";
            this.removeContextMenuItem.Size = new System.Drawing.Size(116, 22);
            this.removeContextMenuItem.Text = "Usuń";
            this.removeContextMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(492, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfileToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.fileToolStripMenuItem.Text = "Plik";
            // 
            // newProfileToolStripMenuItem
            // 
            this.newProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newProfileToolStripMenuItem.Image")));
            this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
            this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newProfileToolStripMenuItem.Text = "Nowy profil";
            this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.newProfileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Otworz";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Zapisz";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Zapisz jako";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Zakończ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.optionsToolStripMenuItem.Text = "Opcje";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configureToolStripMenuItem.Text = "Konfiguracja";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.helpToolStripMenuItem.Text = "Pomoc";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "O programie";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // profileLabel
            // 
            this.profileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.profileLabel.AutoSize = true;
            this.profileLabel.Location = new System.Drawing.Point(215, 515);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(29, 13);
            this.profileLabel.TabIndex = 6;
            this.profileLabel.Text = "profil";
            // 
            // balanceLabel
            // 
            this.balanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(215, 541);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(34, 13);
            this.balanceLabel.TabIndex = 7;
            this.balanceLabel.Text = "bilans";
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.profileNameLabel.AutoSize = true;
            this.profileNameLabel.Location = new System.Drawing.Point(319, 515);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(29, 13);
            this.profileNameLabel.TabIndex = 8;
            this.profileNameLabel.Text = "jajco";
            // 
            // balanceValueLabel
            // 
            this.balanceValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balanceValueLabel.AutoSize = true;
            this.balanceValueLabel.ForeColor = System.Drawing.Color.Black;
            this.balanceValueLabel.Location = new System.Drawing.Point(319, 541);
            this.balanceValueLabel.Name = "balanceValueLabel";
            this.balanceValueLabel.Size = new System.Drawing.Size(29, 13);
            this.balanceValueLabel.TabIndex = 9;
            this.balanceValueLabel.Text = "jajco";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openButton,
            this.saveButton,
            this.toolStripSeparator1,
            this.addButton,
            this.removeButton,
            this.toolStripSeparator3,
            this.filtersButton,
            this.removeFiltersButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(492, 25);
            this.toolStrip.TabIndex = 10;
            this.toolStrip.Text = "pasek zadań";
            // 
            // newButton
            // 
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(23, 22);
            this.newButton.Text = "nowy";
            this.newButton.Click += new System.EventHandler(this.new_button_Click);
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(23, 22);
            this.openButton.Text = "otwórz";
            this.openButton.Click += new System.EventHandler(this.open_button_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 22);
            this.saveButton.Text = "zapisz";
            this.saveButton.Click += new System.EventHandler(this.save_button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // addButton
            // 
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(54, 22);
            this.addButton.Text = "dodaj";
            this.addButton.Click += new System.EventHandler(this.add_button_Click);
            // 
            // removeButton
            // 
            this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
            this.removeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(50, 22);
            this.removeButton.Text = "usuń";
            this.removeButton.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // filtersButton
            // 
            this.filtersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filtersButton.Image = ((System.Drawing.Image)(resources.GetObject("filtersButton.Image")));
            this.filtersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filtersButton.Name = "filtersButton";
            this.filtersButton.Size = new System.Drawing.Size(23, 22);
            this.filtersButton.Text = "filtruj";
            this.filtersButton.Click += new System.EventHandler(this.filters_button_Click);
            // 
            // removeFiltersButton
            // 
            this.removeFiltersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeFiltersButton.Image = ((System.Drawing.Image)(resources.GetObject("removeFiltersButton.Image")));
            this.removeFiltersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeFiltersButton.Name = "removeFiltersButton";
            this.removeFiltersButton.Size = new System.Drawing.Size(23, 22);
            this.removeFiltersButton.Text = "usuń filtry";
            this.removeFiltersButton.Click += new System.EventHandler(this.remove_filters_button_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Eksport";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 566);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.balanceValueLabel);
            this.Controls.Add(this.profileNameLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portfel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.actionsGroupBox.ResumeLayout(false);
            this.treeViewContextMenuStrip.ResumeLayout(false);
            this.listViewContextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button constButton;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Button categoriesButton;
        private System.Windows.Forms.ToolStripMenuItem newProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Label balanceValueLabel;
        public System.Windows.Forms.ColumnHeader dateColumnHeader;
        public System.Windows.Forms.ColumnHeader valueColumnHeader;
        public System.Windows.Forms.ColumnHeader categoryColumnHeader;
        public System.Windows.Forms.ColumnHeader descriptionColumnHeader;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton filtersButton;
        private System.Windows.Forms.ToolStripButton removeFiltersButton;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton removeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip listViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeContextMenuItem;
        private System.Windows.Forms.ContextMenuStrip treeViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showSelectedContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}

