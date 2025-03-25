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
    public partial class FormAdminUsers : Form
    {
        private FormLogin formLogin;
        public FormAdminUsers(FormLogin formLogin)
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
                LoadAdmins();
            }
        }

        private void LoadAdmins()
        {
            dataGridViewUsers.DataSource = null;


            var adminsData = formLogin
                .Admins
                .Select(a => new
                {
                    a.idUser,
                    rol = a.idRol == 3 ? "Superadmin" :
                          a.idRol == 4 ? "Admin" :
                          a.idRol == 5 ? "Mantenimiento" : "User",
                    a.name,
                    a.email
                })
                .ToList();


            dataGridViewUsers.DataSource = adminsData;
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

        private void labelMusicians_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormMusicianUsers", true);
        }

        private void labelRestaurants_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormRestaurantsUsers", true);
        }

        private void FormAdminUsers_Load(object sender, EventArgs e)
        {
            LoadAdmins();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormNewAdmin", false);
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a restaurant to edit");
                return;
            }

            int selectedAdminId = (int)dataGridViewUsers.SelectedRows[0].Cells[0].Value;
            User selectedUser = formLogin.Admins.FirstOrDefault(a => a.idUser == selectedAdminId);

            formLogin.selectedUser = selectedUser;

            formLogin.LoadFormIntoPanel("FormModifyAdmin", false);

        }

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Delete user", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (User user in formLogin.Admins)
                {
                    if (user.idUser == (int)dataGridViewUsers.SelectedRows[0].Cells[0].Value)
                    {
                        formLogin.Admins.Remove(user);
                        LoadAdmins();
                        break;
                    }
                }
            }
        }
    }
}
