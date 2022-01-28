﻿using System;
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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();

            var FileActionObj = FileAction.GetInstance();

            CSVFileNames.Items.AddRange(FileActionObj.GetCSVFileNames().ToArray());
        }

        private void UnlockBtn_Click(object sender, EventArgs e)
        {

        }

        private void CreateNew_Click(object sender, EventArgs e)
        {
            CreatingNewDBWindow CreatingNewDB = new CreatingNewDBWindow();
            CreatingNewDB.Owner = this;
            CreatingNewDB.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}