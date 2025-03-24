using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
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
            roundedTextBoxAddress.Texts = "";
            roundedTextBoxNum.Texts = "";
            roundedTextBoxPostalCode.Texts = "";
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

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            string address = roundedTextBoxAddress.Texts;
            string numText = roundedTextBoxNum.Texts;
            string zipCode = roundedTextBoxPostalCode.Texts;

            if (string.IsNullOrEmpty(address) || string.IsNullOrEmpty(numText)  || string.IsNullOrEmpty(zipCode))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            if(!int.TryParse(numText, out int num))
            {
                MessageBox.Show("The number field must be a valid integer");
                return;
            }

            if (!Regex.IsMatch(zipCode, @"^\d{4,10}$"))
            {
                MessageBox.Show("Invalid ZIP code! It must contain only numbers and be between 4 and 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            formLogin.selectedRestaurant.address = address;
            formLogin.selectedRestaurant.addressNum = num;
            formLogin.selectedRestaurant.zipCode = zipCode;

            formLogin.Restaurants.Add(formLogin.selectedRestaurant);
            formLogin.selectedRestaurant = null;

            formLogin.LoadFormIntoPanel("FormRestaurantsUsers", true);
        }
    }
}
