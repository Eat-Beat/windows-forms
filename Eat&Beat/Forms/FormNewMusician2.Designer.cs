﻿namespace Eat_Beat.Forms
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
            labelLongitut = new Label();
            labelLatitut = new Label();
            labelRangeKm = new Label();
            roundedTextBoxLongitut = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBoxLatitut = new Eat_Beat.Controls.RoundedTextBox();
            roundedComboBoxKm = new Eat_Beat.Controls.RoundedComboBox();
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
            webView2MapBox.Size = new Size(1150, 362);
            webView2MapBox.TabIndex = 7;
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
            roundedButtonContinue.Click += roundedButtonContinue_Click;
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
            roundedButtonCancel.Click += roundedButtonCancel_Click;
            // 
            // labelLongitut
            // 
            labelLongitut.AutoSize = true;
            labelLongitut.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLongitut.ForeColor = Color.FromArgb(239, 230, 220);
            labelLongitut.Location = new Point(50, 32);
            labelLongitut.Name = "labelLongitut";
            labelLongitut.Size = new Size(91, 24);
            labelLongitut.TabIndex = 1;
            labelLongitut.Text = "Longitud:";
            // 
            // labelLatitut
            // 
            labelLatitut.AutoSize = true;
            labelLatitut.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLatitut.ForeColor = Color.FromArgb(239, 230, 220);
            labelLatitut.Location = new Point(470, 32);
            labelLatitut.Name = "labelLatitut";
            labelLatitut.Size = new Size(77, 24);
            labelLatitut.TabIndex = 3;
            labelLatitut.Text = "Latitud:";
            // 
            // labelRangeKm
            // 
            labelRangeKm.AutoSize = true;
            labelRangeKm.Font = new Font("Barlow Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRangeKm.ForeColor = Color.FromArgb(239, 230, 220);
            labelRangeKm.Location = new Point(873, 32);
            labelRangeKm.Name = "labelRangeKm";
            labelRangeKm.Size = new Size(99, 24);
            labelRangeKm.TabIndex = 5;
            labelRangeKm.Text = "Rango KM:";
            // 
            // roundedTextBoxLongitut
            // 
            roundedTextBoxLongitut.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxLongitut.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxLongitut.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxLongitut.BorderRadius = 10;
            roundedTextBoxLongitut.BorderSize = 2;
            roundedTextBoxLongitut.Font = new Font("Barlow Medium", 12F);
            roundedTextBoxLongitut.ForeColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxLongitut.Location = new Point(144, 27);
            roundedTextBoxLongitut.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxLongitut.Multiline = false;
            roundedTextBoxLongitut.Name = "roundedTextBoxLongitut";
            roundedTextBoxLongitut.Padding = new Padding(8);
            roundedTextBoxLongitut.PasswordChar = false;
            roundedTextBoxLongitut.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxLongitut.PlaceholderText = "";
            roundedTextBoxLongitut.Size = new Size(307, 37);
            roundedTextBoxLongitut.TabIndex = 2;
            roundedTextBoxLongitut.Texts = "";
            roundedTextBoxLongitut.UnderlinedStyle = false;
            // 
            // roundedTextBoxLatitut
            // 
            roundedTextBoxLatitut.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBoxLatitut.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxLatitut.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxLatitut.BorderRadius = 10;
            roundedTextBoxLatitut.BorderSize = 2;
            roundedTextBoxLatitut.Font = new Font("Barlow Medium", 12F);
            roundedTextBoxLatitut.ForeColor = Color.FromArgb(239, 230, 220);
            roundedTextBoxLatitut.Location = new Point(553, 27);
            roundedTextBoxLatitut.Margin = new Padding(3, 4, 3, 4);
            roundedTextBoxLatitut.Multiline = false;
            roundedTextBoxLatitut.Name = "roundedTextBoxLatitut";
            roundedTextBoxLatitut.Padding = new Padding(8);
            roundedTextBoxLatitut.PasswordChar = false;
            roundedTextBoxLatitut.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBoxLatitut.PlaceholderText = "";
            roundedTextBoxLatitut.Size = new Size(307, 37);
            roundedTextBoxLatitut.TabIndex = 4;
            roundedTextBoxLatitut.Texts = "";
            roundedTextBoxLatitut.UnderlinedStyle = false;
            // 
            // roundedComboBoxKm
            // 
            roundedComboBoxKm.BackColor = Color.FromArgb(32, 32, 31);
            roundedComboBoxKm.BorderColor = Color.FromArgb(239, 230, 220);
            roundedComboBoxKm.BorderSize = 2;
            roundedComboBoxKm.DropDownStyle = ComboBoxStyle.DropDown;
            roundedComboBoxKm.Font = new Font("Barlow Medium", 12F);
            roundedComboBoxKm.ForeColor = Color.FromArgb(239, 230, 220);
            roundedComboBoxKm.IconColor = Color.FromArgb(239, 230, 220);
            roundedComboBoxKm.Items.AddRange(new object[] { "5", "10", "20", "50", "100", "∞" });
            roundedComboBoxKm.ListBackColor = Color.FromArgb(64, 64, 62);
            roundedComboBoxKm.ListTextColor = Color.FromArgb(239, 230, 220);
            roundedComboBoxKm.Location = new Point(977, 27);
            roundedComboBoxKm.MinimumSize = new Size(100, 30);
            roundedComboBoxKm.Name = "roundedComboBoxKm";
            roundedComboBoxKm.Padding = new Padding(2);
            roundedComboBoxKm.Size = new Size(100, 37);
            roundedComboBoxKm.TabIndex = 6;
            roundedComboBoxKm.Texts = "";
            roundedComboBoxKm.OnSelectedIndexChanged += roundedComboBoxKm_OnSelectedIndexChanged;
            // 
            // FormNewMusician2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(1148, 529);
            Controls.Add(roundedComboBoxKm);
            Controls.Add(roundedTextBoxLatitut);
            Controls.Add(roundedTextBoxLongitut);
            Controls.Add(labelRangeKm);
            Controls.Add(labelLatitut);
            Controls.Add(labelLongitut);
            Controls.Add(roundedButtonContinue);
            Controls.Add(roundedButtonCancel);
            Controls.Add(webView2MapBox);
            Name = "FormNewMusician2";
            Text = "NewMusician2";
            ((System.ComponentModel.ISupportInitialize)webView2MapBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2MapBox;
        private Controls.RoundedButton roundedButtonContinue;
        private Controls.RoundedButton roundedButtonCancel;
        private Controls.RoundedTextBox roundedTextBox3;
        private Label labelLongitut;
        private Label labelLatitut;
        private Label labelRangeKm;
        private Controls.RoundedTextBox roundedTextBoxLongitut;
        private Controls.RoundedTextBox roundedTextBoxLatitut;
        private Controls.RoundedComboBox roundedComboBoxKm;
    }
}