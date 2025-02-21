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
            labelMusicians = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelRestaurants = new Label();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            roundedButtonCancel = new Controls.RoundedButton();
            roundedButtonContinue = new Controls.RoundedButton();
            SuspendLayout();
            // 
            // labelMusicians
            // 
            labelMusicians.AutoSize = true;
            labelMusicians.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMusicians.ForeColor = Color.FromArgb(239, 230, 220);
            labelMusicians.Location = new Point(88, 108);
            labelMusicians.Name = "labelMusicians";
            labelMusicians.Size = new Size(84, 24);
            labelMusicians.TabIndex = 3;
            labelMusicians.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 230, 220);
            label1.Location = new Point(88, 151);
            label1.Name = "label1";
            label1.Size = new Size(173, 24);
            label1.TabIndex = 4;
            label1.Text = "Correo Electronico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(239, 230, 220);
            label2.Location = new Point(88, 196);
            label2.Name = "label2";
            label2.Size = new Size(111, 24);
            label2.TabIndex = 5;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(239, 230, 220);
            label3.Location = new Point(88, 243);
            label3.Name = "label3";
            label3.Size = new Size(197, 24);
            label3.TabIndex = 6;
            label3.Text = "Confirmar Contraseña:";
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
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(32, 32, 31);
            textBoxName.Location = new Point(301, 113);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(483, 23);
            textBoxName.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(32, 32, 31);
            textBoxEmail.Location = new Point(301, 152);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(483, 23);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(32, 32, 31);
            textBoxPassword.Location = new Point(301, 197);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(483, 23);
            textBoxPassword.TabIndex = 10;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.BackColor = Color.FromArgb(32, 32, 31);
            textBoxConfirmPassword.Location = new Point(301, 244);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(483, 23);
            textBoxConfirmPassword.TabIndex = 11;
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
            // FormNewRestaurant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(915, 415);
            Controls.Add(roundedButtonContinue);
            Controls.Add(roundedButtonCancel);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(labelRestaurants);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelMusicians);
            Name = "FormNewRestaurant";
            Text = "NewRestaurant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMusicians;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelRestaurants;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxConfirmPassword;
        private Controls.RoundedButton roundedButtonCancel;
        private Controls.RoundedButton roundedButtonContinue;
    }
}