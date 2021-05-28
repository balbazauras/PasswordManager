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
    public partial class LoggedIn : Form

    {

        private User user;
        public LoggedIn(User user)
        {
            this.user = user;

            InitializeComponent();

            userLabel.Text = user.GetUsername();

        }

        private void addPasswordButton_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(FileInfo.GetFilePathTxt()))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    DataEntry data = new DataEntry(words[0], words[1], words[2], words[3]);
                    user.info.Add(data);
                }
            }
            if(user.info.Find(x => x.GetName() == nameTextBox.Text) == null)
            {
                using (StreamWriter sw = new StreamWriter(FileInfo.GetFilePathTxt(), true))
                {
                    sw.WriteLine(nameTextBox.Text + ";" + AES.Encrypt(passwordTextBox.Text) + ";" + urlTextBox.Text + ";" + commentTextBox.Text);
                }
                MessageBox.Show("Data added");
            }
            else
            {
                MessageBox.Show("Name is taken");
            }
            user.info.Clear();
        }

        private void generatePasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = RandomPassword.GeneratePassword();
        }
        private void LoggedIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            AesFileEncryption.AesFileEncrypt(FileInfo.GetFilePathTxt(), "123");
        }
        private void ManagePasswordsButton_Click(object sender, EventArgs e)
        {
            var next = new EditDataEntry(user);
            next.ShowDialog();
        }
    }
}
