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
    public partial class FormModifyRestaurant : Form
    {
        private FormLogin formLogin;
        public FormModifyRestaurant(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            LoadLanguage();
            LanguageManager.LanguageChanged += LoadLanguage;
        }

        private void LoadLanguage()
        {
            labelEditRestaurant.Text = LanguageManager.GetText("labelEditRestaurant");
            labelName.Text = LanguageManager.GetText("labelName");
            labelEmail.Text = LanguageManager.GetText("labelEmail");
            labelPassword.Text = LanguageManager.GetText("labelPassword");
            labelConfPassword.Text = LanguageManager.GetText("labelConfPassword");
            labelAddress.Text = LanguageManager.GetText("labelAddress");
            labelNumAddress.Text = LanguageManager.GetText("labelNumAddress");
            roundedButtonCancel.Text = LanguageManager.GetText("roundedButtonCancel");
            roundedButtonModify.Text = LanguageManager.GetText("roundedButtonModify");
        }

        private void roundedButtonOpen_Click_1(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormRestaurantsUsers", true);

        }
    }
}
