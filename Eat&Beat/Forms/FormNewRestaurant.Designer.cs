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
            roundedButtonCancel = new Controls.RoundedButton();
            roundedButtonContinue = new Controls.RoundedButton();
            labelNewRestaurant = new Label();
            labelName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            roundedTextBox1 = new Controls.RoundedTextBox();
            SuspendLayout();
            // 
            // roundedButtonCancel
            // 
            roundedButtonCancel.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonCancel.FlatAppearance.BorderSize = 0;
            roundedButtonCancel.FlatStyle = FlatStyle.Flat;
            roundedButtonCancel.Font = new Font("Barlow Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonCancel.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonCancel.Location = new Point(552, 393);
            roundedButtonCancel.Name = "roundedButtonCancel";
            roundedButtonCancel.Size = new Size(115, 45);
            roundedButtonCancel.TabIndex = 9;
            roundedButtonCancel.Text = "Cancelar";
            roundedButtonCancel.UseVisualStyleBackColor = false;
            // 
            // roundedButtonContinue
            // 
            roundedButtonContinue.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonContinue.FlatAppearance.BorderSize = 0;
            roundedButtonContinue.FlatStyle = FlatStyle.Flat;
            roundedButtonContinue.Font = new Font("Barlow Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonContinue.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonContinue.Location = new Point(673, 393);
            roundedButtonContinue.Name = "roundedButtonContinue";
            roundedButtonContinue.Size = new Size(115, 45);
            roundedButtonContinue.TabIndex = 10;
            roundedButtonContinue.Text = "Continuar";
            roundedButtonContinue.UseVisualStyleBackColor = false;
            // 
            // labelNewRestaurant
            // 
            labelNewRestaurant.AutoSize = true;
            labelNewRestaurant.Font = new Font("Barlow Medium", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewRestaurant.ForeColor = Color.FromArgb(239, 230, 220);
            labelNewRestaurant.Location = new Point(252, 33);
            labelNewRestaurant.Name = "labelNewRestaurant";
            labelNewRestaurant.Size = new Size(332, 36);
            labelNewRestaurant.TabIndex = 11;
            labelNewRestaurant.Text = "NUEVO RESTAURANTE:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Barlow Medium", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.FromArgb(239, 230, 220);
            labelName.Location = new Point(55, 110);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 24);
            labelName.TabIndex = 12;
            labelName.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Barlow Medium", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 230, 220);
            label1.Location = new Point(55, 158);
            label1.Name = "label1";
            label1.Size = new Size(175, 24);
            label1.TabIndex = 13;
            label1.Text = "Correo electrónico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Barlow Medium", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(239, 230, 220);
            label2.Location = new Point(55, 211);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 14;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Barlow Medium", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(239, 230, 220);
            label3.Location = new Point(55, 263);
            label3.Name = "label3";
            label3.Size = new Size(200, 24);
            label3.TabIndex = 15;
            label3.Text = "Confirmar contraseña:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(332, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 16;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BackColor = Color.White;
            roundedTextBox1.BorderColor = Color.FromArgb(255, 255, 255);
            roundedTextBox1.BorderSize = 2;
            roundedTextBox1.Font = new Font("Barlow Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox1.ForeColor = Color.FromArgb(239, 230, 220);
            roundedTextBox1.Location = new Point(332, 110);
            roundedTextBox1.Margin = new Padding(4);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Padding = new Padding(7);
            roundedTextBox1.Size = new Size(300, 35);
            roundedTextBox1.TabIndex = 17;
            roundedTextBox1.UnderlineedStyle = false;
            // 
            // FormNewRestaurant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(800, 450);
            Controls.Add(roundedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelName);
            Controls.Add(labelNewRestaurant);
            Controls.Add(roundedButtonContinue);
            Controls.Add(roundedButtonCancel);
            Name = "FormNewRestaurant";
            Text = "FormNewRestaurant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.RoundedButton roundedButtonCancel;
        private Controls.RoundedButton roundedButtonContinue;
        private Label labelNewRestaurant;
        private Label labelName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Controls.RoundedTextBox roundedTextBox1;
    }
}