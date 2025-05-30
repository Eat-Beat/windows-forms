﻿using System;
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
    public partial class FormNewMusician : Form
    {
        private FormLogin formLogin;
        public FormNewMusician(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            LoadLanguage();
            LanguageManager.LanguageChanged += LoadLanguage;
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

        private void LoadLanguage()
        {
            labelName.Text = LanguageManager.GetText("labelName");
            labelEmail.Text = LanguageManager.GetText("labelEmail");
            labelPassword.Text = LanguageManager.GetText("labelPassword");
            labelConfPassword.Text = LanguageManager.GetText("labelConfPassword");
            roundedButtonCancel.Text = LanguageManager.GetText("roundedButtonCancel");
            roundedButtonContinue.Text = LanguageManager.GetText("roundedButtonContinue");
        }

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormMusicianUsers", true);
        }

        private void roundedButtonContinue_Click(object sender, EventArgs e)
        {
            string name = roundedTextBoxName.Texts;
            string email = roundedTextBoxEmail.Texts;
            string password = roundedTextBoxPassword.Texts;
            string confPassword = roundedTextBoxConfPassword.Texts;


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

            formLogin.selectedMusician = new Musician()
            {
                idUser = formLogin.AllUsers.Max(r => r.idUser) + 1,
                idRol = 1,
                name = name,
                email = email,
                password = password
            };

            formLogin.LoadFormIntoPanel("FormNewMusician2", true);
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
