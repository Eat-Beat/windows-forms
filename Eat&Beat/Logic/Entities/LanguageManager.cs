using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Eat_Beat.Logic.Entities
{
    public static class LanguageManager
    {
        public static event Action LanguageChanged;

        public static void LoadSavedLanguage()
        {
            string language = Properties.Settings.Default.Language;
            ChangeLanguage(language, false);
        }

        public static void ChangeLanguage(string language, bool notify = true)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            Properties.Settings.Default.Language = language;
            Properties.Settings.Default.Save();

            if (notify)
            {
                LanguageChanged?.Invoke();
            }
        }

        public static string GetText(string key)
        {
            ResourceManager rm = new ResourceManager("Eat_Beat.Resources.Strings", typeof(LanguageManager).Assembly);
            return rm.GetString(key);
        }
    }
}
