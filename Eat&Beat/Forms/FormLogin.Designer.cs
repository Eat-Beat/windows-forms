namespace Eat_Beat
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBoxBackground = new PictureBox();
            labelUser = new Label();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            buttonLogIn = new Button();
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            pictureBoxLogoSmall = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoSmall).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.BackColor = Color.FromArgb(32, 32, 31);
            pictureBoxBackground.Location = new Point(500, 269);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(280, 230);
            pictureBoxBackground.TabIndex = 0;
            pictureBoxBackground.TabStop = false;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.FromArgb(32, 32, 31);
            labelUser.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUser.ForeColor = Color.FromArgb(239, 230, 220);
            labelUser.Location = new Point(515, 284);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(134, 32);
            labelUser.TabIndex = 1;
            labelUser.Text = "Usuario:";
            // 
            // textBoxUser
            // 
            textBoxUser.BackColor = Color.FromArgb(239, 230, 220);
            textBoxUser.Font = new Font("Arial", 11.25F);
            textBoxUser.ForeColor = Color.FromArgb(32, 32, 31);
            textBoxUser.Location = new Point(515, 315);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(250, 25);
            textBoxUser.TabIndex = 2;
            textBoxUser.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(239, 230, 220);
            textBoxPassword.Font = new Font("Arial", 11.25F);
            textBoxPassword.ForeColor = Color.FromArgb(32, 32, 31);
            textBoxPassword.Location = new Point(515, 384);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '♪';
            textBoxPassword.Size = new Size(250, 25);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.FromArgb(32, 32, 31);
            labelPassword.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.FromArgb(239, 230, 220);
            labelPassword.Location = new Point(515, 353);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(179, 32);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Contraseña:";
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.FromArgb(252, 158, 79);
            buttonLogIn.Font = new Font("Segoe UI", 14F);
            buttonLogIn.ForeColor = Color.FromArgb(32, 32, 31);
            buttonLogIn.Location = new Point(583, 434);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(113, 36);
            buttonLogIn.TabIndex = 5;
            buttonLogIn.Text = "Log in";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(369, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(542, 129);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(50, 70);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1164, 568);
            panelMain.TabIndex = 7;
            // 
            // pictureBoxLogoSmall
            // 
            pictureBoxLogoSmall.BackColor = Color.Transparent;
            pictureBoxLogoSmall.BackgroundImage = (Image)resources.GetObject("pictureBoxLogoSmall.BackgroundImage");
            pictureBoxLogoSmall.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLogoSmall.Location = new Point(528, 4);
            pictureBoxLogoSmall.Name = "pictureBoxLogoSmall";
            pictureBoxLogoSmall.Size = new Size(252, 60);
            pictureBoxLogoSmall.TabIndex = 8;
            pictureBoxLogoSmall.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelMain);
            Controls.Add(pictureBoxLogoSmall);
            Controls.Add(pictureBox1);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUser);
            Controls.Add(labelUser);
            Controls.Add(pictureBoxBackground);
            DoubleBuffered = true;
            Name = "FormLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoSmall).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxBackground;
        private Label labelUser;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button buttonLogIn;
        private PictureBox pictureBox1;
        private Panel panelMain;
        private PictureBox pictureBoxLogoSmall;
    }
}
