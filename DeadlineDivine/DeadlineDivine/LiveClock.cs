using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadlineDivine
{
    public partial class LiveClock : UserControl
    {
        public LiveClock()
        {
            InitializeComponent();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            displayClock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
