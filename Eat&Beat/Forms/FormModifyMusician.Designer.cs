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
            labelEditMusician = new Label();
            labelPassword = new Label();
            labelEmail = new Label();
            labelConfPassword = new Label();
            labelName = new Label();
            labelNumAddress = new Label();
            labelAddress = new Label();
            roundedTextBoxEmail = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxName = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxPassword = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxConfPassword = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxAddress = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxNumAddress = new Eat_Beat.Controls.RoundedTextBox();
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
            roundedButtonModify.TabIndex = 15;
            roundedButtonModify.Text = "Modificar";
            roundedButtonModify.UseVisualStyleBackColor = false;
            roundedButtonModify.Click += roundedButtonModify_Click;
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
            roundedButtonCancel.TabIndex = 14;
            roundedButtonCancel.Text = "Cancelar";
            roundedButtonCancel.UseVisualStyleBackColor = false;
            roundedButtonCancel.Click += roundedButtonCancel_Click;
            // 
            // labelEditMusician
            // 
            labelEditMusician.AutoSize = true;
            labelEditMusician.Font = new Font("Barlow Medium", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEditMusician.ForeColor = Color.FromArgb(239, 230, 220);
            labelEditMusician.Location = new Point(58, 24);
            labelEditMusician.Name = "labelEditMusician";
            labelEditMusician.Size = new Size(305, 40);
            labelEditMusician.TabIndex = 1;
            labelEditMusician.Text = "MODIFICAR MUSICO";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.FromArgb(239, 230, 220);
            labelPassword.Location = new Point(58, 172);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(113, 24);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Contraseña:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.FromArgb(239, 230, 220);
            labelEmail.Location = new Point(58, 127);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(176, 24);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Correo Electronico:";
            // 
            // labelConfPassword
            // 
            labelConfPassword.AutoSize = true;
            labelConfPassword.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelConfPassword.ForeColor = Color.FromArgb(239, 230, 220);
            labelConfPassword.Location = new Point(58, 221);
            labelConfPassword.Name = "labelConfPassword";
            labelConfPassword.Size = new Size(202, 24);
            labelConfPassword.TabIndex = 8;
            labelConfPassword.Text = "Confirmar Contraseña:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.FromArgb(239, 230, 220);
            labelName.Location = new Point(58, 79);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 24);
            labelName.TabIndex = 2;
            labelName.Text = "Nombre:";
            // 
            // labelNumAddress
            // 
            labelNumAddress.AutoSize = true;
            labelNumAddress.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumAddress.ForeColor = Color.FromArgb(239, 230, 220);
            labelNumAddress.Location = new Point(58, 314);
            labelNumAddress.Name = "labelNumAddress";
            labelNumAddress.Size = new Size(145, 24);
            labelNumAddress.TabIndex = 12;
            labelNumAddress.Text = "Num. Dirección:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.ForeColor = Color.FromArgb(239, 230, 220);
            labelAddress.Location = new Point(58, 267);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(97, 24);
            labelAddress.TabIndex = 10;
            labelAddress.Text = "Dirección:";
            // 
            // roundedTextBoxEmail
            // 
            roundedTextBoxEmail.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxEmail.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxEmail.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxEmail.BorderRadius = 10;
            roundedTextBoxEmail.BorderSize = 2;
            roundedTextBoxEmail.Font = new Font("Barlow Medium", 12F);
            roundedTextBoxEmail.ForeColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxEmail.Location = new Point(272, 124);
            roundedTextBoxEmail.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxEmail.Multiline = false;
            roundedTextBoxEmail.Name = "roundedTextBoxEmail";
            roundedTextBoxEmail.Padding = new Padding(8);
            roundedTextBoxEmail.PasswordChar = false;
            roundedTextBoxEmail.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxEmail.PlaceholderText = "";
            roundedTextBoxEmail.Size = new Size(483, 37);
            roundedTextBoxEmail.TabIndex = 5;
            roundedTextBoxEmail.Texts = "";
            roundedTextBoxEmail.UnderlinedStyle = false;
            // 
            // roundedTextBoxName
            // 
            roundedTextBoxName.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxName.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxName.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxName.BorderRadius = 10;
            roundedTextBoxName.BorderSize = 2;
            roundedTextBoxName.Font = new Font("Barlow Medium", 12F);
            roundedTextBoxName.ForeColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxName.Location = new Point(272, 76);
            roundedTextBoxName.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxName.Multiline = false;
            roundedTextBoxName.Name = "roundedTextBoxName";
            roundedTextBoxName.Padding = new Padding(8);
            roundedTextBoxName.PasswordChar = false;
            roundedTextBoxName.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxName.PlaceholderText = "";
            roundedTextBoxName.Size = new Size(483, 37);
            roundedTextBoxName.TabIndex = 3;
            roundedTextBoxName.Texts = "";
            roundedTextBoxName.UnderlinedStyle = false;
            // 
            // roundedTextBoxPassword
            // 
            roundedTextBoxPassword.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxPassword.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxPassword.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxPassword.BorderRadius = 10;
            roundedTextBoxPassword.BorderSize = 2;
            roundedTextBoxPassword.Font = new Font("Barlow Medium", 12F);
            roundedTextBoxPassword.ForeColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxPassword.Location = new Point(272, 171);
            roundedTextBoxPassword.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxPassword.Multiline = false;
            roundedTextBoxPassword.Name = "roundedTextBoxPassword";
            roundedTextBoxPassword.Padding = new Padding(8);
            roundedTextBoxPassword.PasswordChar = false;
            roundedTextBoxPassword.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxPassword.PlaceholderText = "";
            roundedTextBoxPassword.Size = new Size(483, 37);
            roundedTextBoxPassword.TabIndex = 7;
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
            roundedTextBoxConfPassword.ForeColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxConfPassword.Location = new Point(272, 219);
            roundedTextBoxConfPassword.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxConfPassword.Multiline = false;
            roundedTextBoxConfPassword.Name = "roundedTextBoxConfPassword";
            roundedTextBoxConfPassword.Padding = new Padding(8);
            roundedTextBoxConfPassword.PasswordChar = false;
            roundedTextBoxConfPassword.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxConfPassword.PlaceholderText = "";
            roundedTextBoxConfPassword.Size = new Size(483, 37);
            roundedTextBoxConfPassword.TabIndex = 9;
            roundedTextBoxConfPassword.Texts = "";
            roundedTextBoxConfPassword.UnderlinedStyle = false;
            // 
            // roundedTextBoxAddress
            // 
            roundedTextBoxAddress.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxAddress.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxAddress.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxAddress.BorderRadius = 10;
            roundedTextBoxAddress.BorderSize = 2;
            roundedTextBoxAddress.Font = new Font("Barlow Medium", 12F);
            roundedTextBoxAddress.ForeColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxAddress.Location = new Point(272, 265);
            roundedTextBoxAddress.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxAddress.Multiline = false;
            roundedTextBoxAddress.Name = "roundedTextBoxAddress";
            roundedTextBoxAddress.Padding = new Padding(8);
            roundedTextBoxAddress.PasswordChar = false;
            roundedTextBoxAddress.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxAddress.PlaceholderText = "";
            roundedTextBoxAddress.Size = new Size(483, 37);
            roundedTextBoxAddress.TabIndex = 11;
            roundedTextBoxAddress.Texts = "";
            roundedTextBoxAddress.UnderlinedStyle = false;
            // 
            // roundedTextBoxNumAddress
            // 
            roundedTextBoxNumAddress.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxNumAddress.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxNumAddress.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxNumAddress.BorderRadius = 10;
            roundedTextBoxNumAddress.BorderSize = 2;
            roundedTextBoxNumAddress.Font = new Font("Barlow Medium", 12F);
            roundedTextBoxNumAddress.ForeColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxNumAddress.Location = new Point(272, 313);
            roundedTextBoxNumAddress.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxNumAddress.Multiline = false;
            roundedTextBoxNumAddress.Name = "roundedTextBoxNumAddress";
            roundedTextBoxNumAddress.Padding = new Padding(8);
            roundedTextBoxNumAddress.PasswordChar = false;
            roundedTextBoxNumAddress.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxNumAddress.PlaceholderText = "";
            roundedTextBoxNumAddress.Size = new Size(483, 37);
            roundedTextBoxNumAddress.TabIndex = 13;
            roundedTextBoxNumAddress.Texts = "";
            roundedTextBoxNumAddress.UnderlinedStyle = false;
            // 
            // FormModifyMusician
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(915, 415);
            Controls.Add(roundedTextBoxAddress);
            Controls.Add(roundedTextBoxNumAddress);
            Controls.Add(roundedTextBoxPassword);
            Controls.Add(roundedTextBoxConfPassword);
            Controls.Add(roundedTextBoxName);
            Controls.Add(roundedTextBoxEmail);
            Controls.Add(labelNumAddress);
            Controls.Add(labelAddress);
            Controls.Add(roundedButtonModify);
            Controls.Add(roundedButtonCancel);
            Controls.Add(labelEditMusician);
            Controls.Add(labelConfPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Name = "FormModifyMusician";
            Text = "ModifyMusician";
            Load += FormModifyMusician_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.RoundedButton roundedButtonModify;
        private Controls.RoundedButton roundedButtonCancel;
        private Label labelEditMusician;
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
        private Controls.RoundedTextBox roundedTextBoxName;
        private Controls.RoundedTextBox roundedTextBoxPassword;
        private Controls.RoundedTextBox roundedTextBoxConfPassword;
        private Controls.RoundedTextBox roundedTextBoxAddress;
        private Controls.RoundedTextBox roundedTextBoxNumAddress;
    }
}