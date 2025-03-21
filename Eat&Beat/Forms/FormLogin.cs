using System.Text.Json;
using Eat_Beat.Forms;

namespace Eat_Beat
{
    public partial class FormLogin : Form
    {

        public FormNewRestaurant newRestaurant;
        public FormNewRestaurant2 newRestaurant2;
        public FormModifyRestaurant modifyRestaurant;
        public FormOpenRestaurant openRestaurant;
        public FormNewMusician newMusician;
        public FormNewMusician2 newMusician2;
        public FormModifyMusician modifyMusician;
        public FormOpenMusician openMusician;
        public CalendarPopup calendarPopup;
        
        private List<Form> allForms = new List<Form>();
        public List<Musician> Musicians = new List<Musician>();
        public List<Restaurant> Restaurants = new List<Restaurant>();
        public User selectedUser;

        public FormLogin()
        {
            InitializeComponent();
            InitializeForms();
            panelMain.Visible = false;
            pictureBoxLogoSmall.Visible = false;

            LoadJsonData();
        }

        /// <summary>
        /// This fuction will load all of the infor from the JSON into the 2 Lists for musicians and restaurants
        /// </summary>
        private void LoadJsonData()
        {
            try
            {
                string baseDirectory = Application.StartupPath;

                string jsonFolder = Path.Combine(baseDirectory, "JSON");

                string musiciansPath = Path.Combine(jsonFolder, "musicians.json");
                string restaurantsPath = Path.Combine(jsonFolder, "restaurans.json");

                string musiciansJson = File.ReadAllText(musiciansPath);
                string restaurantsJson = File.ReadAllText(restaurantsPath);

                Musicians = JsonSerializer.Deserialize<List<Musician>>(musiciansJson);
                Restaurants = JsonSerializer.Deserialize<List<Restaurant>>(restaurantsJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading JSON data: " + ex.Message);
            }
        }

        /// <summary>
        /// This function initializes all Forms and send this Form as an object so they can have acces to all the public and can change the panelMain child form.
        /// </summary>
        private void InitializeForms()
        {
            var formTypes = new List<Type>
            {
                    typeof(FormRestaurantsUsers),
                    typeof(FormMusicianUsers),
                    typeof(FormNewRestaurant),
                    typeof(FormNewRestaurant2),
                    typeof(FormModifyRestaurant),
                    typeof(FormOpenRestaurant),
                    typeof(FormNewMusician),
                    typeof(FormNewMusician2),
                    typeof(FormModifyMusician),
                    typeof(FormOpenMusician),
                    typeof(CalendarPopup)
            };

            foreach (var formType in formTypes)
            {
                var formInstance = (Form)Activator.CreateInstance(formType, this);
                allForms.Add(formInstance);
            }
        }


        /// <summary>
        ///In this Function we check the user's credentials when they press the button and if they are correct we grant them acces to the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //Login logic/Function goes here
            bool correctPassword = true;

            if (correctPassword)
            {
                //Grant Acces to App
                panelMain.Visible = true;
                pictureBoxLogoSmall.Visible= true;
                pictureBox1.Visible= false;

                LoadFormIntoPanel("FormRestaurantsUsers", true);
            }

        }

        /// <summary>
        /// This function is responsible for loading the selected form into the panel
        /// </summary>
        /// <param name="childFormName">This parameter is the name of the form that will be loaded into the panel</param>
        /// <param name="formIsBig">This parameter will tell us the size of the form if its false the for is samll</param>
        public void LoadFormIntoPanel(String childFormName, bool formIsBig)
        {
            bool foundForm = false;
            Form childForm = null;


            foreach (Form form in allForms)
            {
                if (form.Name == childFormName)
                {
                    childForm = form;
                    changePanelSize(formIsBig);
                    foundForm = true;
                }
            }

            if (foundForm)
            {
                panelMain.Controls.Clear();


                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;


                panelMain.Controls.Add(childForm);
                childForm.Show();
            }
            else {
                //Users shoud never get here as we will define what name gets sent, this is solely for debugging purposes
                MessageBox.Show("Form was not found. Can you read???");
            }
        }

        
        /// <summary>
        /// Changes the panel size depending on which size we need
        /// </summary>
        public void changePanelSize(bool desiredPanelSizeBig) {
            if (!desiredPanelSizeBig)
            {
                panelMain.Location = new Point(160, 134);
                panelMain.Height = 450;    //1051 511
                panelMain.Width = 950;
            }
            else {
                panelMain.Location = new Point(50, 70);
                panelMain.Height = 568;
                panelMain.Width= 1164;
            }
        }
    }
}
