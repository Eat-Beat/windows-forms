namespace Eat_Beat.Forms
{
    partial class ucDay
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBoxTasksInDay = new PictureBox();
            checkBox1 = new CheckBox();
            labelDay = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTasksInDay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBoxTasksInDay);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(labelDay);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 82);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // pictureBoxTasksInDay
            // 
            pictureBoxTasksInDay.Image = Properties.Resources.png_orange_circle2;
            pictureBoxTasksInDay.Location = new Point(46, 43);
            pictureBoxTasksInDay.Name = "pictureBoxTasksInDay";
            pictureBoxTasksInDay.Size = new Size(10, 10);
            pictureBoxTasksInDay.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTasksInDay.TabIndex = 3;
            pictureBoxTasksInDay.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 7);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 2;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Font = new Font("Barlow Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDay.ForeColor = Color.Black;
            labelDay.Location = new Point(77, 7);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(23, 15);
            labelDay.TabIndex = 1;
            labelDay.Text = "00";
            // 
            // ucDay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 230, 220);
            Controls.Add(panel1);
            Name = "ucDay";
            Padding = new Padding(1);
            Size = new Size(105, 84);
            Load += ucDay_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTasksInDay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelDay;
        private CheckBox checkBox1;
        private PictureBox pictureBoxTasksInDay;
    }
}
