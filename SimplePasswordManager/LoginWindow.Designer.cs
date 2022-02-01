
namespace SimplePasswordManager
{
    partial class LoginWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UnlockBtn = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.CSVFileNames = new System.Windows.Forms.ComboBox();
            this.CreateNew = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UnlockBtn
            // 
            this.UnlockBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UnlockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnlockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UnlockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnlockBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlockBtn.Location = new System.Drawing.Point(139, 220);
            this.UnlockBtn.Name = "UnlockBtn";
            this.UnlockBtn.Size = new System.Drawing.Size(142, 33);
            this.UnlockBtn.TabIndex = 0;
            this.UnlockBtn.Text = "Unlock";
            this.UnlockBtn.UseVisualStyleBackColor = false;
            this.UnlockBtn.Click += new System.EventHandler(this.UnlockBtn_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(12, 125);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(391, 27);
            this.Password.TabIndex = 1;
            this.Password.Text = "password";
            this.Password.UseSystemPasswordChar = true;
            // 
            // CSVFileNames
            // 
            this.CSVFileNames.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CSVFileNames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CSVFileNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CSVFileNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CSVFileNames.FormattingEnabled = true;
            this.CSVFileNames.Location = new System.Drawing.Point(12, 53);
            this.CSVFileNames.Name = "CSVFileNames";
            this.CSVFileNames.Size = new System.Drawing.Size(391, 28);
            this.CSVFileNames.TabIndex = 2;
            this.CSVFileNames.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CSVFileNames_MouseClick);
            // 
            // CreateNew
            // 
            this.CreateNew.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateNew.Location = new System.Drawing.Point(139, 301);
            this.CreateNew.Name = "CreateNew";
            this.CreateNew.Size = new System.Drawing.Size(142, 37);
            this.CreateNew.TabIndex = 3;
            this.CreateNew.Text = "Create new";
            this.CreateNew.UseVisualStyleBackColor = false;
            this.CreateNew.Click += new System.EventHandler(this.CreateNew_Click);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(92, 175);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(25, 24);
            this.WarningLabel.TabIndex = 4;
            this.WarningLabel.Text = "   ";
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(415, 365);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.CreateNew);
            this.Controls.Add(this.CSVFileNames);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UnlockBtn);
            this.Name = "LoginWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnlockBtn;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ComboBox CSVFileNames;
        private System.Windows.Forms.Button CreateNew;
        private System.Windows.Forms.Label WarningLabel;
    }
}

