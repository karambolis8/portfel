using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace portfel
{
    public partial class ExportForm : Form
    {
        public event Action<DateTime, DateTime> ExportAccepted;

        public ExportForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(this.ExportAccepted != null)
                this.ExportAccepted(this.sinceDateTimePicker.Value, this.toDateTimePicker.Value);
            this.Close();
        }
    }
}
