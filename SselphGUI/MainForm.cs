using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SselphGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // add the user control to the form
            ConfigureSettingsUserControl csuc = new ConfigureSettingsUserControl();
            csuc.Dock = DockStyle.Fill;
            this.Controls.Add(csuc);
        }
    }
}
