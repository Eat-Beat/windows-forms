using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eat_Beat.Forms
{
    public partial class FormOpenMusician : Form
    {
        private FormLogin formLogin;
        public FormOpenMusician(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void labelRestaurants_Click(object sender, EventArgs e)
        {

        }

        private void FormOpenMusician_Load(object sender, EventArgs e)
        {

        }

        private void roundedButtonOpenCalendar_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("CalendarPopup", true);
        }
    }
}
