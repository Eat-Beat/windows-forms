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
    public partial class FormModifyMusician : Form
    {
        private FormLogin formLogin;
        public FormModifyMusician(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            LoadLanguage();
            LanguageManager.LanguageChanged += LoadLanguage;
        }

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormMusicianUsers", true);
        }

        private void LoadLanguage()
        {
            labelEditMusician.Text = LanguageManager.GetText("labelEditMusician");
            labelName.Text = LanguageManager.GetText("labelName");
            labelEmail.Text = LanguageManager.GetText("labelEmail");
            labelPassword.Text = LanguageManager.GetText("labelPassword");
            labelConfPassword.Text = LanguageManager.GetText("labelConfPassword");
            labelAddress.Text = LanguageManager.GetText("labelAddress");
            labelNumAddress.Text = LanguageManager.GetText("labelNumAddress");
            roundedButtonCancel.Text = LanguageManager.GetText("roundedButtonCancel");
            roundedButtonModify.Text = LanguageManager.GetText("roundedButtonModify");
        }

        private void FormModifyMusician_Load(object sender, EventArgs e)
        {
            /*Musician selectedMusician = formLogin.selectedMusician;
            roundedTextBoxName.Texts = selectedMusician.name;
            roundedTextBoxEmail.Texts = selectedMusician.email;
            roundedTextBoxPassword.Texts = selectedMusician.password;
            */
        }

        private void roundedButtonModify_Click(object sender, EventArgs e)
        {

        }
    }
}
