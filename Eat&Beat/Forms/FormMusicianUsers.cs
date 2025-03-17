using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eat_Beat.Forms
{
    public partial class FormMusicianUsers : Form
    {

        private FormLogin formLogin;


        public FormMusicianUsers(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void labelRestaurants_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormRestaurantsUsers", true);
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {

            formLogin.LoadFormIntoPanel("FormNewMusician", true);
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormModifyMusician", false);
        }

        private void roundedButtonOpen_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 1)
            {
                var row = dataGridViewUsers.SelectedRows[0];
                // Anonymous type => treat as dynamic
                dynamic rowObj = row.DataBoundItem;
                int userId = rowObj.idUser;

                // Now find the matching musician in formLogin.Musicians
                var musician = formLogin.Musicians
                    .FirstOrDefault(m => m.idUser == userId);

                if (musician != null)
                {
                    formLogin.selectedUser = musician;
                    formLogin.LoadFormIntoPanel("FormOpenMusician", true);
                }
            }
        }

        private void FormMusicianUsers_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = null;

            var musiciansData = formLogin
                .Musicians
                .Select(m => new
                {
                    m.idUser,
                    m.name,
                    m.email,
                    m.description,
                    m.rating
                })
                .ToList();

            dataGridViewUsers.DataSource = musiciansData;
        }
    }
}
