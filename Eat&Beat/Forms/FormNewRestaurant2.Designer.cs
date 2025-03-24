namespace Eat_Beat.Forms
{
    partial class FormNewRestaurant2
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
            labelNewRestaurant = new Label();
            roundedButtonCancel = new Eat_Beat.Controls.RoundedButton();
            roundedButtonCreate = new Eat_Beat.Controls.RoundedButton();
            labelPostalCode = new Label();
            labelNum = new Label();
            labelAddress = new Label();
            roundedTextBoxAddress = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxNum = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxPostalCode = new Eat_Beat.Controls.RoundedTextBox();
            SuspendLayout();
            // 
            // labelNewRestaurant
            // 
            labelNewRestaurant.AutoSize = true;
            labelNewRestaurant.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewRestaurant.ForeColor = Color.FromArgb(239, 230, 220);
            labelNewRestaurant.Location = new Point(257, 44);
            labelNewRestaurant.Name = "labelNewRestaurant";
            labelNewRestaurant.Size = new Size(406, 37);
            labelNewRestaurant.TabIndex = 7;
            labelNewRestaurant.Text = "NUEVO RESTAURANTE:";
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
            // roundedButtonCreate
            // 
            roundedButtonCreate.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonCreate.FlatAppearance.BorderSize = 0;
            roundedButtonCreate.FlatStyle = FlatStyle.Flat;
            roundedButtonCreate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonCreate.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonCreate.Location = new Point(769, 358);
            roundedButtonCreate.Name = "roundedButtonCreate";
            roundedButtonCreate.Size = new Size(115, 45);
            roundedButtonCreate.TabIndex = 13;
            roundedButtonCreate.Text = "Crear";
            roundedButtonCreate.UseVisualStyleBackColor = false;
            roundedButtonCreate.Click += roundedButtonCreate_Click;
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPostalCode.ForeColor = Color.FromArgb(239, 230, 220);
            labelPostalCode.Location = new Point(67, 243);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(133, 24);
            labelPostalCode.TabIndex = 60;
            labelPostalCode.Text = "Código Postal:";
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNum.ForeColor = Color.FromArgb(239, 230, 220);
            labelNum.Location = new Point(67, 193);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(84, 24);
            labelNum.TabIndex = 59;
            labelNum.Text = "Número:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.ForeColor = Color.FromArgb(239, 230, 220);
            labelAddress.Location = new Point(67, 146);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(97, 24);
            labelAddress.TabIndex = 58;
            labelAddress.Text = "Dirección:";
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
            roundedTextBoxAddress.Location = new Point(279, 140);
            roundedTextBoxAddress.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxAddress.Multiline = false;
            roundedTextBoxAddress.Name = "roundedTextBoxAddress";
            roundedTextBoxAddress.Padding = new Padding(8);
            roundedTextBoxAddress.PasswordChar = false;
            roundedTextBoxAddress.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxAddress.PlaceholderText = "";
            roundedTextBoxAddress.Size = new Size(485, 37);
            roundedTextBoxAddress.TabIndex = 66;
            roundedTextBoxAddress.Texts = "";
            roundedTextBoxAddress.UnderlinedStyle = false;
            // 
            // roundedTextBoxNum
            // 
            roundedTextBoxNum.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxNum.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxNum.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxNum.BorderRadius = 10;
            roundedTextBoxNum.BorderSize = 2;
            roundedTextBoxNum.Font = new Font("Barlow Medium", 12F);
            roundedTextBoxNum.ForeColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxNum.Location = new Point(279, 188);
            roundedTextBoxNum.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxNum.Multiline = false;
            roundedTextBoxNum.Name = "roundedTextBoxNum";
            roundedTextBoxNum.Padding = new Padding(8);
            roundedTextBoxNum.PasswordChar = false;
            roundedTextBoxNum.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxNum.PlaceholderText = "";
            roundedTextBoxNum.Size = new Size(485, 37);
            roundedTextBoxNum.TabIndex = 65;
            roundedTextBoxNum.Texts = "";
            roundedTextBoxNum.UnderlinedStyle = false;
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
            roundedTextBoxPostalCode.Location = new Point(279, 235);
            roundedTextBoxPostalCode.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxPostalCode.Multiline = false;
            roundedTextBoxPostalCode.Name = "roundedTextBoxPostalCode";
            roundedTextBoxPostalCode.Padding = new Padding(8);
            roundedTextBoxPostalCode.PasswordChar = false;
            roundedTextBoxPostalCode.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxPostalCode.PlaceholderText = "";
            roundedTextBoxPostalCode.Size = new Size(485, 37);
            roundedTextBoxPostalCode.TabIndex = 67;
            roundedTextBoxPostalCode.Texts = "";
            roundedTextBoxPostalCode.UnderlinedStyle = false;
            // 
            // FormNewRestaurant2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(915, 415);
            Controls.Add(roundedTextBoxPostalCode);
            Controls.Add(roundedTextBoxAddress);
            Controls.Add(roundedTextBoxNum);
            Controls.Add(labelPostalCode);
            Controls.Add(labelNum);
            Controls.Add(labelAddress);
            Controls.Add(roundedButtonCreate);
            Controls.Add(roundedButtonCancel);
            Controls.Add(labelNewRestaurant);
            Name = "FormNewRestaurant2";
            Text = "NewRestaurant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMusicians;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelNewRestaurant;
        private TextBox textBox1;
        private TextBox textBoxAddress;
        private TextBox textBoxNumber;
        private TextBox textBoxPostCode;
        private Controls.RoundedButton roundedButtonCancel;
        private Controls.RoundedButton roundedButtonCreate;
        private Controls.RoundedTextBox roundedTextBoxConfPassword;
        private Controls.RoundedTextBox roundedTextBoxPassword;
        private Label labelPostalCode;
        private Label labelNum;
        private Label labelAddress;
        private Controls.RoundedTextBox roundedTextBoxAddress;
        private Controls.RoundedTextBox roundedTextBoxNum;
        private Controls.RoundedTextBox roundedTextBoxPostalCode;
    }
}