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
    public partial class FormNewRestaurant : Form
    {
        private FormLogin formLogin;
        public FormNewRestaurant(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            LoadLanguage();
            LanguageManager.LanguageChanged += LoadLanguage;
        }

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormRestaurantsUsers", true);
        }

        private void roundedButtonContinue_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormNewRestaurant2", false);
        }

        private void roundedTextBoxEmail_Load(object sender, EventArgs e)
        {

        }

        private void LoadLanguage()
        {
            labelNewRestaurant.Text = LanguageManager.GetText("labelNewRestaurant");
            labelName.Text = LanguageManager.GetText("labelName");
            labelEmail.Text = LanguageManager.GetText("labelEmail");
            labelPassword.Text = LanguageManager.GetText("labelPassword");
            labelConfPassword.Text = LanguageManager.GetText("labelConfPassword");
            roundedButtonCancel.Text = LanguageManager.GetText("roundedButtonCancel");
            roundedButtonContinue.Text = LanguageManager.GetText("roundedButtonContinue");
        }
    }
}
