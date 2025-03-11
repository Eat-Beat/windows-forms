﻿using System;
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
    public partial class FormRestaurantsUsers : Form
    {
        private FormLogin formLogin;
        public FormRestaurantsUsers(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
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
    }
}
