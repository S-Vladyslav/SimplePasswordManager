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
            var password = PasswordOfNewDB.Text;

            using (var writer = new StreamWriter($@"DataBases\{fileName}.csv"))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteField(cryptoInst.Encrypt("Decrypted DataBase!", cryptoInst.ComputeSha256Hash(password)));
                }
            }
            this.Close();
        }
    }
}
