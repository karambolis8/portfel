namespace portfel
{
    partial class ConstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstForm));
            this.cancel_button = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.name_columnHeader = new System.Windows.Forms.ColumnHeader();
            this.value_columnHeader = new System.Windows.Forms.ColumnHeader();
            this.frequency_columnHeader = new System.Windows.Forms.ColumnHeader();
            this.date_columnHeader = new System.Windows.Forms.ColumnHeader();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(236, 493);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "Zamknij";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_columnHeader,
            this.value_columnHeader,
            this.frequency_columnHeader,
            this.date_columnHeader});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 81);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(299, 381);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // name_columnHeader
            // 
            this.name_columnHeader.Text = "nazwa";
            // 
            // value_columnHeader
            // 
            this.value_columnHeader.Text = "wartość";
            // 
            // frequency_columnHeader
            // 
            this.frequency_columnHeader.Text = "częstość";
            // 
            // date_columnHeader
            // 
            this.date_columnHeader.Text = "data";
            // 
            // add_button
            // 
            this.add_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.add_button.Image = ((System.Drawing.Image)(resources.GetObject("add_button.Image")));
            this.add_button.Location = new System.Drawing.Point(12, 12);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(95, 41);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Dodaj";
            this.add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Image = ((System.Drawing.Image)(resources.GetObject("edit_button.Image")));
            this.edit_button.Location = new System.Drawing.Point(113, 12);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(95, 41);
            this.edit_button.TabIndex = 3;
            this.edit_button.Text = "Edytuj";
            this.edit_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Image = ((System.Drawing.Image)(resources.GetObject("delete_button.Image")));
            this.delete_button.Location = new System.Drawing.Point(216, 12);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(95, 41);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Usuń";
            this.delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // ConstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(323, 528);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.cancel_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConstForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Portfel: stałe wydatki";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader name_columnHeader;
        private System.Windows.Forms.ColumnHeader value_columnHeader;
        private System.Windows.Forms.ColumnHeader frequency_columnHeader;
        private System.Windows.Forms.ColumnHeader date_columnHeader;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
    }
}