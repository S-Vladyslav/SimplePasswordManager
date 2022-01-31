using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimplePasswordManager
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void UnlockBtn_Click(object sender, EventArgs e)
        {
            var cryptoInst = Crypto.GetInstance();

            

            Hide();
            MainWindow mainWind = new MainWindow();
            mainWind.Owner = this;
            mainWind.ShowDialog();
            Close();
        }

        private void CreateNew_Click(object sender, EventArgs e)
        {
            CreatingNewDBWindow CreatingNewDB = new CreatingNewDBWindow();
            CreatingNewDB.Owner = this;
            CreatingNewDB.ShowDialog();
        }

        private void CSVFileNames_MouseClick(object sender, MouseEventArgs e)
        {
            var FileActionObj = FileAction.GetInstance();
            CSVFileNames.Items.Clear();
            CSVFileNames.Items.AddRange(FileActionObj.GetCSVFileNames().ToArray());
        }
    }
}
