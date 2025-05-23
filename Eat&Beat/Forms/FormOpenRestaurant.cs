﻿using System;
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
    public partial class FormOpenRestaurant : Form
    {
        private FormLogin formLogin;
        public FormOpenRestaurant(FormLogin formLogin)
        {
            this.formLogin = formLogin;
            InitializeComponent();
            InitializeWebView();
            LoadLanguage();
            LanguageManager.LanguageChanged += LoadLanguage;
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
                    //roundedTextBoxLongitut.Text = coordenadas.latitude.ToString();
                    //roundedTextBoxLatitut.Text = coordenadas.longitude.ToString();
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

        private void roundedButtonBack_Click(object sender, EventArgs e)
        {
            formLogin.LoadFormIntoPanel("FormRestaurantsUsers", true);
        }

        private void LoadLanguage()
        {
            roundedButtonOpenCalendar.Text = LanguageManager.GetText("roundedButtonOpenCalendar");
            roundedButtonBack.Text = LanguageManager.GetText("roundedButtonBack");
        }
    }
}
