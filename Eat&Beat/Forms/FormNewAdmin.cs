using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eat_Beat.Logic.Entities;

namespace Eat_Beat.Forms
{
    public partial class FormNewAdmin : Form
    {
        private FormLogin formLogin;
        public FormNewAdmin(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            LoadLanguage();
            LanguageManager.LanguageChanged += LoadLanguage;
        }

        private void LoadLanguage()
        {
            labelNewAdmin.Text = LanguageManager.GetText("labelNewAdmin");
            labelName.Text = LanguageManager.GetText("labelName");
            labelEmail.Text = LanguageManager.GetText("labelEmail");
            labelPassword.Text = LanguageManager.GetText("labelPassword");
            labelConfPassword.Text = LanguageManager.GetText("labelConfPassword");
            roundedButton1.Text = LanguageManager.GetText("roundedButton1");
            roundedButton2.Text = LanguageManager.GetText("roundedButton2");
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            roundedTextBoxName.Texts = "";
            roundedTextBoxEmail.Texts = "";
            roundedTextBoxPassword.Texts = "";
            roundedTextBoxConfPassword.Texts = "";
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormAdminUsers", true);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string name = roundedTextBoxName.Texts;
            string email = roundedTextBoxEmail.Texts;
            string password = roundedTextBoxPassword.Texts;
            string confPassword = roundedTextBoxConfPassword.Texts;
            int idRol = roundedComboBoxRol.SelectedIndex + 3;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confPassword))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (roundedComboBoxRol.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role before proceeding.");
                return;
            }

            formLogin.Admins.Add(new User()
            {
                idUser = formLogin.AllUsers.Max(u => u.idUser) + 1,
                idRol = idRol,
                name = name,
                email = email,
                password = password
            });

            formLogin.LoadFormIntoPanel("FormAdminUsers", true);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
