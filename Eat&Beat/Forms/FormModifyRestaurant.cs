using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eat_Beat.Logic.Entities;

namespace Eat_Beat.Forms
{
    public partial class FormModifyRestaurant : Form
    {
        private FormLogin formLogin;
        private Restaurant selectedRestaurant;
        public FormModifyRestaurant(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            LoadLanguage();
            LanguageManager.LanguageChanged += LoadLanguage;

            selectedRestaurant = formLogin.selectedRestaurant;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                LoadRestaurantData();
            }
        }

        private void LoadRestaurantData()
        {
            selectedRestaurant = formLogin.selectedRestaurant;
            roundedTextBoxName.Texts = selectedRestaurant.name;
            roundedTextBoxEmail.Texts = selectedRestaurant.email;
            roundedTextBoxPassword.Texts = selectedRestaurant.password;
            roundedTextBoxAddress.Texts = selectedRestaurant.address;
            roundedTextBoxNumAddress.Texts = selectedRestaurant.addressNum.ToString();
            roundedTextBoxPostalCode.Texts = selectedRestaurant.zipCode;
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

        private void roundedButtonModify_Click(object sender, EventArgs e)
        {
            string name = roundedTextBoxName.Texts;
            string email = roundedTextBoxEmail.Texts;
            string password = roundedTextBoxPassword.Texts;
            string address = roundedTextBoxAddress.Texts;
            string addressNum = roundedTextBoxNumAddress.Texts;
            string zipCode = roundedTextBoxPostalCode.Texts;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(addressNum) || string.IsNullOrEmpty(zipCode))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(zipCode, @"^\d{4,10}$"))
            {
                MessageBox.Show("Invalid ZIP code! It must contain only numbers and be between 4 and 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedRestaurant.name = name;
            selectedRestaurant.email = email;
            selectedRestaurant.password = password;
            selectedRestaurant.address = address;
            selectedRestaurant.addressNum = int.Parse(addressNum);
            selectedRestaurant.zipCode = zipCode;


            foreach (Restaurant restaurant in formLogin.Restaurants)
            {
                if (restaurant.idUser == selectedRestaurant.idUser)
                {
                    restaurant.name = selectedRestaurant.name;
                    restaurant.email = selectedRestaurant.email;
                    restaurant.password = selectedRestaurant.password;
                    restaurant.address = selectedRestaurant.address;
                    restaurant.addressNum = selectedRestaurant.addressNum;
                    restaurant.zipCode = selectedRestaurant.zipCode;
                    break;
                }
            }

            formLogin.LoadFormIntoPanel("FormRestaurantsUsers", true);

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
