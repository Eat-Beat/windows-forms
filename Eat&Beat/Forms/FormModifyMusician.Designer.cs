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
            roundedButtonModify = new Controls.RoundedButton();
            roundedButtonCancel = new Controls.RoundedButton();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            labelRestaurants = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBoxConfirmPassword = new TextBox();
            labelMusicians = new Label();
            textBoxName = new TextBox();
            textBoxAddressNumber = new TextBox();
            textBoxAddress = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // roundedButtonModify
            // 
            roundedButtonModify.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonModify.FlatAppearance.BorderSize = 0;
            roundedButtonModify.FlatStyle = FlatStyle.Flat;
            roundedButtonModify.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonModify.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonModify.Location = new Point(740, 342);
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
            roundedButtonCancel.Location = new Point(619, 342);
            roundedButtonCancel.Name = "roundedButtonCancel";
            roundedButtonCancel.Size = new Size(115, 45);
            roundedButtonCancel.TabIndex = 23;
            roundedButtonCancel.Text = "Cancelar";
            roundedButtonCancel.UseVisualStyleBackColor = false;
            roundedButtonCancel.Click += roundedButtonCancel_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(32, 32, 31);
            textBoxPassword.Location = new Point(272, 172);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(483, 23);
            textBoxPassword.TabIndex = 21;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(32, 32, 31);
            textBoxEmail.Location = new Point(272, 127);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(483, 23);
            textBoxEmail.TabIndex = 20;
            // 
            // labelRestaurants
            // 
            labelRestaurants.AutoSize = true;
            labelRestaurants.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRestaurants.ForeColor = Color.FromArgb(239, 230, 220);
            labelRestaurants.Location = new Point(228, 28);
            labelRestaurants.Name = "labelRestaurants";
            labelRestaurants.Size = new Size(355, 37);
            labelRestaurants.TabIndex = 18;
            labelRestaurants.Text = "MODIFICAR MUSICO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(239, 230, 220);
            label2.Location = new Point(59, 171);
            label2.Name = "label2";
            label2.Size = new Size(111, 24);
            label2.TabIndex = 16;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 230, 220);
            label1.Location = new Point(59, 126);
            label1.Name = "label1";
            label1.Size = new Size(173, 24);
            label1.TabIndex = 15;
            label1.Text = "Correo Electronico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(239, 230, 220);
            label3.Location = new Point(59, 218);
            label3.Name = "label3";
            label3.Size = new Size(197, 24);
            label3.TabIndex = 17;
            label3.Text = "Confirmar Contraseña:";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.BackColor = Color.FromArgb(32, 32, 31);
            textBoxConfirmPassword.Location = new Point(272, 219);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(483, 23);
            textBoxConfirmPassword.TabIndex = 22;
            // 
            // labelMusicians
            // 
            labelMusicians.AutoSize = true;
            labelMusicians.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMusicians.ForeColor = Color.FromArgb(239, 230, 220);
            labelMusicians.Location = new Point(59, 83);
            labelMusicians.Name = "labelMusicians";
            labelMusicians.Size = new Size(84, 24);
            labelMusicians.TabIndex = 14;
            labelMusicians.Text = "Nombre:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(32, 32, 31);
            textBoxName.Location = new Point(272, 88);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(483, 23);
            textBoxName.TabIndex = 19;
            // 
            // textBoxAddressNumber
            // 
            textBoxAddressNumber.BackColor = Color.FromArgb(32, 32, 31);
            textBoxAddressNumber.Location = new Point(272, 298);
            textBoxAddressNumber.Name = "textBoxAddressNumber";
            textBoxAddressNumber.Size = new Size(483, 23);
            textBoxAddressNumber.TabIndex = 28;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.FromArgb(32, 32, 31);
            textBoxAddress.Location = new Point(272, 259);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(483, 23);
            textBoxAddress.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(239, 230, 220);
            label4.Location = new Point(59, 297);
            label4.Name = "label4";
            label4.Size = new Size(146, 24);
            label4.TabIndex = 26;
            label4.Text = "Num. Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(239, 230, 220);
            label5.Location = new Point(59, 254);
            label5.Name = "label5";
            label5.Size = new Size(95, 24);
            label5.TabIndex = 25;
            label5.Text = "Dirección:";
            // 
            // FormModifyMusician
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(915, 415);
            Controls.Add(textBoxAddressNumber);
            Controls.Add(textBoxAddress);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(roundedButtonModify);
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
            Name = "FormModifyMusician";
            Text = "ModifyMusician";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.RoundedButton roundedButtonModify;
        private Controls.RoundedButton roundedButtonCancel;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Label labelRestaurants;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBoxConfirmPassword;
        private Label labelMusicians;
        private TextBox textBoxName;
        private TextBox textBoxAddressNumber;
        private TextBox textBoxAddress;
        private Label label4;
        private Label label5;
    }
}