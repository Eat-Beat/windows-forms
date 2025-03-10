namespace Eat_Beat.Forms
{
    partial class FormNewMusician2
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
            webView2MapBox = new Microsoft.Web.WebView2.WinForms.WebView2();
            roundedButtonContinue = new Eat_Beat.Controls.RoundedButton();
            roundedButtonCancel = new Eat_Beat.Controls.RoundedButton();
            roundedTextBoxLongitut = new Eat_Beat.Controls.RoundedTextBox();
            labelLongitut = new Label();
            labelLatitut = new Label();
            roundedTextBoxLatitut = new Eat_Beat.Controls.RoundedTextBox();
            labelRangeKm = new Label();
            roundedTextBoxRangeKm = new Eat_Beat.Controls.RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)webView2MapBox).BeginInit();
            SuspendLayout();
            // 
            // webView2MapBox
            // 
            webView2MapBox.AllowExternalDrop = true;
            webView2MapBox.CreationProperties = null;
            webView2MapBox.DefaultBackgroundColor = Color.White;
            webView2MapBox.Location = new Point(0, 83);
            webView2MapBox.Name = "webView2MapBox";
            webView2MapBox.Size = new Size(1154, 362);
            webView2MapBox.TabIndex = 0;
            webView2MapBox.ZoomFactor = 1D;
            // 
            // roundedButtonContinue
            // 
            roundedButtonContinue.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonContinue.FlatAppearance.BorderSize = 0;
            roundedButtonContinue.FlatStyle = FlatStyle.Flat;
            roundedButtonContinue.Font = new Font("Barlow Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonContinue.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonContinue.Location = new Point(1010, 464);
            roundedButtonContinue.Name = "roundedButtonContinue";
            roundedButtonContinue.Size = new Size(115, 45);
            roundedButtonContinue.TabIndex = 9;
            roundedButtonContinue.Text = "Continuar";
            roundedButtonContinue.UseVisualStyleBackColor = false;
            // 
            // roundedButtonCancel
            // 
            roundedButtonCancel.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonCancel.FlatAppearance.BorderSize = 0;
            roundedButtonCancel.FlatStyle = FlatStyle.Flat;
            roundedButtonCancel.Font = new Font("Barlow Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonCancel.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonCancel.Location = new Point(877, 464);
            roundedButtonCancel.Name = "roundedButtonCancel";
            roundedButtonCancel.Size = new Size(115, 45);
            roundedButtonCancel.TabIndex = 8;
            roundedButtonCancel.Text = "Cancelar";
            roundedButtonCancel.UseVisualStyleBackColor = false;
            // 
            // roundedTextBoxLongitut
            // 
            roundedTextBoxLongitut.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxLongitut.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxLongitut.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxLongitut.BorderRadius = 10;
            roundedTextBoxLongitut.BorderSize = 2;
            roundedTextBoxLongitut.Location = new Point(117, 27);
            roundedTextBoxLongitut.Margin = new Padding(4);
            roundedTextBoxLongitut.Multiline = false;
            roundedTextBoxLongitut.Name = "roundedTextBoxLongitut";
            roundedTextBoxLongitut.Padding = new Padding(7, 10, 7, 10);
            roundedTextBoxLongitut.PasswordChar = false;
            roundedTextBoxLongitut.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxLongitut.PlaceholderText = "";
            roundedTextBoxLongitut.Size = new Size(279, 36);
            roundedTextBoxLongitut.TabIndex = 12;
            roundedTextBoxLongitut.Texts = "";
            roundedTextBoxLongitut.UnderlinedStyle = false;
            // 
            // labelLongitut
            // 
            labelLongitut.AutoSize = true;
            labelLongitut.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLongitut.ForeColor = Color.FromArgb(239, 230, 220);
            labelLongitut.Location = new Point(22, 32);
            labelLongitut.Name = "labelLongitut";
            labelLongitut.Size = new Size(91, 24);
            labelLongitut.TabIndex = 51;
            labelLongitut.Text = "Longitud:";
            // 
            // labelLatitut
            // 
            labelLatitut.AutoSize = true;
            labelLatitut.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLatitut.ForeColor = Color.FromArgb(239, 230, 220);
            labelLatitut.Location = new Point(442, 32);
            labelLatitut.Name = "labelLatitut";
            labelLatitut.Size = new Size(77, 24);
            labelLatitut.TabIndex = 53;
            labelLatitut.Text = "Latitud:";
            // 
            // roundedTextBoxLatitut
            // 
            roundedTextBoxLatitut.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxLatitut.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxLatitut.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxLatitut.BorderRadius = 10;
            roundedTextBoxLatitut.BorderSize = 2;
            roundedTextBoxLatitut.Location = new Point(526, 27);
            roundedTextBoxLatitut.Margin = new Padding(4);
            roundedTextBoxLatitut.Multiline = false;
            roundedTextBoxLatitut.Name = "roundedTextBoxLatitut";
            roundedTextBoxLatitut.Padding = new Padding(7, 10, 7, 10);
            roundedTextBoxLatitut.PasswordChar = false;
            roundedTextBoxLatitut.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxLatitut.PlaceholderText = "";
            roundedTextBoxLatitut.Size = new Size(279, 36);
            roundedTextBoxLatitut.TabIndex = 52;
            roundedTextBoxLatitut.Texts = "";
            roundedTextBoxLatitut.UnderlinedStyle = false;
            // 
            // labelRangeKm
            // 
            labelRangeKm.AutoSize = true;
            labelRangeKm.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRangeKm.ForeColor = Color.FromArgb(239, 230, 220);
            labelRangeKm.Location = new Point(845, 32);
            labelRangeKm.Name = "labelRangeKm";
            labelRangeKm.Size = new Size(99, 24);
            labelRangeKm.TabIndex = 55;
            labelRangeKm.Text = "Rango KM:";
            // 
            // roundedTextBoxRangeKm
            // 
            roundedTextBoxRangeKm.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxRangeKm.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxRangeKm.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxRangeKm.BorderRadius = 10;
            roundedTextBoxRangeKm.BorderSize = 2;
            roundedTextBoxRangeKm.Location = new Point(951, 27);
            roundedTextBoxRangeKm.Margin = new Padding(4);
            roundedTextBoxRangeKm.Multiline = false;
            roundedTextBoxRangeKm.Name = "roundedTextBoxRangeKm";
            roundedTextBoxRangeKm.Padding = new Padding(7, 10, 7, 10);
            roundedTextBoxRangeKm.PasswordChar = false;
            roundedTextBoxRangeKm.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxRangeKm.PlaceholderText = "";
            roundedTextBoxRangeKm.Size = new Size(114, 36);
            roundedTextBoxRangeKm.TabIndex = 54;
            roundedTextBoxRangeKm.Texts = "";
            roundedTextBoxRangeKm.UnderlinedStyle = false;
            // 
            // FormNewMusician2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(1148, 529);
            Controls.Add(labelRangeKm);
            Controls.Add(roundedTextBoxRangeKm);
            Controls.Add(labelLatitut);
            Controls.Add(roundedTextBoxLatitut);
            Controls.Add(labelLongitut);
            Controls.Add(roundedTextBoxLongitut);
            Controls.Add(roundedButtonContinue);
            Controls.Add(roundedButtonCancel);
            Controls.Add(webView2MapBox);
            Name = "FormNewMusician2";
            Text = "FormNewMusician2";
            ((System.ComponentModel.ISupportInitialize)webView2MapBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2MapBox;
        private Controls.RoundedButton roundedButtonContinue;
        private Controls.RoundedButton roundedButtonCancel;
        private Controls.RoundedTextBox roundedTextBox2;
        private Controls.RoundedTextBox roundedTextBoxLongitut;
        private Controls.RoundedTextBox roundedTextBox3;
        private Label labelLongitut;
        private Label labelLatitut;
        private Controls.RoundedTextBox roundedTextBoxLatitut;
        private Label labelRangeKm;
        private Controls.RoundedTextBox roundedTextBoxRangeKm;
    }
}