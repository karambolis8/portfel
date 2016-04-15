using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallet;

namespace portfel.src.Forms
{
    public partial class ChartForm : Form
    {
        private static Color[] colors = new Color[] 
        { 
            Color.Red, 
            Color.Blue,
            Color.Green,
            Color.Yellow,
            Color.Violet,
            Color.Fuchsia,
            Color.Gainsboro,
            Color.Gold,
            Color.Orange,
            Color.SandyBrown,
            Color.Tomato,
            Color.SteelBlue,
            Color.YellowGreen
        };

        public ChartForm()
        {
            InitializeComponent();

        }

        public void SetUpPieChart(List<Expense> expenses)
        {
            //nie działa filtrownaie kategorii
            //wykres jest za mały w stosunku do legendy
            Dictionary<string, double> categories = new Dictionary<string, double>();
            foreach(Expense e in expenses)
            {
                if(e.category == null)
                    e.category = "brak";

                if(categories.ContainsKey(e.category))
                    categories[e.category] += e.value;
                else
                    categories[e.category] = e.value;
            }

            int index = 0;
            foreach(KeyValuePair<string, double> pair in categories)
            {
                this.zedGraphControl.GraphPane.AddPieSlice(pair.Value, colors[index % colors.Length], 0, pair.Key);
                index++;
            }

            this.zedGraphControl.IsShowContextMenu = false;
            this.zedGraphControl.GraphPane.Legend.Position = ZedGraph.LegendPos.BottomCenter;
            this.zedGraphControl.GraphPane.Legend.FontSpec.Size = 7;
            this.zedGraphControl.AxisChange();
        }
    }
}
