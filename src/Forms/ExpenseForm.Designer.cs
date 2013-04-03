namespace portfel
{
    partial class ExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseForm));
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.incomeRadioButton = new System.Windows.Forms.RadioButton();
            this.outcopmRadioButton = new System.Windows.Forms.RadioButton();
            this.categoryButton = new System.Windows.Forms.Button();
            this.date_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.value_label = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.calcButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(63, 94);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(115, 21);
            this.categoriesComboBox.TabIndex = 4;
            this.categoriesComboBox.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(63, 121);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(63, 42);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(135, 20);
            this.valueTextBox.TabIndex = 2;
            this.valueTextBox.TextChanged += new System.EventHandler(this.valueTextBox_TextChanged);
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(63, 68);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(135, 20);
            this.descTextBox.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.incomeRadioButton);
            this.groupBox.Controls.Add(this.outcopmRadioButton);
            this.groupBox.Controls.Add(this.categoryButton);
            this.groupBox.Controls.Add(this.date_label);
            this.groupBox.Controls.Add(this.category_label);
            this.groupBox.Controls.Add(this.desc_label);
            this.groupBox.Controls.Add(this.value_label);
            this.groupBox.Controls.Add(this.valueTextBox);
            this.groupBox.Controls.Add(this.dateTimePicker);
            this.groupBox.Controls.Add(this.descTextBox);
            this.groupBox.Controls.Add(this.categoriesComboBox);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(215, 155);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "group";
            // 
            // incomeRadioButton
            // 
            this.incomeRadioButton.AutoSize = true;
            this.incomeRadioButton.Location = new System.Drawing.Point(9, 19);
            this.incomeRadioButton.Name = "incomeRadioButton";
            this.incomeRadioButton.Size = new System.Drawing.Size(68, 17);
            this.incomeRadioButton.TabIndex = 0;
            this.incomeRadioButton.Text = "przychód";
            this.incomeRadioButton.UseVisualStyleBackColor = true;
            // 
            // outcopmRadioButton
            // 
            this.outcopmRadioButton.AutoSize = true;
            this.outcopmRadioButton.Checked = true;
            this.outcopmRadioButton.Location = new System.Drawing.Point(133, 19);
            this.outcopmRadioButton.Name = "outcopmRadioButton";
            this.outcopmRadioButton.Size = new System.Drawing.Size(65, 17);
            this.outcopmRadioButton.TabIndex = 1;
            this.outcopmRadioButton.TabStop = true;
            this.outcopmRadioButton.Text = "wydatek";
            this.outcopmRadioButton.UseVisualStyleBackColor = true;
            // 
            // categoryButton
            // 
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.categoryButton.Location = new System.Drawing.Point(177, 94);
            this.categoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(21, 21);
            this.categoryButton.TabIndex = 5;
            this.categoryButton.Text = "+";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(6, 125);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(28, 13);
            this.date_label.TabIndex = 23;
            this.date_label.Text = "data";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(6, 97);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(51, 13);
            this.category_label.TabIndex = 22;
            this.category_label.Text = "kategoria";
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Location = new System.Drawing.Point(6, 71);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(26, 13);
            this.desc_label.TabIndex = 21;
            this.desc_label.Text = "opis";
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Location = new System.Drawing.Point(6, 45);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(36, 13);
            this.value_label.TabIndex = 20;
            this.value_label.Text = "kwota";
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.Location = new System.Drawing.Point(71, 194);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 7;
            this.acceptButton.Text = "accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(152, 194);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // calcButton
            // 
            this.calcButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calcButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.calcButton.FlatAppearance.BorderSize = 0;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Image = ((System.Drawing.Image)(resources.GetObject("calcButton.Image")));
            this.calcButton.Location = new System.Drawing.Point(11, 188);
            this.calcButton.Margin = new System.Windows.Forms.Padding(2);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(21, 30);
            this.calcButton.TabIndex = 9;
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ExpenseForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(239, 229);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.acceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpenseForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Portfel";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.Label value_label;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RadioButton incomeRadioButton;
        private System.Windows.Forms.RadioButton outcopmRadioButton;
    }
}