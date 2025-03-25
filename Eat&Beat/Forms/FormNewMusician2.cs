using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eat_Beat.Controls;
using Eat_Beat.Logic.Entities;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eat_Beat.Forms
{
    public partial class FormNewMusician2 : Form
    {
        private FormLogin formLogin;
        public FormNewMusician2(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            InitializeWebView();
            roundedComboBoxKm.SelectedIndex = 0;
            LoadLanguage();
            LanguageManager.LanguageChanged += LoadLanguage;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            SendCoords(41.38868, 2.17328, 5);
            roundedTextBoxLatitut.Texts = "41.38868";
            roundedTextBoxLongitut.Texts = "2.17328";
            roundedComboBoxKm.SelectedIndex = 0;
        }
        private void LoadLanguage()
        {
            labelLongitut.Text = LanguageManager.GetText("labelLongitut");
            labelLatitut.Text = LanguageManager.GetText("labelLatitut");
            labelRangeKm.Text = LanguageManager.GetText("labelRangeKm");
            roundedButtonCancel.Text = LanguageManager.GetText("roundedButtonCancel");
            roundedButtonContinue.Text = LanguageManager.GetText("roundedButtonContinue");
        }

        private async void InitializeWebView()
        {
            webView2MapBox.Source = new Uri(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Map/map.html"));

            webView2MapBox.CoreWebView2InitializationCompleted += async (sender, args) =>
            {
                if (webView2MapBox.CoreWebView2 != null)
                {
                    // Esperar a que la navegación termine antes de enviar las coordenadas
                    webView2MapBox.CoreWebView2.NavigationCompleted += async (s, e) =>
                    {
                        await SendCoords(41.38868, 2.17328, 5);
                        roundedTextBoxLatitut.Texts = "41.38868";
                        roundedTextBoxLongitut.Texts = "2.17328";
                    };
                }
            };

            webView2MapBox.WebMessageReceived += WebView2_WebMessageReceived;
        }

        private void WebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                string jsonString = e.WebMessageAsJson;

                jsonString = JsonConvert.DeserializeObject<string>(jsonString);

                Coordenadas coordenadas = JsonConvert.DeserializeObject<Coordenadas>(jsonString);

                if (coordenadas != null)
                {
                    // Guardar coordenadas en un objeto (muestra en los TextBox)
                    roundedTextBoxLatitut.Texts = coordenadas.latitude.ToString();
                    roundedTextBoxLongitut.Texts = coordenadas.longitude.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recibir coordenadas: " + ex.Message);
            }
        }

        private async Task SendCoords(double lat, double lng, int rad)
        {
            try
            {
                string script = $"setMarker({lat.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {lng.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {rad.ToString(System.Globalization.CultureInfo.InvariantCulture)});";
                await webView2MapBox.ExecuteScriptAsync(script);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar coordenadas iniciales: " + ex.Message);
            }
        }
        public class Coordenadas
        {
            public string latitude { get; set; }
            public string longitude { get; set; }
        }

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormMusicianUsers", true);
        }

        private void roundedButtonContinue_Click(object sender, EventArgs e)
        {
            formLogin.selectedMusician.longitude = double.Parse(roundedTextBoxLongitut.Texts, System.Globalization.CultureInfo.InvariantCulture);
            formLogin.selectedMusician.latitude = double.Parse(roundedTextBoxLatitut.Texts, System.Globalization.CultureInfo.InvariantCulture);
            
            formLogin.Musicians.Add(formLogin.selectedMusician);
            formLogin.LoadFormIntoPanel("FormMusicianUsers", true);
            //formLogin.LoadFormIntoPanel("FormNewMusician3", false);
        }

        private void roundedComboBoxKm_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (roundedComboBoxKm.SelectedItem != null)
            {
                int selectedKm;

                // Si el usuario selecciona "∞", asignar radio = 0
                if (roundedComboBoxKm.SelectedItem.ToString() == "∞")
                {
                    selectedKm = 0;
                }
                else if (!int.TryParse(roundedComboBoxKm.SelectedItem.ToString(), out selectedKm))
                {
                    MessageBox.Show("Error: El valor seleccionado no es un número válido.");
                    return;
                }

                // Verificar si los TextBox están vacíos antes de convertir
                if (string.IsNullOrWhiteSpace(roundedTextBoxLatitut.Texts) || string.IsNullOrWhiteSpace(roundedTextBoxLongitut.Texts))
                {
                    return; // No hacer nada hasta que haya coordenadas válidas
                }

                double lat, lng;

                if (!double.TryParse(roundedTextBoxLatitut.Texts, System.Globalization.CultureInfo.InvariantCulture, out lat) ||
                    !double.TryParse(roundedTextBoxLongitut.Texts, System.Globalization.CultureInfo.InvariantCulture, out lng))
                {
                    MessageBox.Show("Error: Las coordenadas no son válidas.");
                    return;
                }

                _ = SendCoords(lat, lng, selectedKm);
            }
        }
    }
}
