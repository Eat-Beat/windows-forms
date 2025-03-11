namespace Eat_Beat.Forms
{
    partial class FormOpenMusician
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpenMusician));
            roundedButtonBack = new Eat_Beat.Controls.RoundedButton();
            pictureBoxMainProfile = new PictureBox();
            labelMusicianName = new Label();
            richTextBoxDescription = new RichTextBox();
            roundedButtonOpenCalendar = new Eat_Beat.Controls.RoundedButton();
            flowLayoutPanelImages = new FlowLayoutPanel();
            webView2MapBox = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView2MapBox).BeginInit();
            SuspendLayout();
            // 
            // roundedButtonBack
            // 
            roundedButtonBack.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonBack.FlatAppearance.BorderSize = 0;
            roundedButtonBack.FlatStyle = FlatStyle.Flat;
            roundedButtonBack.Font = new Font("Barlow Medium", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonBack.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonBack.Location = new Point(1021, 483);
            roundedButtonBack.Name = "roundedButtonBack";
            roundedButtonBack.Size = new Size(115, 45);
            roundedButtonBack.TabIndex = 4;
            roundedButtonBack.Text = "Atras";
            roundedButtonBack.UseVisualStyleBackColor = false;
            roundedButtonBack.Click += roundedButtonBack_Click;
            // 
            // pictureBoxMainProfile
            // 
            pictureBoxMainProfile.Location = new Point(12, 23);
            pictureBoxMainProfile.Name = "pictureBoxMainProfile";
            pictureBoxMainProfile.Size = new Size(200, 200);
            pictureBoxMainProfile.TabIndex = 5;
            pictureBoxMainProfile.TabStop = false;
            // 
            // labelMusicianName
            // 
            labelMusicianName.AutoSize = true;
            labelMusicianName.Font = new Font("Barlow Medium", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMusicianName.ForeColor = Color.FromArgb(239, 230, 220);

            labelMusicianName.Location = new Point(232, 15);

            labelMusicianName.Name = "labelMusicianName";
            labelMusicianName.Size = new Size(247, 40);
            labelMusicianName.TabIndex = 19;
            labelMusicianName.Text = "Nombre Musico";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.BackColor = Color.FromArgb(32, 32, 31);
            richTextBoxDescription.BorderStyle = BorderStyle.None;
            richTextBoxDescription.Font = new Font("Barlow Medium", 9F);
            richTextBoxDescription.ForeColor = Color.FromArgb(239, 230, 220);
            richTextBoxDescription.Location = new Point(232, 109);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(485, 114);
            richTextBoxDescription.TabIndex = 22;
            richTextBoxDescription.Text = resources.GetString("richTextBoxDescription.Text");
            // 
            // roundedButtonOpenCalendar
            // 
            roundedButtonOpenCalendar.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonOpenCalendar.FlatAppearance.BorderSize = 0;
            roundedButtonOpenCalendar.FlatStyle = FlatStyle.Flat;
            roundedButtonOpenCalendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonOpenCalendar.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonOpenCalendar.Location = new Point(723, 483);
            roundedButtonOpenCalendar.Name = "roundedButtonOpenCalendar";
            roundedButtonOpenCalendar.Size = new Size(143, 45);
            roundedButtonOpenCalendar.TabIndex = 23;
            roundedButtonOpenCalendar.Text = "Abrir Calendario";
            roundedButtonOpenCalendar.UseVisualStyleBackColor = false;
            roundedButtonOpenCalendar.Click += roundedButtonOpenCalendar_Click;
            // 
            // flowLayoutPanelImages
            // 
            flowLayoutPanelImages.AutoScroll = true;
            flowLayoutPanelImages.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelImages.Location = new Point(12, 238);
            flowLayoutPanelImages.Margin = new Padding(0);
            flowLayoutPanelImages.Name = "flowLayoutPanelImages";
            flowLayoutPanelImages.Size = new Size(299, 290);
            flowLayoutPanelImages.TabIndex = 32;
            // 
            // webView2MapBox
            // 
            webView2MapBox.AllowExternalDrop = true;
            webView2MapBox.CreationProperties = null;
            webView2MapBox.DefaultBackgroundColor = Color.White;
            webView2MapBox.Location = new Point(723, 90);
            webView2MapBox.Name = "webView2MapBox";
            webView2MapBox.Size = new Size(413, 378);
            webView2MapBox.TabIndex = 33;
            webView2MapBox.ZoomFactor = 1D;
            // 
            // FormOpenMusician
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(1148, 529);
            Controls.Add(webView2MapBox);
            Controls.Add(flowLayoutPanelImages);
            Controls.Add(roundedButtonOpenCalendar);
            Controls.Add(richTextBoxDescription);
            Controls.Add(labelMusicianName);
            Controls.Add(pictureBoxMainProfile);
            Controls.Add(roundedButtonBack);
            Name = "FormOpenMusician";
            Text = "FormRestaurantsUsers";
            Load += FormOpenMusician_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView2MapBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Controls.RoundedButton roundedButtonBack;
        private PictureBox pictureBoxMainProfile;
        private Label labelMusicianName;
        private RichTextBox richTextBoxDescription;
        private Controls.RoundedButton roundedButtonOpenCalendar;
        private FlowLayoutPanel flowLayoutPanelImages;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2MapBox;
    }
}