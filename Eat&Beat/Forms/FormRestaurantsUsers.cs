using System.Data;
using Eat_Beat.Logic.Entities;

namespace Eat_Beat.Forms
{
    public partial class FormRestaurantsUsers : Form
    {
        private FormLogin formLogin;

        public FormRestaurantsUsers(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            LoadLanguage();
            LanguageManager.LanguageChanged += LoadLanguage;
        }

        private void labelMusicians_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormMusicianUsers", true);
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormNewRestaurant", false);
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormModifyRestaurant", false);

        }

        private void roundedButtonOpen_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormOpenRestaurant", true);

        }

        private void FormRestaurantsUsers_Load(object sender, EventArgs e)
        {

            dataGridViewUsers.DataSource = null;


            var restaurantsData = formLogin
                .Restaurants
                .Select(r => new
                {
                    r.idUser,
                    r.name,
                    r.email,
                    FullAddress = r.address + " " + r.addressNum,
                    r.zipCode,
                    r.rating
                })
                .ToList();


            dataGridViewUsers.DataSource = restaurantsData;
        }

        private void LoadLanguage()
        {
            labelRestaurants.Text = LanguageManager.GetText("labelRestaurants");
            labelMusicians.Text = LanguageManager.GetText("labelMusicians");
            roundedButtonEdit.Text = LanguageManager.GetText("roundedButtonEdit");
            roundedButtonOpen.Text = LanguageManager.GetText("roundedButtonOpen");
            roundedButtonCreate.Text = LanguageManager.GetText("roundedButtonCreate");
            roundedButtonDelete.Text = LanguageManager.GetText("roundedButtonDelete");
        }
    }
}
