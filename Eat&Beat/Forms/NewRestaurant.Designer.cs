namespace Eat_Beat.Forms
{
    partial class NewRestaurant
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            roundedButtonOpen = new Controls.RoundedButton();
            roundedButton1 = new Controls.RoundedButton();
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(32, 32, 31);
            textBox1.Location = new Point(301, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(483, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(32, 32, 31);
            textBox2.Location = new Point(301, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(483, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(32, 32, 31);
            textBox3.Location = new Point(301, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(483, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(32, 32, 31);
            textBox4.Location = new Point(301, 244);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(483, 23);
            textBox4.TabIndex = 11;
            // 
            // roundedButtonOpen
            // 
            roundedButtonOpen.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonOpen.FlatAppearance.BorderSize = 0;
            roundedButtonOpen.FlatStyle = FlatStyle.Flat;
            roundedButtonOpen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonOpen.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonOpen.Location = new Point(648, 358);
            roundedButtonOpen.Name = "roundedButtonOpen";
            roundedButtonOpen.Size = new Size(115, 45);
            roundedButtonOpen.TabIndex = 12;
            roundedButtonOpen.Text = "Cancelar";
            roundedButtonOpen.UseVisualStyleBackColor = false;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(252, 158, 79);
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButton1.Location = new Point(769, 358);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(115, 45);
            roundedButton1.TabIndex = 13;
            roundedButton1.Text = "Continuar";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // NewRestaurant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(915, 415);
            Controls.Add(roundedButton1);
            Controls.Add(roundedButtonOpen);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelRestaurants);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelMusicians);
            Name = "NewRestaurant";
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
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Controls.RoundedButton roundedButtonOpen;
        private Controls.RoundedButton roundedButton1;
    }
}