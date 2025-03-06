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
            roundedTextBox2 = new Eat_Beat.Controls.RoundedTextBox();
            roundedTextBox1 = new Eat_Beat.Controls.RoundedTextBox();
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
            // roundedTextBox2
            // 
            roundedTextBox2.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBox2.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBox2.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBox2.BorderRadius = 10;
            roundedTextBox2.BorderSize = 2;
            roundedTextBox2.Location = new Point(13, 26);
            roundedTextBox2.Margin = new Padding(4);
            roundedTextBox2.Multiline = false;
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.Padding = new Padding(7, 10, 7, 10);
            roundedTextBox2.PasswordChar = false;
            roundedTextBox2.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBox2.PlaceholderText = "";
            roundedTextBox2.Size = new Size(318, 36);
            roundedTextBox2.TabIndex = 11;
            roundedTextBox2.Texts = "";
            roundedTextBox2.UnderlinedStyle = false;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BackColor = Color.FromArgb(32, 32, 31);
            roundedTextBox1.BorderColor = Color.FromArgb(239, 230, 220);
            roundedTextBox1.BorderFocusColor = Color.FromArgb(252, 158, 79);
            roundedTextBox1.BorderRadius = 18;
            roundedTextBox1.BorderSize = 2;
            roundedTextBox1.Location = new Point(339, 26);
            roundedTextBox1.Margin = new Padding(4);
            roundedTextBox1.Multiline = false;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Padding = new Padding(7, 10, 7, 10);
            roundedTextBox1.PasswordChar = false;
            roundedTextBox1.PlaceholderColor = Color.FromArgb(252, 158, 79);
            roundedTextBox1.PlaceholderText = "";
            roundedTextBox1.Size = new Size(250, 36);
            roundedTextBox1.TabIndex = 12;
            roundedTextBox1.Texts = "";
            roundedTextBox1.UnderlinedStyle = false;
            // 
            // FormNewMusician2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(1148, 529);
            Controls.Add(roundedTextBox1);
            Controls.Add(roundedTextBox2);
            Controls.Add(roundedButtonContinue);
            Controls.Add(roundedButtonCancel);
            Controls.Add(webView2MapBox);
            Name = "FormNewMusician2";
            Text = "FormNewMusician2";
            ((System.ComponentModel.ISupportInitialize)webView2MapBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2MapBox;
        private Controls.RoundedButton roundedButtonContinue;
        private Controls.RoundedButton roundedButtonCancel;
        private Controls.RoundedTextBox roundedTextBox2;
        private Controls.RoundedTextBox roundedTextBox1;
    }
}