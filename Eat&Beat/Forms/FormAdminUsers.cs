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
    }
}
