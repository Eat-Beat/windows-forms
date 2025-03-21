﻿namespace Eat_Beat.Forms
{
    partial class FormAdminUsers
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            roundedButtonDelete = new Eat_Beat.Controls.RoundedButton();
            roundedButtonCreate = new Eat_Beat.Controls.RoundedButton();
            roundedButtonEdit = new Eat_Beat.Controls.RoundedButton();
            roundedButtonOpen = new Eat_Beat.Controls.RoundedButton();
            dataGridViewUsers = new DataGridView();
            labelRestaurants = new Label();
            labelMusicians = new Label();
            labelAdmins = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // roundedButtonDelete
            // 
            roundedButtonDelete.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonDelete.FlatAppearance.BorderSize = 0;
            roundedButtonDelete.FlatStyle = FlatStyle.Flat;
            roundedButtonDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonDelete.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonDelete.Location = new Point(1021, 16);
            roundedButtonDelete.Name = "roundedButtonDelete";
            roundedButtonDelete.Size = new Size(115, 45);
            roundedButtonDelete.TabIndex = 14;
            roundedButtonDelete.Text = "Eliminar";
            roundedButtonDelete.UseVisualStyleBackColor = false;
            // 
            // roundedButtonCreate
            // 
            roundedButtonCreate.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonCreate.FlatAppearance.BorderSize = 0;
            roundedButtonCreate.FlatStyle = FlatStyle.Flat;
            roundedButtonCreate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonCreate.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonCreate.Location = new Point(903, 16);
            roundedButtonCreate.Name = "roundedButtonCreate";
            roundedButtonCreate.Size = new Size(115, 45);
            roundedButtonCreate.TabIndex = 13;
            roundedButtonCreate.Text = "Crear";
            roundedButtonCreate.UseVisualStyleBackColor = false;
            // 
            // roundedButtonEdit
            // 
            roundedButtonEdit.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonEdit.FlatAppearance.BorderSize = 0;
            roundedButtonEdit.FlatStyle = FlatStyle.Flat;
            roundedButtonEdit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonEdit.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonEdit.Location = new Point(784, 16);
            roundedButtonEdit.Name = "roundedButtonEdit";
            roundedButtonEdit.Size = new Size(115, 45);
            roundedButtonEdit.TabIndex = 12;
            roundedButtonEdit.Text = "Modificar";
            roundedButtonEdit.UseVisualStyleBackColor = false;
            // 
            // roundedButtonOpen
            // 
            roundedButtonOpen.BackColor = Color.FromArgb(252, 158, 79);
            roundedButtonOpen.FlatAppearance.BorderSize = 0;
            roundedButtonOpen.FlatStyle = FlatStyle.Flat;
            roundedButtonOpen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonOpen.ForeColor = Color.FromArgb(32, 32, 31);
            roundedButtonOpen.Location = new Point(665, 16);
            roundedButtonOpen.Name = "roundedButtonOpen";
            roundedButtonOpen.Size = new Size(115, 45);
            roundedButtonOpen.TabIndex = 11;
            roundedButtonOpen.Text = "Abrir";
            roundedButtonOpen.UseVisualStyleBackColor = false;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.FromArgb(32, 32, 31);
            dataGridViewUsers.BorderStyle = BorderStyle.None;
            dataGridViewUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(252, 158, 79);
            dataGridViewCellStyle3.Font = new Font("Barlow Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(32, 32, 31);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(252, 158, 79);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(32, 32, 31);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(32, 32, 31);
            dataGridViewCellStyle4.Font = new Font("Barlow Medium", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(239, 230, 220);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(239, 230, 220);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(32, 32, 31);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewUsers.EnableHeadersVisualStyles = false;
            dataGridViewUsers.GridColor = Color.FromArgb(239, 230, 220);
            dataGridViewUsers.Location = new Point(2, 76);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(1145, 452);
            dataGridViewUsers.TabIndex = 10;
            // 
            // labelRestaurants
            // 
            labelRestaurants.AutoSize = true;
            labelRestaurants.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRestaurants.ForeColor = Color.FromArgb(239, 230, 220);
            labelRestaurants.Location = new Point(12, 27);
            labelRestaurants.Name = "labelRestaurants";
            labelRestaurants.Size = new Size(119, 24);
            labelRestaurants.TabIndex = 15;
            labelRestaurants.Text = "Restaurantes";
            labelRestaurants.Click += labelRestaurants_Click;
            // 
            // labelMusicians
            // 
            labelMusicians.AutoSize = true;
            labelMusicians.Font = new Font("Barlow Medium", 14.25F);
            labelMusicians.ForeColor = Color.FromArgb(239, 230, 220);
            labelMusicians.Location = new Point(206, 27);
            labelMusicians.Name = "labelMusicians";
            labelMusicians.Size = new Size(77, 24);
            labelMusicians.TabIndex = 16;
            labelMusicians.Text = "Músicos";
            labelMusicians.Click += labelMusicians_Click;
            // 
            // labelAdmins
            // 
            labelAdmins.AutoSize = true;
            labelAdmins.Font = new Font("Barlow Medium", 14.25F, FontStyle.Bold);
            labelAdmins.ForeColor = Color.FromArgb(239, 230, 220);
            labelAdmins.Location = new Point(358, 27);
            labelAdmins.Name = "labelAdmins";
            labelAdmins.Size = new Size(78, 24);
            labelAdmins.TabIndex = 17;
            labelAdmins.Text = "Admins";
            // 
            // FormAdminUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 31);
            ClientSize = new Size(1148, 529);
            Controls.Add(labelAdmins);
            Controls.Add(labelMusicians);
            Controls.Add(labelRestaurants);
            Controls.Add(roundedButtonDelete);
            Controls.Add(roundedButtonCreate);
            Controls.Add(roundedButtonEdit);
            Controls.Add(roundedButtonOpen);
            Controls.Add(dataGridViewUsers);
            Name = "FormAdminUsers";
            Text = "AdminUsers";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.RoundedButton roundedButtonDelete;
        private Controls.RoundedButton roundedButtonCreate;
        private Controls.RoundedButton roundedButtonEdit;
        private Controls.RoundedButton roundedButtonOpen;
        private DataGridView dataGridViewUsers;
        private Label labelRestaurants;
        private Label labelMusicians;
        private Label labelAdmins;
    }
}