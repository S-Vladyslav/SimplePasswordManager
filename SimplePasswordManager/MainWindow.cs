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
using CsvHelper;
using System.Globalization;

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

        private void AccountNames_MouseClick(object sender, MouseEventArgs e)
        {
            var cryptoInst = Crypto.GetInstance();
            var FileActionObj = FileAction.GetInstance();
            var dataReaded = new List<Unit>();

            using (StreamReader streamReader = new StreamReader(Unit.File))
            {
                using (CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    dataReaded.AddRange(csvReader.GetRecords<Unit>().ToList());
                }
            }

            var namesLst = new List<string>();

            for (int i = 1; i < dataReaded.Count; i++)
            {
                namesLst.Add(cryptoInst.Decrypt(dataReaded[i].Name, Unit.Key));
            }

            AccountNames.Items.Clear();
            AccountNames.Items.AddRange(namesLst.ToArray());
        }
    }
}
