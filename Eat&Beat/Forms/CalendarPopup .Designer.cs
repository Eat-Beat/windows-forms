namespace Eat_Beat.Forms
{
    partial class CalendarPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarPopup));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            labelMonady = new Label();
            labelTuesday = new Label();
            labelWednesday = new Label();
            labelFriday = new Label();
            labelThursday = new Label();
            labelSaturday = new Label();
            labelSunday = new Label();
            labelMonth = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            roundedButtonBackToMusician = new Controls.RoundedButton();
            richTextBoxDayDescription = new RichTextBox();
            labelFullDateDisplay = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(12, 85);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(778, 448);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // labelMonady
            // 
            labelMonady.AutoSize = true;
            labelMonady.Font = new Font("Barlow Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMonady.ForeColor = Color.FromArgb(239, 230, 220);
            labelMonady.Location = new Point(51, 62);
            labelMonady.Name = "labelMonady";
            labelMonady.Size = new Size(44, 15);
            labelMonady.TabIndex = 0;
            labelMonady.Text = "Lunes";
            // 
            // labelTuesday
            // 
            labelTuesday.AutoSize = true;
            labelTuesday.Font = new Font("Barlow Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTuesday.ForeColor = Color.FromArgb(239, 230, 220);
            labelTuesday.Location = new Point(157, 62);
            labelTuesday.Name = "labelTuesday";
            labelTuesday.Size = new Size(48, 15);
            labelTuesday.TabIndex = 1;
            labelTuesday.Text = "Martes";
            // 
            // labelWednesday
            // 
            labelWednesday.AutoSize = true;
            labelWednesday.Font = new Font("Barlow Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWednesday.ForeColor = Color.FromArgb(239, 230, 220);
            labelWednesday.Location = new Point(264, 62);
            labelWednesday.Name = "labelWednesday";
            labelWednesday.Size = new Size(66, 15);
            labelWednesday.TabIndex = 2;
            labelWednesday.Text = "Miercoles";
            // 
            // labelFriday
            // 
            labelFriday.AutoSize = true;
            labelFriday.Font = new Font("Barlow Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFriday.ForeColor = Color.FromArgb(239, 230, 220);
            labelFriday.Location = new Point(484, 62);
            labelFriday.Name = "labelFriday";
            labelFriday.Size = new Size(53, 15);
            labelFriday.TabIndex = 4;
            labelFriday.Text = "Viernes";
            // 
            // labelThursday
            // 
            labelThursday.AutoSize = true;
            labelThursday.Font = new Font("Barlow Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelThursday.ForeColor = Color.FromArgb(239, 230, 220);
            labelThursday.Location = new Point(375, 62);
            labelThursday.Name = "labelThursday";
            labelThursday.Size = new Size(50, 15);
            labelThursday.TabIndex = 3;
            labelThursday.Text = "Jueves";
            // 
            // labelSaturday
            // 
            labelSaturday.AutoSize = true;
            labelSaturday.Font = new Font("Barlow Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSaturday.ForeColor = Color.FromArgb(239, 230, 220);
            labelSaturday.Location = new Point(600, 62);
            labelSaturday.Name = "labelSaturday";
            labelSaturday.Size = new Size(53, 15);
            labelSaturday.TabIndex = 5;
            labelSaturday.Text = "Sabado";
            // 
            // labelSunday
            // 
            labelSunday.AutoSize = true;
            labelSunday.Font = new Font("Barlow Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSunday.ForeColor = Color.FromArgb(239, 230, 220);
            labelSunday.Location = new Point(700, 62);
            labelSunday.Name = "labelSunday";
            labelSunday.Size = new Size(62, 15);
            labelSunday.TabIndex = 6;
            labelSunday.Text = "Domingo";
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Font = new Font("Barlow Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMonth.ForeColor = Color.FromArgb(239, 230, 220);
            labelMonth.Location = new Point(15, 25);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(84, 31);
            labelMonth.TabIndex = 7;
            labelMonth.Text = "Month";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(760, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(706, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // roundedButtonBackToMusician
            // 
            roundedButtonBackToMusician.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonBackToMusician.FlatAppearance.BorderSize = 0;
            roundedButtonBackToMusician.FlatStyle = FlatStyle.Flat;
            roundedButtonBackToMusician.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonBackToMusician.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonBackToMusician.Location = new Point(796, 488);
            roundedButtonBackToMusician.Name = "roundedButtonBackToMusician";
            roundedButtonBackToMusician.Size = new Size(340, 45);
            roundedButtonBackToMusician.TabIndex = 24;
            roundedButtonBackToMusician.Text = "Volver al Musico";
            roundedButtonBackToMusician.UseVisualStyleBackColor = false;
            roundedButtonBackToMusician.Click += roundedButtonBackToMusician_Click;
            // 
            // richTextBoxDayDescription
            // 
            richTextBoxDayDescription.BackColor = Color.FromArgb(31, 31, 32);
            richTextBoxDayDescription.BorderStyle = BorderStyle.None;
            richTextBoxDayDescription.Location = new Point(796, 130);
            richTextBoxDayDescription.Name = "richTextBoxDayDescription";
            richTextBoxDayDescription.Size = new Size(340, 352);
            richTextBoxDayDescription.TabIndex = 25;
            richTextBoxDayDescription.Text = "";
            // 
            // labelFullDateDisplay
            // 
            labelFullDateDisplay.AutoSize = true;
            labelFullDateDisplay.Font = new Font("Barlow Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFullDateDisplay.ForeColor = Color.FromArgb(239, 230, 220);
            labelFullDateDisplay.Location = new Point(901, 96);
            labelFullDateDisplay.Name = "labelFullDateDisplay";
            labelFullDateDisplay.Size = new Size(0, 31);
            labelFullDateDisplay.TabIndex = 26;
            // 
            // CalendarPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(1148, 641);
            Controls.Add(labelFullDateDisplay);
            Controls.Add(richTextBoxDayDescription);
            Controls.Add(roundedButtonBackToMusician);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelMonth);
            Controls.Add(labelSunday);
            Controls.Add(labelSaturday);
            Controls.Add(labelFriday);
            Controls.Add(labelThursday);
            Controls.Add(labelWednesday);
            Controls.Add(labelTuesday);
            Controls.Add(labelMonady);
            Controls.Add(flowLayoutPanel1);
            Name = "CalendarPopup";
            Text = "CalendarPopup";
            Load += CalendarPopup_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelMonady;
        private Label labelTuesday;
        private Panel panel1;
        private Label labelWednesday;
        private Label labelFriday;
        private Label labelThursday;
        private Label labelSaturday;
        private Label labelSunday;
        private Label labelMonth;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Controls.RoundedButton roundedButtonBackToMusician;
        private RichTextBox richTextBoxDayDescription;
        private Label labelFullDateDisplay;
    }
}