using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eat_Beat.Logic.Entities;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json.Linq;

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
            InitializeWebView();
            LoadLanguage();
            LanguageManager.LanguageChanged += LoadLanguage;
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

        /// <summary>
        /// Temporary Image Load, this will have to be change to loading images from the API
        /// </summary>
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

        private async void InitializeWebView()
        {
            webView2MapBox.Source = new Uri(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Map/map.html"));
            webView2MapBox.WebMessageReceived += WebView2_WebMessageReceived;
        }

        private void WebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                JObject data = JObject.Parse(e.WebMessageAsJson);

                Coordenadas coordenadas = data.ToObject<Coordenadas>();

                if (coordenadas != null)
                {
                    // Guardar coordenadas en un objeto (muestra en los TextBox)
                    //textBox1.Text = coordenadas.latitude.ToString();
                    //textBox2.Text = coordenadas.longitude.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recibir coordenadas: " + ex.Message);
            }
        }

        public class Coordenadas
        {
            public string latitude { get; set; }
            public string longitude { get; set; }
        }

        private void webView2MapBox_Click(object sender, EventArgs e)
        {

        }

        private void roundedButtonBack_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormMusicianUsers", true);
        }

        private void LoadLanguage()
        {
            roundedButtonOpenCalendar.Text = LanguageManager.GetText("roundedButtonOpenCalendar");
            roundedButtonBack.Text = LanguageManager.GetText("roundedButtonBack");
        }
    }
}
