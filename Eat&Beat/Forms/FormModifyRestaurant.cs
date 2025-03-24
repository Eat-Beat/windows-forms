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
            labelAddress.Text = LanguageManager.GetText("labelAddress");
            labelNumAddress.Text = LanguageManager.GetText("labelNumAddress");
            labelPostalCode.Text = LanguageManager.GetText("labelPostalCode");
            roundedButtonCancel.Text = LanguageManager.GetText("roundedButtonCancel");
            roundedButtonModify.Text = LanguageManager.GetText("roundedButtonModify");
        }

        private void roundedButtonModify_Click_1(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormRestaurantsUsers", true);

        }

        private void FormModifyRestaurant_Load(object sender, EventArgs e)
        {
            Restaurant restaurant = formLogin.selectedRestaurant;

            roundedTextBoxName.Texts = restaurant.name;
            roundedTextBoxEmail.Texts = restaurant.email;
            roundedTextBoxPassword.Texts = restaurant.password;
            roundedTextBoxAddress.Texts = restaurant.address;
            roundedTextBoxNumAddress.Texts = restaurant.addressNum.ToString();
            roundedTextBoxPostalCode.Texts = restaurant.zipCode;

        }
    }
}
