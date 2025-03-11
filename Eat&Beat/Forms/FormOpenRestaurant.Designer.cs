namespace Eat_Beat.Forms
{
    partial class FormOpenRestaurant
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
            labelRestaurantName = new Label();
            pictureBoxMainProfile = new PictureBox();
            labelAddress = new Label();
            webView2MapBox = new Microsoft.Web.WebView2.WinForms.WebView2();
            roundedButtonOpenCalendar = new Eat_Beat.Controls.RoundedButton();
            roundedButtonBack = new Eat_Beat.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView2MapBox).BeginInit();
            SuspendLayout();
            // 
            // labelRestaurantName
            // 
            labelRestaurantName.AutoSize = true;
            labelRestaurantName.Font = new Font("Barlow Medium", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRestaurantName.ForeColor = Color.FromArgb(239, 230, 220);
            labelRestaurantName.Location = new Point(277, 18);
            labelRestaurantName.Name = "labelRestaurantName";
            labelRestaurantName.Size = new Size(327, 40);
            labelRestaurantName.TabIndex = 21;
            labelRestaurantName.Text = "Nombre Restaurante";
            // 
            // pictureBoxMainProfile
            // 
            pictureBoxMainProfile.Location = new Point(22, 15);
            pictureBoxMainProfile.Name = "pictureBoxMainProfile";
            pictureBoxMainProfile.Size = new Size(247, 168);
            pictureBoxMainProfile.TabIndex = 20;
            pictureBoxMainProfile.TabStop = false;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Barlow Medium", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddress.ForeColor = Color.FromArgb(239, 230, 220);
            labelAddress.Location = new Point(277, 139);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(281, 33);
            labelAddress.TabIndex = 22;
            labelAddress.Text = "Nombre Restaurante";
            // 
            // webView2MapBox
            // 
            webView2MapBox.AllowExternalDrop = true;
            webView2MapBox.CreationProperties = null;
            webView2MapBox.DefaultBackgroundColor = Color.White;
            webView2MapBox.Location = new Point(22, 223);
            webView2MapBox.Name = "webView2MapBox";
            webView2MapBox.Size = new Size(1102, 294);
            webView2MapBox.TabIndex = 23;
            webView2MapBox.ZoomFactor = 1D;
            // 
            // roundedButtonOpenCalendar
            // 
            roundedButtonOpenCalendar.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonOpenCalendar.FlatAppearance.BorderSize = 0;
            roundedButtonOpenCalendar.FlatStyle = FlatStyle.Flat;
            roundedButtonOpenCalendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonOpenCalendar.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonOpenCalendar.Location = new Point(804, 12);
            roundedButtonOpenCalendar.Name = "roundedButtonOpenCalendar";
            roundedButtonOpenCalendar.Size = new Size(143, 45);
            roundedButtonOpenCalendar.TabIndex = 25;
            roundedButtonOpenCalendar.Text = "Abrir Calendario";
            roundedButtonOpenCalendar.UseVisualStyleBackColor = false;
            // 
            // roundedButtonBack
            // 
            roundedButtonBack.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonBack.FlatAppearance.BorderSize = 0;
            roundedButtonBack.FlatStyle = FlatStyle.Flat;
            roundedButtonBack.Font = new Font("Barlow Medium", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonBack.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonBack.Location = new Point(973, 13);
            roundedButtonBack.Name = "roundedButtonBack";
            roundedButtonBack.Size = new Size(115, 45);
            roundedButtonBack.TabIndex = 24;
            roundedButtonBack.Text = "Atras";
            roundedButtonBack.UseVisualStyleBackColor = false;
            roundedButtonBack.Click += roundedButtonBack_Click;
            // 
            // FormOpenRestaurant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(1148, 529);
            Controls.Add(roundedButtonOpenCalendar);
            Controls.Add(roundedButtonBack);
            Controls.Add(webView2MapBox);
            Controls.Add(labelAddress);
            Controls.Add(labelRestaurantName);
            Controls.Add(pictureBoxMainProfile);
            Name = "FormOpenRestaurant";
            Text = "OpenRestaurant";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView2MapBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRestaurantName;
        private PictureBox pictureBoxMainProfile;
        private Label labelAddress;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2MapBox;
        private Controls.RoundedButton roundedButtonOpenCalendar;
        private Controls.RoundedButton roundedButtonBack;
    }
}