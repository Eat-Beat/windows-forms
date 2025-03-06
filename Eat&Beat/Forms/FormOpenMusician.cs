using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eat_Beat.Forms
{
    public partial class FormOpenMusician : Form
    {
        private FormLogin formLogin;
        public FormOpenMusician(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            AddImagesToFlowLayoutPanel();
        }

        private void labelRestaurants_Click(object sender, EventArgs e)
        {

        }

        private void FormOpenMusician_Load(object sender, EventArgs e)
        {

        }

        private void roundedButtonOpenCalendar_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("CalendarPopup", true);
        }

        private void AddImagesToFlowLayoutPanel()
        {
            string folderPath = @"C:\Users\CEP-TARDA\source\repos\Eat-Beat\windows-forms\Eat&Beat\Images";

            // If the folder exists, get all image files (png, jpg, etc.)
            if (Directory.Exists(folderPath))
            {
                // You can filter for multiple extensions if needed
                string[] imageFiles = Directory.GetFiles(folderPath, "*.png");

                foreach (var filePath in imageFiles)
                {
                    try
                    {
                        Image img = Image.FromFile(filePath);

                        var pb = new PictureBox();
                        pb.Image = img;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Width = 100;  // adjust as needed
                        pb.Height = 100; // adjust as needed
                        pb.Margin = new Padding(10);

                        flowLayoutPanelImages.Controls.Add(pb);
                    }
                    catch (Exception ex)
                    {
                        // Handle errors (e.g., file not found, invalid image, etc.)
                        MessageBox.Show($"Could not load image {filePath}: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show($"Folder not found: {folderPath}");
            }
        }
    }
}
