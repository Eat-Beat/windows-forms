﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eat_Beat.Logic.Entities;
using Microsoft.VisualBasic.ApplicationServices;

namespace Eat_Beat.Forms
{
    public partial class FormMusicianUsers : Form
    {

        private FormLogin formLogin;


        public FormMusicianUsers(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            LoadLanguage();
            LanguageManager.LanguageChanged += LoadLanguage;
        }

        private void LoadLanguage()
        {
            labelRestaurants.Text = LanguageManager.GetText("labelRestaurants");
            labelMusicians.Text = LanguageManager.GetText("labelMusicians");
            roundedButtonOpen.Text = LanguageManager.GetText("roundedButtonOpen");
            roundedButtonEdit.Text = LanguageManager.GetText("roundedButtonEdit");
            roundedButtonCreate.Text = LanguageManager.GetText("roundedButtonCreate");
            roundedButtonDelete.Text = LanguageManager.GetText("roundedButtonDelete");
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                LoadMusicians();
            }
        }

        private void LoadMusicians()
        {

            dataGridViewUsers.DataSource = null;

            var musiciansData = formLogin
                .Musicians
                .Select(m => new
                {
                    m.idUser,
                    m.name,
                    m.email,
                    m.description,
                    m.rating
                })
                .ToList();

            dataGridViewUsers.DataSource = musiciansData;
        }

        private void labelRestaurants_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormRestaurantsUsers", true);
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {

            formLogin.LoadFormIntoPanel("FormNewMusician", false);
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormModifyMusician", false);
        }

        private void roundedButtonOpen_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 1)
            {
                var row = dataGridViewUsers.SelectedRows[0];
                // Anonymous type => treat as dynamic
                dynamic rowObj = row.DataBoundItem;
                int userId = rowObj.idUser;

                // Now find the matching musician in formLogin.Musicians
                var musician = formLogin.Musicians
                    .FirstOrDefault(m => m.idUser == userId);

                if (musician != null)
                {
                    formLogin.selectedUser = musician;
                    formLogin.LoadFormIntoPanel("FormOpenMusician", true);
                }
            }
        }

        private void FormMusicianUsers_Load(object sender, EventArgs e)
        {
            var user = formLogin.selectedUser;

            if (user.idRol != 3)
            {
                labelAdmins.Visible = false;
            }
        }

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a musicial to delete");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this musician?", "Delete musician", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (Musician musician in formLogin.Musicians)
                {
                    if (musician.idUser == (int)dataGridViewUsers.SelectedRows[0].Cells[0].Value)
                    {
                        formLogin.Musicians.Remove(musician);
                        LoadMusicians();
                        break;
                    }
                }
            }
        }

        private void labelAdmins_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormAdminUsers", true);
        }
    }
}
