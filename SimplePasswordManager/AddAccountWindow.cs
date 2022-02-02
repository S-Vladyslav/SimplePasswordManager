using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace SimplePasswordManager
{
    public partial class AddAccountWindow : Form
    {
        public AddAccountWindow()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var cryptoInst = Crypto.GetInstance();

            var dataForWrite = new List<Unit>();

            using (StreamReader streamReader = new StreamReader(Unit.File))
            {
                using (CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    dataForWrite.AddRange(csvReader.GetRecords<Unit>().ToList());
                }
            }

            dataForWrite.Add(new Unit() {
                Name = cryptoInst.Encrypt(AddNameTextBox.Text, Unit.Key),
                Login = cryptoInst.Encrypt(AddLoginTextBox.Text, Unit.Key),
                Password = cryptoInst.Encrypt(AddPasswordTextBox.Text, Unit.Key),
                URL = cryptoInst.Encrypt(AddUrlTextBox.Text, Unit.Key),
                Phone = cryptoInst.Encrypt(AddPhoneTextBox.Text, Unit.Key),
                Notes = cryptoInst.Encrypt(AddNotesTextBox.Text, Unit.Key)
            });

            

            using (var writer = new StreamWriter(Unit.File))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(dataForWrite);
                }
            }
            this.Close();
        }
    }
}
