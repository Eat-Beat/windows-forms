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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelRestaurants = new Label();
            textBoxAddress = new TextBox();
            textBoxNumber = new TextBox();
            textBoxPostCode = new TextBox();
            roundedButtonCancel = new Controls.RoundedButton();
            roundedButtonCreate = new Controls.RoundedButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 230, 220);
            label1.Location = new Point(88, 151);
            label1.Name = "label1";
            label1.Size = new Size(95, 24);
            label1.TabIndex = 4;
            label1.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(239, 230, 220);
            label2.Location = new Point(88, 196);
            label2.Name = "label2";
            label2.Size = new Size(84, 24);
            label2.TabIndex = 5;
            label2.Text = "Numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(239, 230, 220);
            label3.Location = new Point(88, 243);
            label3.Name = "label3";
            label3.Size = new Size(131, 24);
            label3.TabIndex = 6;
            label3.Text = "Codigo Postal:";
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
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.FromArgb(32, 32, 31);
            textBoxAddress.Location = new Point(234, 152);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(550, 23);
            textBoxAddress.TabIndex = 9;
            // 
            // textBoxNumber
            // 
            textBoxNumber.BackColor = Color.FromArgb(32, 32, 31);
            textBoxNumber.Location = new Point(234, 197);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(550, 23);
            textBoxNumber.TabIndex = 10;
            // 
            // textBoxPostCode
            // 
            textBoxPostCode.BackColor = Color.FromArgb(32, 32, 31);
            textBoxPostCode.Location = new Point(234, 244);
            textBoxPostCode.Name = "textBoxPostCode";
            textBoxPostCode.Size = new Size(550, 23);
            textBoxPostCode.TabIndex = 11;
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
            // 
            // FormNewRestaurant2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(915, 415);
            Controls.Add(roundedButtonCreate);
            Controls.Add(roundedButtonCancel);
            Controls.Add(textBoxPostCode);
            Controls.Add(textBoxNumber);
            Controls.Add(textBoxAddress);
            Controls.Add(labelRestaurants);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label labelRestaurants;
        private TextBox textBox1;
        private TextBox textBoxAddress;
        private TextBox textBoxNumber;
        private TextBox textBoxPostCode;
        private Controls.RoundedButton roundedButtonCancel;
        private Controls.RoundedButton roundedButtonCreate;
    }
}