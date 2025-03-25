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
    public partial class FormModifyAdmin : Form
    {
        private FormLogin formLogin;
        private User selectedUser;
        public FormModifyAdmin(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            this.selectedUser = formLogin.selectedUser;
            LoadLanguage();
            LanguageManager.LanguageChanged += LoadLanguage;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                LoadAdminData();
            }
        }

        private void LoadLanguage()
        {
            labelEditAdmin.Text = LanguageManager.GetText("labelEditAdmin");
            labelName.Text = LanguageManager.GetText("labelName");
            labelEmail.Text = LanguageManager.GetText("labelEmail");
            labelPassword.Text = LanguageManager.GetText("labelPassword");
            labelRol.Text = LanguageManager.GetText("labelRol");
            roundedButtonCancel.Text = LanguageManager.GetText("roundedButtonCancel");
            roundedButtonModify.Text = LanguageManager.GetText("roundedButtonModify");
        }

        private void LoadAdminData()
        {
            selectedUser = formLogin.selectedUser;
            roundedTextBoxName.Texts = selectedUser.name;
            roundedTextBoxEmail.Texts = selectedUser.email;
            roundedTextBoxPassword.Texts = selectedUser.password;
            roundedComboBoxRol.SelectedIndex = selectedUser.idRol - 3;
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
            int idRol = roundedComboBoxRol.SelectedIndex + 3;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (User user in formLogin.Admins)
            {
                if (user.idUser == selectedUser.idUser)
                {
                    selectedUser.name = name;
                    selectedUser.email = email;
                    selectedUser.password = password;
                    selectedUser.idRol = idRol;
                }
            }
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
