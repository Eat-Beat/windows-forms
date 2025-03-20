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
    public partial class FormNewRestaurant2 : Form
    {
        private FormLogin formLogin;
        public FormNewRestaurant2(FormLogin formLogin)
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

        private void FormNewRestaurant2_Load(object sender, EventArgs e)
        {

        }

        private void LoadLanguage()
        {
            labelNewRestaurant.Text = LanguageManager.GetText("labelNewRestaurant");
            labelAddress.Text = LanguageManager.GetText("labelAddress");
            labelNum.Text = LanguageManager.GetText("labelNum");
            labelPostalCode.Text = LanguageManager.GetText("labelPostalCode");
            roundedButtonCancel.Text = LanguageManager.GetText("roundedButtonCancel");
            roundedButtonCreate.Text = LanguageManager.GetText("roundedButtonCreate");
        }
    }
}
