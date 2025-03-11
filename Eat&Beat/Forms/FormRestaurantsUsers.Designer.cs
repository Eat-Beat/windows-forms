namespace Eat_Beat.Forms
{
    partial class FormRestaurantsUsers
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
            dataGridViewUsers = new DataGridView();
            labelRestaurants = new Label();
            labelMusicians = new Label();
            roundedButtonOpen = new Controls.RoundedButton();
            roundedButtonCreate = new Controls.RoundedButton();
            roundedButtonDelete = new Controls.RoundedButton();
            roundedButtonEdit = new Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = Color.FromArgb(32, 32, 31);
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.GridColor = Color.FromArgb(239, 230, 220);
            dataGridViewUsers.Location = new Point(2, 63);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.Size = new Size(1145, 465);
            dataGridViewUsers.TabIndex = 0;
            // 
            // labelRestaurants
            // 
            labelRestaurants.AutoSize = true;
            labelRestaurants.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRestaurants.ForeColor = Color.FromArgb(239, 230, 220);
            labelRestaurants.Location = new Point(12, 21);
            labelRestaurants.Name = "labelRestaurants";
            labelRestaurants.Size = new Size(131, 24);
            labelRestaurants.TabIndex = 1;
            labelRestaurants.Text = "Restaurantes";
            // 
            // labelMusicians
            // 
            labelMusicians.AutoSize = true;
            labelMusicians.Font = new Font("Barlow Medium", 14.25F);
            labelMusicians.ForeColor = Color.FromArgb(239, 230, 220);
            labelMusicians.Location = new Point(206, 21);
            labelMusicians.Name = "labelMusicians";
            labelMusicians.Size = new Size(77, 24);
            labelMusicians.TabIndex = 2;
            labelMusicians.Text = "Músicos";
            labelMusicians.Click += labelMusicians_Click;
            // 
            // roundedButtonOpen
            // 
            roundedButtonOpen.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonOpen.FlatAppearance.BorderSize = 0;
            roundedButtonOpen.FlatStyle = FlatStyle.Flat;
            roundedButtonOpen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonOpen.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonOpen.Location = new Point(655, 12);
            roundedButtonOpen.Name = "roundedButtonOpen";
            roundedButtonOpen.Size = new Size(115, 45);
            roundedButtonOpen.TabIndex = 4;
            roundedButtonOpen.Text = "Abrir";
            roundedButtonOpen.UseVisualStyleBackColor = false;
            roundedButtonOpen.Click += roundedButtonOpen_Click;
            // 
            // roundedButtonCreate
            // 
            roundedButtonCreate.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonCreate.FlatAppearance.BorderSize = 0;
            roundedButtonCreate.FlatStyle = FlatStyle.Flat;
            roundedButtonCreate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonCreate.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonCreate.Location = new Point(892, 12);
            roundedButtonCreate.Name = "roundedButtonCreate";
            roundedButtonCreate.Size = new Size(115, 45);
            roundedButtonCreate.TabIndex = 5;
            roundedButtonCreate.Text = "Crear";
            roundedButtonCreate.UseVisualStyleBackColor = false;
            roundedButtonCreate.Click += roundedButtonCreate_Click;
            // 
            // roundedButtonDelete
            // 
            roundedButtonDelete.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonDelete.FlatAppearance.BorderSize = 0;
            roundedButtonDelete.FlatStyle = FlatStyle.Flat;
            roundedButtonDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonDelete.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonDelete.Location = new Point(1021, 12);
            roundedButtonDelete.Name = "roundedButtonDelete";
            roundedButtonDelete.Size = new Size(115, 45);
            roundedButtonDelete.TabIndex = 7;
            roundedButtonDelete.Text = "Eliminar";
            roundedButtonDelete.UseVisualStyleBackColor = false;
            // 
            // roundedButtonEdit
            // 
            roundedButtonEdit.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonEdit.FlatAppearance.BorderSize = 0;
            roundedButtonEdit.FlatStyle = FlatStyle.Flat;
            roundedButtonEdit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonEdit.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonEdit.Location = new Point(773, 12);
            roundedButtonEdit.Name = "roundedButtonEdit";
            roundedButtonEdit.Size = new Size(115, 45);
            roundedButtonEdit.TabIndex = 6;
            roundedButtonEdit.Text = "Modificar";
            roundedButtonEdit.UseVisualStyleBackColor = false;
            roundedButtonEdit.Click += roundedButtonEdit_Click;
            // 
            // FormRestaurantsUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(1148, 529);
            Controls.Add(roundedButtonDelete);
            Controls.Add(roundedButtonEdit);
            Controls.Add(roundedButtonCreate);
            Controls.Add(roundedButtonOpen);
            Controls.Add(labelMusicians);
            Controls.Add(labelRestaurants);
            Controls.Add(dataGridViewUsers);
            Name = "FormRestaurantsUsers";
            Text = "FormRestaurantsUsers";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Label labelRestaurants;
        private Label labelMusicians;
        private Controls.RoundedButton roundedButtonOpen;
        private Controls.RoundedButton roundedButtonCreate;
        private Controls.RoundedButton roundedButtonDelete;
        private Controls.RoundedButton roundedButtonEdit;
    }
}