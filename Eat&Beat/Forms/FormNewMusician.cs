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
            formLogin.LoadFormIntoPanel("FormNewMusician2", true);
        }

        private void roundedTextBoxPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
