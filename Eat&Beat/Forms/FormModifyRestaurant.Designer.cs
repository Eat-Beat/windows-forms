namespace Eat_Beat.Forms
{
    partial class FormModifyRestaurant
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
            labelEditRestaurant = new Label();
            roundedTextBoxAddress = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxNumAddress = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxPassword = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxName = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxEmail = new Eat_Beat.Controls.RoundedTextBox();
            labelNumAddress = new Label();
            labelAddress = new Label();
            labelPassword = new Label();
            labelEmail = new Label();
            labelName = new Label();
            labelPostalCode = new Label();
            roundedTextBoxPostalCode = new Eat_Beat.Controls.RoundedTextBox();
            SuspendLayout();
            // 
            // roundedButtonModify
            // 
            roundedButtonModify.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonModify.FlatAppearance.BorderSize = 0;
            roundedButtonModify.FlatStyle = FlatStyle.Flat;
            roundedButtonModify.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonModify.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonModify.Location = new Point(788, 368);
            roundedButtonModify.Name = "roundedButtonModify";
            roundedButtonModify.Size = new Size(115, 45);
            roundedButtonModify.TabIndex = 39;
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
            roundedButtonCancel.Location = new Point(667, 368);
            roundedButtonCancel.Name = "roundedButtonCancel";
            roundedButtonCancel.Size = new Size(115, 45);
            roundedButtonCancel.TabIndex = 38;
            roundedButtonCancel.Text = "Cancelar";
            roundedButtonCancel.UseVisualStyleBackColor = false;
            roundedButtonCancel.Click += roundedButtonModify_Click_1;
            // 
            // labelEditRestaurant
            // 
            labelEditRestaurant.AutoSize = true;
            labelEditRestaurant.Font = new Font("Barlow Medium", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEditRestaurant.ForeColor = Color.FromArgb(239, 230, 220);
            labelEditRestaurant.Location = new Point(58, 24);
            labelEditRestaurant.Name = "labelEditRestaurant";
            labelEditRestaurant.Size = new Size(425, 40);
            labelEditRestaurant.TabIndex = 33;
            labelEditRestaurant.Text = "MODIFICAR RESTAURANTE:";
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
            roundedTextBoxAddress.Location = new Point(272, 219);
            roundedTextBoxAddress.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxAddress.Multiline = false;
            roundedTextBoxAddress.Name = "roundedTextBoxAddress";
            roundedTextBoxAddress.Padding = new Padding(8);
            roundedTextBoxAddress.PasswordChar = false;
            roundedTextBoxAddress.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxAddress.PlaceholderText = "";
            roundedTextBoxAddress.Size = new Size(483, 37);
            roundedTextBoxAddress.TabIndex = 52;
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
            roundedTextBoxNumAddress.Location = new Point(272, 265);
            roundedTextBoxNumAddress.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxNumAddress.Multiline = false;
            roundedTextBoxNumAddress.Name = "roundedTextBoxNumAddress";
            roundedTextBoxNumAddress.Padding = new Padding(8);
            roundedTextBoxNumAddress.PasswordChar = false;
            roundedTextBoxNumAddress.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxNumAddress.PlaceholderText = "";
            roundedTextBoxNumAddress.Size = new Size(483, 37);
            roundedTextBoxNumAddress.TabIndex = 51;
            roundedTextBoxNumAddress.Texts = "";
            roundedTextBoxNumAddress.UnderlinedStyle = false;
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
            roundedTextBoxPassword.TabIndex = 50;
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
            roundedTextBoxName.Location = new Point(272, 76);
            roundedTextBoxName.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxName.Multiline = false;
            roundedTextBoxName.Name = "roundedTextBoxName";
            roundedTextBoxName.Padding = new Padding(8);
            roundedTextBoxName.PasswordChar = false;
            roundedTextBoxName.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxName.PlaceholderText = "";
            roundedTextBoxName.Size = new Size(483, 37);
            roundedTextBoxName.TabIndex = 48;
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
            roundedTextBoxEmail.Location = new Point(272, 124);
            roundedTextBoxEmail.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxEmail.Multiline = false;
            roundedTextBoxEmail.Name = "roundedTextBoxEmail";
            roundedTextBoxEmail.Padding = new Padding(8);
            roundedTextBoxEmail.PasswordChar = false;
            roundedTextBoxEmail.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxEmail.PlaceholderText = "";
            roundedTextBoxEmail.Size = new Size(483, 37);
            roundedTextBoxEmail.TabIndex = 47;
            roundedTextBoxEmail.Texts = "";
            roundedTextBoxEmail.UnderlinedStyle = false;
            // 
            // labelNumAddress
            // 
            labelNumAddress.AutoSize = true;
            labelNumAddress.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumAddress.ForeColor = Color.FromArgb(239, 230, 220);
            labelNumAddress.Location = new Point(58, 267);
            labelNumAddress.Name = "labelNumAddress";
            labelNumAddress.Size = new Size(145, 24);
            labelNumAddress.TabIndex = 58;
            labelNumAddress.Text = "Num. Dirección:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.ForeColor = Color.FromArgb(239, 230, 220);
            labelAddress.Location = new Point(58, 221);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(97, 24);
            labelAddress.TabIndex = 57;
            labelAddress.Text = "Dirección:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.FromArgb(239, 230, 220);
            labelPassword.Location = new Point(58, 172);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(113, 24);
            labelPassword.TabIndex = 55;
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
            labelEmail.TabIndex = 54;
            labelEmail.Text = "Correo Electronico:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.FromArgb(239, 230, 220);
            labelName.Location = new Point(58, 79);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 24);
            labelName.TabIndex = 53;
            labelName.Text = "Nombre:";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPostalCode.ForeColor = Color.FromArgb(239, 230, 220);
            labelPostalCode.Location = new Point(58, 314);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(133, 24);
            labelPostalCode.TabIndex = 60;
            labelPostalCode.Text = "Código Postal:";
            // 
            // roundedTextBoxPostalCode
            // 
            roundedTextBoxPostalCode.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxPostalCode.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxPostalCode.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxPostalCode.BorderRadius = 10;
            roundedTextBoxPostalCode.BorderSize = 2;
            roundedTextBoxPostalCode.Font = new Font("Barlow Medium", 12F);
            roundedTextBoxPostalCode.ForeColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxPostalCode.Location = new Point(272, 313);
            roundedTextBoxPostalCode.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxPostalCode.Multiline = false;
            roundedTextBoxPostalCode.Name = "roundedTextBoxPostalCode";
            roundedTextBoxPostalCode.Padding = new Padding(8);
            roundedTextBoxPostalCode.PasswordChar = false;
            roundedTextBoxPostalCode.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxPostalCode.PlaceholderText = "";
            roundedTextBoxPostalCode.Size = new Size(483, 37);
            roundedTextBoxPostalCode.TabIndex = 59;
            roundedTextBoxPostalCode.Texts = "";
            roundedTextBoxPostalCode.UnderlinedStyle = false;
            // 
            // FormModifyRestaurant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(915, 415);
            Controls.Add(labelPostalCode);
            Controls.Add(roundedTextBoxPostalCode);
            Controls.Add(labelNumAddress);
            Controls.Add(labelAddress);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(roundedTextBoxAddress);
            Controls.Add(roundedTextBoxNumAddress);
            Controls.Add(roundedTextBoxPassword);
            Controls.Add(roundedTextBoxName);
            Controls.Add(roundedTextBoxEmail);
            Controls.Add(roundedButtonModify);
            Controls.Add(roundedButtonCancel);
            Controls.Add(labelEditRestaurant);
            Name = "FormModifyRestaurant";
            Text = "ModifyRestaurant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Controls.RoundedButton roundedButtonModify;
        private Controls.RoundedButton roundedButtonCancel;
        private Label labelEditRestaurant;
        private Controls.RoundedTextBox roundedTextBoxAddress;
        private Controls.RoundedTextBox roundedTextBoxNumAddress;
        private Controls.RoundedTextBox roundedTextBoxPassword;
        private Controls.RoundedTextBox roundedTextBoxName;
        private Controls.RoundedTextBox roundedTextBoxEmail;
        private Label labelNumAddress;
        private Label labelAddress;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelName;
        private Label labelPostalCode;
        private Controls.RoundedTextBox roundedTextBoxPostalCode;
    }
}