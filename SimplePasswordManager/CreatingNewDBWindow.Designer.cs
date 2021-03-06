
namespace SimplePasswordManager
{
    partial class CreatingNewDBWindow
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
            this.NameOfNewDB = new System.Windows.Forms.TextBox();
            this.PasswordOfNewDB = new System.Windows.Forms.TextBox();
            this.CreateDBBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameOfNewDB
            // 
            this.NameOfNewDB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameOfNewDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfNewDB.Location = new System.Drawing.Point(12, 58);
            this.NameOfNewDB.Name = "NameOfNewDB";
            this.NameOfNewDB.Size = new System.Drawing.Size(391, 27);
            this.NameOfNewDB.TabIndex = 0;
            this.NameOfNewDB.Text = "Name for Data Base";
            // 
            // PasswordOfNewDB
            // 
            this.PasswordOfNewDB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordOfNewDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordOfNewDB.Location = new System.Drawing.Point(12, 110);
            this.PasswordOfNewDB.Name = "PasswordOfNewDB";
            this.PasswordOfNewDB.Size = new System.Drawing.Size(391, 27);
            this.PasswordOfNewDB.TabIndex = 1;
            this.PasswordOfNewDB.Text = "password";
            this.PasswordOfNewDB.UseSystemPasswordChar = true;
            // 
            // CreateDBBtn
            // 
            this.CreateDBBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CreateDBBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateDBBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateDBBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDBBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateDBBtn.Location = new System.Drawing.Point(139, 206);
            this.CreateDBBtn.Name = "CreateDBBtn";
            this.CreateDBBtn.Size = new System.Drawing.Size(133, 35);
            this.CreateDBBtn.TabIndex = 2;
            this.CreateDBBtn.Text = "Save";
            this.CreateDBBtn.UseVisualStyleBackColor = false;
            this.CreateDBBtn.Click += new System.EventHandler(this.CreateDBBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelBtn.Location = new System.Drawing.Point(139, 283);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(133, 34);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreatingNewDBWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(415, 365);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateDBBtn);
            this.Controls.Add(this.PasswordOfNewDB);
            this.Controls.Add(this.NameOfNewDB);
            this.Name = "CreatingNewDBWindow";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameOfNewDB;
        private System.Windows.Forms.TextBox PasswordOfNewDB;
        private System.Windows.Forms.Button CreateDBBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}