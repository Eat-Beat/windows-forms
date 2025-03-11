namespace Eat_Beat.Forms
{
    partial class FormNewRestaurant
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
            labelRestaurants = new Label();
            roundedButtonCancel = new Eat_Beat.Controls.RoundedButton();
            roundedButtonContinue = new Eat_Beat.Controls.RoundedButton();
            labelConfPassword = new Label();
            labelPassword = new Label();
            labelEmail = new Label();
            labelName = new Label();
            roundedTextBoxPassword = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxConfPassword = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBox1 = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxEmail = new Eat_Beat.Controls.RoundedTextBox();
            SuspendLayout();
            // 
            // labelRestaurants
            // 
            labelRestaurants.AutoSize = true;
            labelRestaurants.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRestaurants.ForeColor = Color.FromArgb(239, 230, 220);
            labelRestaurants.Location = new Point(257, 44);
            labelRestaurants.Name = "labelRestaurants";
            labelRestaurants.Size = new Size(406, 37);
            labelRestaurants.TabIndex = 7;
            labelRestaurants.Text = "NUEVO RESTAURANTE:";
            // 
            // roundedButtonCancel
            // 
            roundedButtonCancel.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonCancel.FlatAppearance.BorderSize = 0;
            roundedButtonCancel.FlatStyle = FlatStyle.Flat;
            roundedButtonCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonCancel.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonCancel.Location = new Point(648, 358);
            roundedButtonCancel.Name = "roundedButtonCancel";
            roundedButtonCancel.Size = new Size(115, 45);
            roundedButtonCancel.TabIndex = 12;
            roundedButtonCancel.Text = "Cancelar";
            roundedButtonCancel.UseVisualStyleBackColor = false;
            roundedButtonCancel.Click += roundedButtonCancel_Click;
            // 
            // roundedButtonContinue
            // 
            roundedButtonContinue.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonContinue.FlatAppearance.BorderSize = 0;
            roundedButtonContinue.FlatStyle = FlatStyle.Flat;
            roundedButtonContinue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonContinue.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonContinue.Location = new Point(769, 358);
            roundedButtonContinue.Name = "roundedButtonContinue";
            roundedButtonContinue.Size = new Size(115, 45);
            roundedButtonContinue.TabIndex = 13;
            roundedButtonContinue.Text = "Continuar";
            roundedButtonContinue.UseVisualStyleBackColor = false;
            roundedButtonContinue.Click += roundedButtonContinue_Click;
            // 
            // labelConfPassword
            // 
            labelConfPassword.AutoSize = true;
            labelConfPassword.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelConfPassword.ForeColor = Color.FromArgb(239, 230, 220);
            labelConfPassword.Location = new Point(67, 260);
            labelConfPassword.Name = "labelConfPassword";
            labelConfPassword.Size = new Size(202, 24);
            labelConfPassword.TabIndex = 61;
            labelConfPassword.Text = "Confirmar Contraseña:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.FromArgb(239, 230, 220);
            labelPassword.Location = new Point(67, 211);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(113, 24);
            labelPassword.TabIndex = 60;
            labelPassword.Text = "Contraseña:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.FromArgb(239, 230, 220);
            labelEmail.Location = new Point(67, 164);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(176, 24);
            labelEmail.TabIndex = 59;
            labelEmail.Text = "Correo Electronico:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.FromArgb(239, 230, 220);
            labelName.Location = new Point(67, 117);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 24);
            labelName.TabIndex = 58;
            labelName.Text = "Nombre:";
            // 
            // roundedTextBoxPassword
            // 
            roundedTextBoxPassword.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxPassword.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxPassword.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxPassword.BorderRadius = 10;
            roundedTextBoxPassword.BorderSize = 2;
            roundedTextBoxPassword.Font = new Font("Barlow Medium", 12F);
            roundedTextBoxPassword.Location = new Point(283, 205);
            roundedTextBoxPassword.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxPassword.Multiline = false;
            roundedTextBoxPassword.Name = "roundedTextBoxPassword";
            roundedTextBoxPassword.Padding = new Padding(8);
            roundedTextBoxPassword.PasswordChar = false;
            roundedTextBoxPassword.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxPassword.PlaceholderText = "";
            roundedTextBoxPassword.Size = new Size(485, 37);
            roundedTextBoxPassword.TabIndex = 66;
            roundedTextBoxPassword.Texts = "";
            roundedTextBoxPassword.UnderlinedStyle = false;
            // 
            // roundedTextBoxConfPassword
            // 
            roundedTextBoxConfPassword.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxConfPassword.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxConfPassword.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxConfPassword.BorderRadius = 10;
            roundedTextBoxConfPassword.BorderSize = 2;
            roundedTextBoxConfPassword.Font = new Font("Barlow Medium", 12F);
            roundedTextBoxConfPassword.Location = new Point(283, 253);
            roundedTextBoxConfPassword.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxConfPassword.Multiline = false;
            roundedTextBoxConfPassword.Name = "roundedTextBoxConfPassword";
            roundedTextBoxConfPassword.Padding = new Padding(8);
            roundedTextBoxConfPassword.PasswordChar = false;
            roundedTextBoxConfPassword.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxConfPassword.PlaceholderText = "";
            roundedTextBoxConfPassword.Size = new Size(485, 37);
            roundedTextBoxConfPassword.TabIndex = 65;
            roundedTextBoxConfPassword.Texts = "";
            roundedTextBoxConfPassword.UnderlinedStyle = false;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBox1.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBox1.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBox1.BorderRadius = 10;
            roundedTextBox1.BorderSize = 2;
            roundedTextBox1.Font = new Font("Barlow Medium", 12F);
            roundedTextBox1.Location = new Point(283, 110);
            roundedTextBox1.Margin = new Padding(3, 4, 3, 4);
            roundedTextBox1.Multiline = false;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Padding = new Padding(8);
            roundedTextBox1.PasswordChar = false;
            roundedTextBox1.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBox1.PlaceholderText = "";
            roundedTextBox1.Size = new Size(485, 37);
            roundedTextBox1.TabIndex = 64;
            roundedTextBox1.Texts = "";
            roundedTextBox1.UnderlinedStyle = false;
            // 
            // roundedTextBoxEmail
            // 
            roundedTextBoxEmail.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxEmail.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxEmail.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxEmail.BorderRadius = 10;
            roundedTextBoxEmail.BorderSize = 2;
            roundedTextBoxEmail.Font = new Font("Barlow Medium", 12F);
            roundedTextBoxEmail.Location = new Point(283, 158);
            roundedTextBoxEmail.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxEmail.Multiline = false;
            roundedTextBoxEmail.Name = "roundedTextBoxEmail";
            roundedTextBoxEmail.Padding = new Padding(8);
            roundedTextBoxEmail.PasswordChar = false;
            roundedTextBoxEmail.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxEmail.PlaceholderText = "";
            roundedTextBoxEmail.Size = new Size(485, 37);
            roundedTextBoxEmail.TabIndex = 63;
            roundedTextBoxEmail.Texts = "";
            roundedTextBoxEmail.UnderlinedStyle = false;
            // 
            // FormNewRestaurant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(915, 415);
            Controls.Add(roundedTextBoxPassword);
            Controls.Add(roundedTextBoxConfPassword);
            Controls.Add(roundedTextBox1);
            Controls.Add(roundedTextBoxEmail);
            Controls.Add(labelConfPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(roundedButtonContinue);
            Controls.Add(roundedButtonCancel);
            Controls.Add(labelRestaurants);
            Name = "FormNewRestaurant";
            Text = "NewRestaurant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelRestaurants;
        private Controls.RoundedButton roundedButtonCancel;
        private Controls.RoundedButton roundedButtonContinue;
        private Label labelConfPassword;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelName;
        private Controls.RoundedTextBox roundedTextBoxPassword;
        private Controls.RoundedTextBox roundedTextBoxConfPassword;
        private Controls.RoundedTextBox roundedTextBox1;
        private Controls.RoundedTextBox roundedTextBoxEmail;
    }
}