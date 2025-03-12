namespace Eat_Beat.Forms
{
    public partial class ucDay : UserControl
    {
        public string _day;
        string date, weekday;

        private CalendarPopup _parentForm;

        public ucDay(string day, CalendarPopup parentForm)
        {
            InitializeComponent();
            _day = day;
            _parentForm = parentForm;
            labelDay.Text = day;
            checkBox1.Hide();
            pictureBoxTasksInDay.Hide();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Click(object sender, EventArgs e)
        {
            if (!(this._day == ""))
            {
                _parentForm.SetSelectedUcDay(this); // Notify parent form about the selection
                SelectUcDay();
            }
        }

        public void SelectUcDay()
        {
            checkBox1.Checked = true;
            this.BackColor = Color.FromArgb(255, 150, 79);
        }

        public void Deselect()
        {
            checkBox1.Checked = false;
            this.BackColor = Color.FromArgb(239, 230, 220);
        }
        private void ucDay_Load(object sender, EventArgs e)
        {

        }

        private void labelDay_Click(object sender, EventArgs e)
        {

        }
    }
}
