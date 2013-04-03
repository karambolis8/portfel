namespace portfel
{
    partial class ConstExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstExpenseForm));
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.weekRadioButton = new System.Windows.Forms.RadioButton();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.dateDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.frequencyGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.frequencyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Location = new System.Drawing.Point(8, 23);
            this.dayRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(97, 21);
            this.dayRadioButton.TabIndex = 0;
            this.dayRadioButton.TabStop = true;
            this.dayRadioButton.Text = "codziennie";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            this.dayRadioButton.CheckedChanged += new System.EventHandler(this.dayRadioButton_CheckedChanged);
            // 
            // weekRadioButton
            // 
            this.weekRadioButton.AutoSize = true;
            this.weekRadioButton.Location = new System.Drawing.Point(117, 23);
            this.weekRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.weekRadioButton.Name = "weekRadioButton";
            this.weekRadioButton.Size = new System.Drawing.Size(93, 21);
            this.weekRadioButton.TabIndex = 1;
            this.weekRadioButton.TabStop = true;
            this.weekRadioButton.Text = "co tydzień";
            this.weekRadioButton.UseVisualStyleBackColor = true;
            this.weekRadioButton.CheckedChanged += new System.EventHandler(this.weekRadioButton_CheckedChanged);
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Location = new System.Drawing.Point(223, 23);
            this.monthRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(95, 21);
            this.monthRadioButton.TabIndex = 2;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "co miesiąc";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            this.monthRadioButton.CheckedChanged += new System.EventHandler(this.monthRadioButton_CheckedChanged);
            // 
            // dateDomainUpDown
            // 
            this.dateDomainUpDown.Location = new System.Drawing.Point(153, 178);
            this.dateDomainUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.dateDomainUpDown.Name = "dateDomainUpDown";
            this.dateDomainUpDown.Size = new System.Drawing.Size(189, 22);
            this.dateDomainUpDown.TabIndex = 6;
            this.dateDomainUpDown.SelectedItemChanged += new System.EventHandler(this.dateDomainUpDown_SelectedItemChanged);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(153, 114);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(188, 22);
            this.valueTextBox.TabIndex = 4;
            this.valueTextBox.TextChanged += new System.EventHandler(this.valueTextBox_TextChanged);
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(153, 146);
            this.descTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(188, 22);
            this.descTextBox.TabIndex = 5;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(135, 244);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(100, 28);
            this.acceptButton.TabIndex = 7;
            this.acceptButton.Text = "accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(243, 244);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Granuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(153, 82);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(188, 22);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // frequencyGroupBox
            // 
            this.frequencyGroupBox.Controls.Add(this.dayRadioButton);
            this.frequencyGroupBox.Controls.Add(this.weekRadioButton);
            this.frequencyGroupBox.Controls.Add(this.monthRadioButton);
            this.frequencyGroupBox.Location = new System.Drawing.Point(16, 15);
            this.frequencyGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.frequencyGroupBox.Name = "frequencyGroupBox";
            this.frequencyGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.frequencyGroupBox.Size = new System.Drawing.Size(327, 60);
            this.frequencyGroupBox.TabIndex = 11;
            this.frequencyGroupBox.TabStop = false;
            this.frequencyGroupBox.Text = "Częstotliwość";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "wartość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "opis";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(16, 181);
            this.date_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(24, 17);
            this.date_label.TabIndex = 15;
            this.date_label.Text = "    ";
            // 
            // ConstExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(359, 287);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frequencyGroupBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.dateDomainUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConstExpenseForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Portfel";
            this.frequencyGroupBox.ResumeLayout(false);
            this.frequencyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton dayRadioButton;
        private System.Windows.Forms.RadioButton weekRadioButton;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.DomainUpDown dateDomainUpDown;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox frequencyGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label date_label;
    }
}