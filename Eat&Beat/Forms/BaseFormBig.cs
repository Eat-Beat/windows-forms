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
     public partial class BaseFormBig : Form
    {
        public BaseFormBig()
        {
            InitializeComponent();
            this.Size = new Size(1164, 568);
            this.BackColor = Color.FromArgb(32, 32, 31);
        }
    }
}
