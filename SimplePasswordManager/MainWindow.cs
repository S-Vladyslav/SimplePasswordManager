using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePasswordManager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddAccountBtn_Click(object sender, EventArgs e)
        {
            AddAccountWindow AddAccWind = new AddAccountWindow();
            AddAccWind.Owner = this;
            AddAccWind.ShowDialog();
        }
    }
}
