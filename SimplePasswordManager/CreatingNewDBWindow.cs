using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace SimplePasswordManager
{
    public partial class CreatingNewDBWindow : Form
    {
        public CreatingNewDBWindow()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateDBBtn_Click(object sender, EventArgs e)
        {
            var cryptoInst = Crypto.GetInstance();
            var fileName = NameOfNewDB.Text;
            Unit.Key = PasswordOfNewDB.Text;
            var hashedPassword = cryptoInst.ComputeSha256Hash(Unit.Key);

            var dataForCheck = new List<Unit>();
            dataForCheck.Add(new Unit() { 
                Name = ".", Login = ".", 
                Password = cryptoInst.Encrypt("Decrypted DataBase!", hashedPassword),
                URI = ".", Phone = ".", Notes = "."
            });

            using (var writer = new StreamWriter($@"DataBases\{fileName}.csv"))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(dataForCheck);
                }
            }
            this.Close();
        }
    }
}
