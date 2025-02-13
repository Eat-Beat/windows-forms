using Eat_Beat.Forms;

namespace Eat_Beat
{
    public partial class FormLogin : Form
    {

        public FormRestaurantsUsers restaurantUsers;
        //public FormMusicianUsers musicianUsers;
        //public FormNewRestaurant newRestaurant;
        //public FormNewRestaurant2 newRestaurant2;
        //public FormMidifyRestaurant modifyRestaurant;
        //public FormOpenRestaurant openRestaurant;
        //public FormNewMusician newMusician;
        //public FormNewMusician2 newMusician2;
        //public FormModifyMusician modifyMusician;
        //public FormopenMusician openMusician;
        private List<Form> allForms = new List<Form>();
        private bool panelSizeBig = true; // If set to false the panel is int's smaller form

        public FormLogin()
        {
            InitializeComponent();
            InitializeForms();
            panelMain.Visible = false;
            pictureBoxLogoSmall.Visible = false;
        }

        /// <summary>
        /// This function initializes all Forms and send this Form as an object so they can have acces to all the public and can change the panelMain child form.
        /// </summary>
        private void InitializeForms()
        {
            //            var formTypes = new List<Type>
            //{
            //    typeof(FormRestaurantsUsers),
            //    typeof(FormMusicianUsers),
            //    typeof(FormNewRestaurant),
            //    typeof(FormNewRestaurant2),
            //    typeof(FormMidifyRestaurant),
            //    typeof(FormOpenRestaurant),
            //    typeof(FormNewMusician),
            //    typeof(FormNewMusician2),
            //    typeof(FormModifyMusician),
            //    typeof(FormopenMusician)
            //};

            //            foreach (var formType in formTypes)
            //            {
            //                var formInstance = (Form)Activator.CreateInstance(formType, this);
            //                allForms.Add(formInstance);
            //            }
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
                pictureBoxLogoSmall.Visible= t;
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
                    if (!(panelSizeBig && formIsBig)) {
                        changePanelSize();
                    }
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

        public void changePanelSize() {
            if (panelSizeBig)
            {
                panelSizeBig = false;
                //Make the panel smaller
            }
            else {
                panelSizeBig = true;
                panelMain.Location = new Point(50, 70);
                panelMain.Height = 568;
                panelMain.Width= 1164;
            }
        }
    }
}
