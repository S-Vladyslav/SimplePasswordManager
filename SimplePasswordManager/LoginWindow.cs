using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Globalization;


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
            if (CSVFileNames.SelectedIndex < 0)
            {
                WarningLabel.Text = "Please, choose the file!";
                return;
            }

            var cryptoInst = Crypto.GetInstance();
            Unit.File = $@"DataBases\{CSVFileNames.Text}";
            Unit.Key = cryptoInst.ComputeSha256Hash(Password.Text);
            bool login = false;

            using (StreamReader streamReader = new StreamReader(Unit.File))
            {
                using (CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    var csvRecords = csvReader.GetRecords<Unit>();
                    var recordsLst = csvRecords.ToList();

                    if (cryptoInst.Decrypt(recordsLst[0].Password, Unit.Key).Trim() == "Decrypted DataBase!")
                    {
                        login = true;
                    }
                }
            }

            if (login)
            {
                Hide();
                MainWindow mainWind = new MainWindow();
                mainWind.Owner = this;
                mainWind.ShowDialog();
                Close();
            }
            else
            {
                WarningLabel.Text = "Wrong password, try again!";
            }
            
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
