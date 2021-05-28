
namespace IS_Pd4
{
    partial class EditDataEntry
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
            this.CopyTextButton = new System.Windows.Forms.Button();
            this.FoundPasswordLabel = new System.Windows.Forms.Label();
            this.DecryptPassword = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PasswordSearchTexBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.DeleteDataEntryButton = new System.Windows.Forms.Button();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CopyTextButton
            // 
            this.CopyTextButton.Location = new System.Drawing.Point(100, 91);
            this.CopyTextButton.Name = "CopyTextButton";
            this.CopyTextButton.Size = new System.Drawing.Size(92, 23);
            this.CopyTextButton.TabIndex = 23;
            this.CopyTextButton.Text = "Copy password";
            this.CopyTextButton.UseVisualStyleBackColor = true;
            this.CopyTextButton.Click += new System.EventHandler(this.CopyTextButton_Click);
            // 
            // FoundPasswordLabel
            // 
            this.FoundPasswordLabel.AutoSize = true;
            this.FoundPasswordLabel.Location = new System.Drawing.Point(117, 75);
            this.FoundPasswordLabel.Name = "FoundPasswordLabel";
            this.FoundPasswordLabel.Size = new System.Drawing.Size(58, 13);
            this.FoundPasswordLabel.TabIndex = 22;
            this.FoundPasswordLabel.Text = "(password)";
            // 
            // DecryptPassword
            // 
            this.DecryptPassword.Location = new System.Drawing.Point(198, 91);
            this.DecryptPassword.Name = "DecryptPassword";
            this.DecryptPassword.Size = new System.Drawing.Size(75, 23);
            this.DecryptPassword.TabIndex = 21;
            this.DecryptPassword.Text = "Decrypt password";
            this.DecryptPassword.UseVisualStyleBackColor = true;
            this.DecryptPassword.Click += new System.EventHandler(this.DecryptPassword_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(19, 91);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PasswordSearchTexBox
            // 
            this.PasswordSearchTexBox.Location = new System.Drawing.Point(19, 29);
            this.PasswordSearchTexBox.Name = "PasswordSearchTexBox";
            this.PasswordSearchTexBox.Size = new System.Drawing.Size(254, 20);
            this.PasswordSearchTexBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Search for password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Password:";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(100, 164);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(100, 23);
            this.ChangePasswordButton.TabIndex = 25;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // DeleteDataEntryButton
            // 
            this.DeleteDataEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteDataEntryButton.Location = new System.Drawing.Point(100, 193);
            this.DeleteDataEntryButton.Name = "DeleteDataEntryButton";
            this.DeleteDataEntryButton.Size = new System.Drawing.Size(101, 23);
            this.DeleteDataEntryButton.TabIndex = 26;
            this.DeleteDataEntryButton.Text = "Delete data entry";
            this.DeleteDataEntryButton.UseVisualStyleBackColor = false;
            this.DeleteDataEntryButton.Click += new System.EventHandler(this.DeleteDataEntryButton_Click);
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(19, 138);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(254, 20);
            this.NewPasswordTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Enter new password";
            // 
            // EditDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 240);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.DeleteDataEntryButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CopyTextButton);
            this.Controls.Add(this.FoundPasswordLabel);
            this.Controls.Add(this.DecryptPassword);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PasswordSearchTexBox);
            this.Controls.Add(this.label6);
            this.Name = "EditDataEntry";
            this.Text = "EditDataEntry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditDataEntry_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CopyTextButton;
        private System.Windows.Forms.Label FoundPasswordLabel;
        private System.Windows.Forms.Button DecryptPassword;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox PasswordSearchTexBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button DeleteDataEntryButton;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Label label2;
    }
}