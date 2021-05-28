using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Pd4
{
    public partial class MainWindow : Form
    {
        private User user = new User();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {

                string[] fileEntries = Directory.GetFiles(@"C:\Users\whis\Desktop\User files");
                foreach (string filePath in fileEntries)
                {
                    string fileName = Path.GetFileName(filePath);
                    if (fileName == usernameTextBox.Text + ".txt.aes")
                    {
                        MessageBox.Show("User is taken");
                    }
                }
                FileInfo.SetFilePathTxt(String.Format(@"C:\Users\whis\Desktop\User files\" + usernameTextBox.Text + ".txt"));
                using (StreamWriter sr = new StreamWriter(FileInfo.GetFilePathTxt()))
                {
                    sr.WriteLine(PBKDF2.HashPassword(passwordTextBox.Text));
                }
                AesFileEncryption.AesFileEncrypt(FileInfo.GetFilePathTxt(), "123");
                MessageBox.Show("Registered succesfully");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            FileInfo.SetFilePathTxt(String.Format(@"C:\Users\whis\Desktop\User files\" + usernameTextBox.Text + ".txt"));
            try
            {
                AesFileEncryption.AesFileDecrypt(FileInfo.GetFilePathTxt() + ".aes", "123");
                string line1 = File.ReadLines(FileInfo.GetFilePathTxt()).First();
                if (PBKDF2.ValidatePassword(passwordTextBox.Text, line1))
                {
                    this.Hide();
                    user.SetPassword(passwordTextBox.Text);
                    user.SetUsername(usernameTextBox.Text);
                    var next = new LoggedIn(user);
                    File.Delete(FileInfo.GetFilePathTxt() + ".aes");
                    next.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords dont match");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
