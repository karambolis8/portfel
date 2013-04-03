
namespace portfel
{
    partial class StatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsForm));
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.categoriesListView = new System.Windows.Forms.ListView();
            this.categoryColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.filterListView = new System.Windows.Forms.ListView();
            this.categoryColumn = new System.Windows.Forms.ColumnHeader();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.minValCheckBox = new System.Windows.Forms.CheckBox();
            this.maxValCheckBox = new System.Windows.Forms.CheckBox();
            this.minValTextBox = new System.Windows.Forms.TextBox();
            this.maxValTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.startDateCheckBox = new System.Windows.Forms.CheckBox();
            this.endDateCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.descCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.Enabled = false;
            this.startDate.Location = new System.Drawing.Point(68, 45);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(131, 20);
            this.startDate.TabIndex = 2;
            // 
            // endDate
            // 
            this.endDate.Enabled = false;
            this.endDate.Location = new System.Drawing.Point(68, 75);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(131, 20);
            this.endDate.TabIndex = 3;
            // 
            // categoriesListView
            // 
            this.categoriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categoryColumnHeader});
            this.categoriesListView.FullRowSelect = true;
            this.categoriesListView.GridLines = true;
            this.categoriesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.categoriesListView.Location = new System.Drawing.Point(27, 278);
            this.categoriesListView.Name = "categoriesListView";
            this.categoriesListView.Size = new System.Drawing.Size(121, 97);
            this.categoriesListView.TabIndex = 4;
            this.categoriesListView.UseCompatibleStateImageBehavior = false;
            this.categoriesListView.View = System.Windows.Forms.View.Details;
            // 
            // categoryColumnHeader
            // 
            this.categoryColumnHeader.Width = 100;
            // 
            // filterListView
            // 
            this.filterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categoryColumn});
            this.filterListView.FullRowSelect = true;
            this.filterListView.GridLines = true;
            this.filterListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.filterListView.Location = new System.Drawing.Point(227, 282);
            this.filterListView.Name = "filterListView";
            this.filterListView.Size = new System.Drawing.Size(121, 97);
            this.filterListView.TabIndex = 5;
            this.filterListView.UseCompatibleStateImageBehavior = false;
            this.filterListView.View = System.Windows.Forms.View.Details;
            // 
            // categoryColumn
            // 
            this.categoryColumn.Width = 90;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(164, 295);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(44, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = ">";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(164, 324);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(44, 23);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "<";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeAllButton
            // 
            this.removeAllButton.Location = new System.Drawing.Point(164, 352);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(44, 23);
            this.removeAllButton.TabIndex = 8;
            this.removeAllButton.Text = "<<";
            this.removeAllButton.UseVisualStyleBackColor = true;
            this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
            // 
            // minValCheckBox
            // 
            this.minValCheckBox.AutoSize = true;
            this.minValCheckBox.Location = new System.Drawing.Point(205, 111);
            this.minValCheckBox.Name = "minValCheckBox";
            this.minValCheckBox.Size = new System.Drawing.Size(104, 17);
            this.minValCheckBox.TabIndex = 10;
            this.minValCheckBox.Text = "kwota minimalna";
            this.minValCheckBox.UseVisualStyleBackColor = true;
            this.minValCheckBox.CheckedChanged += new System.EventHandler(this.minValCheckBox_CheckedChanged);
            // 
            // maxValCheckBox
            // 
            this.maxValCheckBox.AutoSize = true;
            this.maxValCheckBox.Location = new System.Drawing.Point(184, 143);
            this.maxValCheckBox.Name = "maxValCheckBox";
            this.maxValCheckBox.Size = new System.Drawing.Size(116, 17);
            this.maxValCheckBox.TabIndex = 11;
            this.maxValCheckBox.Text = "kwota maksymalna";
            this.maxValCheckBox.UseVisualStyleBackColor = true;
            this.maxValCheckBox.CheckedChanged += new System.EventHandler(this.maxValCheckBox_CheckedChanged);
            // 
            // minValTextBox
            // 
            this.minValTextBox.Enabled = false;
            this.minValTextBox.Location = new System.Drawing.Point(68, 108);
            this.minValTextBox.Name = "minValTextBox";
            this.minValTextBox.Size = new System.Drawing.Size(101, 20);
            this.minValTextBox.TabIndex = 12;
            // 
            // maxValTextBox
            // 
            this.maxValTextBox.Enabled = false;
            this.maxValTextBox.Location = new System.Drawing.Point(69, 140);
            this.maxValTextBox.Name = "maxValTextBox";
            this.maxValTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxValTextBox.TabIndex = 13;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(266, 400);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(175, 400);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 16;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // startDateCheckBox
            // 
            this.startDateCheckBox.AutoSize = true;
            this.startDateCheckBox.Location = new System.Drawing.Point(205, 45);
            this.startDateCheckBox.Name = "startDateCheckBox";
            this.startDateCheckBox.Size = new System.Drawing.Size(108, 17);
            this.startDateCheckBox.TabIndex = 17;
            this.startDateCheckBox.Text = "data początkowa";
            this.startDateCheckBox.UseVisualStyleBackColor = true;
            this.startDateCheckBox.CheckedChanged += new System.EventHandler(this.startDateCheckBox_CheckedChanged);
            // 
            // endDateCheckBox
            // 
            this.endDateCheckBox.AutoSize = true;
            this.endDateCheckBox.Location = new System.Drawing.Point(212, 79);
            this.endDateCheckBox.Name = "endDateCheckBox";
            this.endDateCheckBox.Size = new System.Drawing.Size(94, 17);
            this.endDateCheckBox.TabIndex = 18;
            this.endDateCheckBox.Text = "data końcowa";
            this.endDateCheckBox.UseVisualStyleBackColor = true;
            this.endDateCheckBox.CheckedChanged += new System.EventHandler(this.endDateCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Wybierz kategorie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kategorie";
            // 
            // descTextBox
            // 
            this.descTextBox.Enabled = false;
            this.descTextBox.Location = new System.Drawing.Point(74, 181);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(100, 20);
            this.descTextBox.TabIndex = 24;
            // 
            // descCheckBox
            // 
            this.descCheckBox.AutoSize = true;
            this.descCheckBox.Location = new System.Drawing.Point(212, 187);
            this.descCheckBox.Name = "descCheckBox";
            this.descCheckBox.Size = new System.Drawing.Size(45, 17);
            this.descCheckBox.TabIndex = 25;
            this.descCheckBox.Text = "opis";
            this.descCheckBox.UseVisualStyleBackColor = true;
            this.descCheckBox.CheckedChanged += new System.EventHandler(this.descCheckBox_CheckedChanged);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 435);
            this.Controls.Add(this.descCheckBox);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endDateCheckBox);
            this.Controls.Add(this.startDateCheckBox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.maxValTextBox);
            this.Controls.Add(this.minValTextBox);
            this.Controls.Add(this.maxValCheckBox);
            this.Controls.Add(this.minValCheckBox);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.filterListView);
            this.Controls.Add(this.categoriesListView);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statystyki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.ListView categoriesListView;
        private System.Windows.Forms.ListView filterListView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button removeAllButton;
        private System.Windows.Forms.CheckBox minValCheckBox;
        private System.Windows.Forms.CheckBox maxValCheckBox;
        private System.Windows.Forms.TextBox minValTextBox;
        private System.Windows.Forms.TextBox maxValTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.CheckBox startDateCheckBox;
        private System.Windows.Forms.CheckBox endDateCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader categoryColumnHeader;
        private System.Windows.Forms.ColumnHeader categoryColumn;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.CheckBox descCheckBox;
    }
}