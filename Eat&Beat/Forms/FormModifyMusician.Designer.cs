namespace Eat_Beat.Forms
{
    partial class FormModifyMusician
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
            roundedButtonModify = new Eat_Beat.Controls.RoundedButton();
            roundedButtonCancel = new Eat_Beat.Controls.RoundedButton();
            labelRestaurants = new Label();
            labelPassword = new Label();
            labelEmail = new Label();
            labelConfPassword = new Label();
            labelName = new Label();
            labelNumAddress = new Label();
            labelAddress = new Label();
            roundedTextBoxEmail = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxConfPassword = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxPassword = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxNumAddress = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxAddress = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxName = new Eat_Beat.Controls.RoundedTextBox();
            SuspendLayout();
            // 
            // roundedButtonModify
            // 
            roundedButtonModify.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonModify.FlatAppearance.BorderSize = 0;
            roundedButtonModify.FlatStyle = FlatStyle.Flat;
            roundedButtonModify.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonModify.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonModify.Location = new Point(788, 358);
            roundedButtonModify.Name = "roundedButtonModify";
            roundedButtonModify.Size = new Size(115, 45);
            roundedButtonModify.TabIndex = 24;
            roundedButtonModify.Text = "Modificar";
            roundedButtonModify.UseVisualStyleBackColor = false;
            // 
            // roundedButtonCancel
            // 
            roundedButtonCancel.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonCancel.FlatAppearance.BorderSize = 0;
            roundedButtonCancel.FlatStyle = FlatStyle.Flat;
            roundedButtonCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonCancel.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonCancel.Location = new Point(667, 358);
            roundedButtonCancel.Name = "roundedButtonCancel";
            roundedButtonCancel.Size = new Size(115, 45);
            roundedButtonCancel.TabIndex = 23;
            roundedButtonCancel.Text = "Cancelar";
            roundedButtonCancel.UseVisualStyleBackColor = false;
            roundedButtonCancel.Click += roundedButtonCancel_Click;
            // 
            // labelRestaurants
            // 
            labelRestaurants.AutoSize = true;
            labelRestaurants.Font = new Font("Barlow Medium", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRestaurants.ForeColor = Color.FromArgb(239, 230, 220);
            labelRestaurants.Location = new Point(272, 24);
            labelRestaurants.Name = "labelRestaurants";
            labelRestaurants.Size = new Size(317, 40);
            labelRestaurants.TabIndex = 18;
            labelRestaurants.Text = "MODIFICAR MUSICO:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.FromArgb(239, 230, 220);
            labelPassword.Location = new Point(59, 171);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(113, 24);
            labelPassword.TabIndex = 16;
            labelPassword.Text = "Contraseña:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.FromArgb(239, 230, 220);
            labelEmail.Location = new Point(59, 126);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(176, 24);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Correo Electronico:";
            // 
            // labelConfPassword
            // 
            labelConfPassword.AutoSize = true;
            labelConfPassword.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelConfPassword.ForeColor = Color.FromArgb(239, 230, 220);
            labelConfPassword.Location = new Point(59, 218);
            labelConfPassword.Name = "labelConfPassword";
            labelConfPassword.Size = new Size(202, 24);
            labelConfPassword.TabIndex = 17;
            labelConfPassword.Text = "Confirmar Contraseña:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.FromArgb(239, 230, 220);
            labelName.Location = new Point(59, 83);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 24);
            labelName.TabIndex = 14;
            labelName.Text = "Nombre:";
            // 
            // labelNumAddress
            // 
            labelNumAddress.AutoSize = true;
            labelNumAddress.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumAddress.ForeColor = Color.FromArgb(239, 230, 220);
            labelNumAddress.Location = new Point(59, 302);
            labelNumAddress.Name = "labelNumAddress";
            labelNumAddress.Size = new Size(145, 24);
            labelNumAddress.TabIndex = 26;
            labelNumAddress.Text = "Num. Dirección:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.ForeColor = Color.FromArgb(239, 230, 220);
            labelAddress.Location = new Point(59, 261);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(97, 24);
            labelAddress.TabIndex = 25;
            labelAddress.Text = "Dirección:";
            // 
            // roundedTextBoxEmail
            // 
            roundedTextBoxEmail.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxEmail.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxEmail.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxEmail.BorderRadius = 10;
            roundedTextBoxEmail.BorderSize = 2;
            roundedTextBoxEmail.Font = new Font("Barlow Medium", 8F);
            roundedTextBoxEmail.Location = new Point(272, 126);
            roundedTextBoxEmail.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxEmail.Multiline = false;
            roundedTextBoxEmail.Name = "roundedTextBoxEmail";
            roundedTextBoxEmail.Padding = new Padding(6, 9, 6, 9);
            roundedTextBoxEmail.PasswordChar = false;
            roundedTextBoxEmail.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxEmail.PlaceholderText = "";
            roundedTextBoxEmail.Size = new Size(483, 33);
            roundedTextBoxEmail.TabIndex = 31;
            roundedTextBoxEmail.Texts = "";
            roundedTextBoxEmail.UnderlinedStyle = false;
            // 
            // roundedTextBoxConfPassword
            // 
            roundedTextBoxConfPassword.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxConfPassword.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxConfPassword.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxConfPassword.BorderRadius = 10;
            roundedTextBoxConfPassword.BorderSize = 2;
            roundedTextBoxConfPassword.Font = new Font("Barlow Medium", 8F);
            roundedTextBoxConfPassword.Location = new Point(272, 215);
            roundedTextBoxConfPassword.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxConfPassword.Multiline = false;
            roundedTextBoxConfPassword.Name = "roundedTextBoxConfPassword";
            roundedTextBoxConfPassword.Padding = new Padding(6, 9, 6, 9);
            roundedTextBoxConfPassword.PasswordChar = false;
            roundedTextBoxConfPassword.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxConfPassword.PlaceholderText = "";
            roundedTextBoxConfPassword.Size = new Size(483, 33);
            roundedTextBoxConfPassword.TabIndex = 33;
            roundedTextBoxConfPassword.Texts = "";
            roundedTextBoxConfPassword.UnderlinedStyle = false;
            // 
            // roundedTextBoxPassword
            // 
            roundedTextBoxPassword.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxPassword.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxPassword.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxPassword.BorderRadius = 10;
            roundedTextBoxPassword.BorderSize = 2;
            roundedTextBoxPassword.Font = new Font("Barlow Medium", 8F);
            roundedTextBoxPassword.Location = new Point(272, 171);
            roundedTextBoxPassword.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxPassword.Multiline = false;
            roundedTextBoxPassword.Name = "roundedTextBoxPassword";
            roundedTextBoxPassword.Padding = new Padding(6, 9, 6, 9);
            roundedTextBoxPassword.PasswordChar = false;
            roundedTextBoxPassword.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxPassword.PlaceholderText = "";
            roundedTextBoxPassword.Size = new Size(483, 33);
            roundedTextBoxPassword.TabIndex = 32;
            roundedTextBoxPassword.Texts = "";
            roundedTextBoxPassword.UnderlinedStyle = false;
            // 
            // roundedTextBoxNumAddress
            // 
            roundedTextBoxNumAddress.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxNumAddress.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxNumAddress.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxNumAddress.BorderRadius = 10;
            roundedTextBoxNumAddress.BorderSize = 2;
            roundedTextBoxNumAddress.Font = new Font("Barlow Medium", 8F);
            roundedTextBoxNumAddress.Location = new Point(272, 300);
            roundedTextBoxNumAddress.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxNumAddress.Multiline = false;
            roundedTextBoxNumAddress.Name = "roundedTextBoxNumAddress";
            roundedTextBoxNumAddress.Padding = new Padding(6, 9, 6, 9);
            roundedTextBoxNumAddress.PasswordChar = false;
            roundedTextBoxNumAddress.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxNumAddress.PlaceholderText = "";
            roundedTextBoxNumAddress.Size = new Size(483, 33);
            roundedTextBoxNumAddress.TabIndex = 35;
            roundedTextBoxNumAddress.Texts = "";
            roundedTextBoxNumAddress.UnderlinedStyle = false;
            // 
            // roundedTextBoxAddress
            // 
            roundedTextBoxAddress.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxAddress.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxAddress.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxAddress.BorderRadius = 10;
            roundedTextBoxAddress.BorderSize = 2;
            roundedTextBoxAddress.Font = new Font("Barlow Medium", 8F);
            roundedTextBoxAddress.Location = new Point(272, 256);
            roundedTextBoxAddress.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxAddress.Multiline = false;
            roundedTextBoxAddress.Name = "roundedTextBoxAddress";
            roundedTextBoxAddress.Padding = new Padding(6, 9, 6, 9);
            roundedTextBoxAddress.PasswordChar = false;
            roundedTextBoxAddress.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxAddress.PlaceholderText = "";
            roundedTextBoxAddress.Size = new Size(483, 33);
            roundedTextBoxAddress.TabIndex = 34;
            roundedTextBoxAddress.Texts = "";
            roundedTextBoxAddress.UnderlinedStyle = false;
            // 
            // roundedTextBoxName
            // 
            roundedTextBoxName.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxName.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxName.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxName.BorderRadius = 10;
            roundedTextBoxName.BorderSize = 2;
            roundedTextBoxName.Font = new Font("Barlow Medium", 8F);
            roundedTextBoxName.Location = new Point(272, 83);
            roundedTextBoxName.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxName.Multiline = false;
            roundedTextBoxName.Name = "roundedTextBoxName";
            roundedTextBoxName.Padding = new Padding(6, 9, 6, 9);
            roundedTextBoxName.PasswordChar = false;
            roundedTextBoxName.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxName.PlaceholderText = "";
            roundedTextBoxName.Size = new Size(483, 33);
            roundedTextBoxName.TabIndex = 36;
            roundedTextBoxName.Texts = "";
            roundedTextBoxName.UnderlinedStyle = false;
            // 
            // FormModifyMusician
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(915, 415);
            Controls.Add(roundedTextBoxName);
            Controls.Add(roundedTextBoxNumAddress);
            Controls.Add(roundedTextBoxAddress);
            Controls.Add(roundedTextBoxConfPassword);
            Controls.Add(roundedTextBoxPassword);
            Controls.Add(roundedTextBoxEmail);
            Controls.Add(labelNumAddress);
            Controls.Add(labelAddress);
            Controls.Add(roundedButtonModify);
            Controls.Add(roundedButtonCancel);
            Controls.Add(labelRestaurants);
            Controls.Add(labelConfPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Name = "FormModifyMusician";
            Text = "ModifyMusician";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.RoundedButton roundedButtonModify;
        private Controls.RoundedButton roundedButtonCancel;
        private Label labelRestaurants;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelConfPassword;
        private Label labelName;
        private TextBox textBoxAddressNumber;
        private TextBox textBoxAddress;
        private Label labelNumAddress;
        private Label labelAddress;
        private Controls.RoundedTextBox roundedTextBox2;
        private Controls.RoundedTextBox roundedTextBoxEmail;
        private Controls.RoundedTextBox roundedTextBoxConfPassword;
        private Controls.RoundedTextBox roundedTextBoxPassword;
        private Controls.RoundedTextBox roundedTextBoxNumAddress;
        private Controls.RoundedTextBox roundedTextBoxAddress;
        private Controls.RoundedTextBox roundedTextBoxName;
    }
}