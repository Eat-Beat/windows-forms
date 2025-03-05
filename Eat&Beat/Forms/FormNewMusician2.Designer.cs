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
            // FormNewMusician2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(1148, 529);
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
    }
}