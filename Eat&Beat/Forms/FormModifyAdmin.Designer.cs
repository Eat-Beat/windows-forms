namespace Eat_Beat.Forms
{
    partial class FormModifyAdmin
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
            roundedComboBoxRol = new Eat_Beat.Controls.RoundedComboBox();
            labelRol = new Label();
            roundedTextBoxPassword = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxName = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxEmail = new Eat_Beat.Controls.RoundedTextBox();
            labelPassword = new Label();
            labelEmail = new Label();
            labelName = new Label();
            labelEditAdmin = new Label();
            roundedButtonModify = new Eat_Beat.Controls.RoundedButton();
            roundedButtonCancel = new Eat_Beat.Controls.RoundedButton();
            SuspendLayout();
            // 
            // roundedComboBoxRol
            // 
            roundedComboBoxRol.BackColor = Color.FromArgb(32, 32, 31);
            roundedComboBoxRol.BorderColor = Color.FromArgb(239, 230, 220);
            roundedComboBoxRol.BorderSize = 1;
            roundedComboBoxRol.DropDownStyle = ComboBoxStyle.DropDown;
            roundedComboBoxRol.Font = new Font("Barlow Medium", 14F);
            roundedComboBoxRol.ForeColor = Color.FromArgb(239, 230, 220);
            roundedComboBoxRol.IconColor = Color.FromArgb(239, 230, 220);
            roundedComboBoxRol.Items.AddRange(new object[] { "Superuser", "Admin", "Manteniment" });
            roundedComboBoxRol.ListBackColor = Color.FromArgb(64, 64, 62);
            roundedComboBoxRol.ListTextColor = Color.FromArgb(239, 230, 220);
            roundedComboBoxRol.Location = new Point(277, 275);
            roundedComboBoxRol.MinimumSize = new Size(100, 30);
            roundedComboBoxRol.Name = "roundedComboBoxRol";
            roundedComboBoxRol.Padding = new Padding(1);
            roundedComboBoxRol.Size = new Size(485, 37);
            roundedComboBoxRol.TabIndex = 22;
            roundedComboBoxRol.Texts = "";
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRol.ForeColor = Color.FromArgb(239, 230, 220);
            labelRol.Location = new Point(65, 281);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(45, 24);
            labelRol.TabIndex = 21;
            labelRol.Text = "Rol:";
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
            roundedTextBoxPassword.Location = new Point(277, 223);
            roundedTextBoxPassword.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxPassword.Multiline = false;
            roundedTextBoxPassword.Name = "roundedTextBoxPassword";
            roundedTextBoxPassword.Padding = new Padding(8);
            roundedTextBoxPassword.PasswordChar = false;
            roundedTextBoxPassword.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxPassword.PlaceholderText = "";
            roundedTextBoxPassword.Size = new Size(485, 37);
            roundedTextBoxPassword.TabIndex = 18;
            roundedTextBoxPassword.Texts = "";
            roundedTextBoxPassword.UnderlinedStyle = false;
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
            roundedTextBoxName.Location = new Point(277, 128);
            roundedTextBoxName.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxName.Multiline = false;
            roundedTextBoxName.Name = "roundedTextBoxName";
            roundedTextBoxName.Padding = new Padding(8);
            roundedTextBoxName.PasswordChar = false;
            roundedTextBoxName.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxName.PlaceholderText = "";
            roundedTextBoxName.Size = new Size(485, 37);
            roundedTextBoxName.TabIndex = 14;
            roundedTextBoxName.Texts = "";
            roundedTextBoxName.UnderlinedStyle = false;
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
            roundedTextBoxEmail.Location = new Point(277, 176);
            roundedTextBoxEmail.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxEmail.Multiline = false;
            roundedTextBoxEmail.Name = "roundedTextBoxEmail";
            roundedTextBoxEmail.Padding = new Padding(8);
            roundedTextBoxEmail.PasswordChar = false;
            roundedTextBoxEmail.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxEmail.PlaceholderText = "";
            roundedTextBoxEmail.Size = new Size(485, 37);
            roundedTextBoxEmail.TabIndex = 16;
            roundedTextBoxEmail.Texts = "";
            roundedTextBoxEmail.UnderlinedStyle = false;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.FromArgb(239, 230, 220);
            labelPassword.Location = new Point(65, 231);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(113, 24);
            labelPassword.TabIndex = 17;
            labelPassword.Text = "Contraseña:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.FromArgb(239, 230, 220);
            labelEmail.Location = new Point(65, 184);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(176, 24);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Correo Electronico:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.FromArgb(239, 230, 220);
            labelName.Location = new Point(65, 137);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 24);
            labelName.TabIndex = 13;
            labelName.Text = "Nombre:";
            // 
            // labelEditAdmin
            // 
            labelEditAdmin.AutoSize = true;
            labelEditAdmin.Font = new Font("Barlow Medium", 23.9999962F, FontStyle.Bold);
            labelEditAdmin.ForeColor = Color.FromArgb(239, 230, 220);
            labelEditAdmin.Location = new Point(61, 46);
            labelEditAdmin.Name = "labelEditAdmin";
            labelEditAdmin.Size = new Size(286, 40);
            labelEditAdmin.TabIndex = 12;
            labelEditAdmin.Text = "MODIFICAR ADMIN";
            // 
            // roundedButtonModify
            // 
            roundedButtonModify.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonModify.FlatAppearance.BorderSize = 0;
            roundedButtonModify.FlatStyle = FlatStyle.Flat;
            roundedButtonModify.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonModify.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonModify.Location = new Point(807, 354);
            roundedButtonModify.Name = "roundedButtonModify";
            roundedButtonModify.Size = new Size(115, 45);
            roundedButtonModify.TabIndex = 24;
            roundedButtonModify.Text = "Continuar";
            roundedButtonModify.UseVisualStyleBackColor = false;
            roundedButtonModify.Click += roundedButton1_Click;
            // 
            // roundedButtonCancel
            // 
            roundedButtonCancel.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonCancel.FlatAppearance.BorderSize = 0;
            roundedButtonCancel.FlatStyle = FlatStyle.Flat;
            roundedButtonCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonCancel.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonCancel.Location = new Point(686, 354);
            roundedButtonCancel.Name = "roundedButtonCancel";
            roundedButtonCancel.Size = new Size(115, 45);
            roundedButtonCancel.TabIndex = 23;
            roundedButtonCancel.Text = "Cancelar";
            roundedButtonCancel.UseVisualStyleBackColor = false;
            roundedButtonCancel.Click += roundedButton2_Click;
            // 
            // FormModifyAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(934, 411);
            Controls.Add(roundedButtonModify);
            Controls.Add(roundedButtonCancel);
            Controls.Add(roundedComboBoxRol);
            Controls.Add(labelRol);
            Controls.Add(roundedTextBoxPassword);
            Controls.Add(roundedTextBoxName);
            Controls.Add(roundedTextBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(labelEditAdmin);
            Name = "FormModifyAdmin";
            Text = "ModifyAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.RoundedComboBox roundedComboBoxRol;
        private Label labelRol;
        private Controls.RoundedTextBox roundedTextBoxPassword;
        private Controls.RoundedTextBox roundedTextBoxName;
        private Controls.RoundedTextBox roundedTextBoxEmail;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelName;
        private Label labelEditAdmin;
        private Controls.RoundedButton roundedButtonModify;
        private Controls.RoundedButton roundedButtonCancel;
    }
}