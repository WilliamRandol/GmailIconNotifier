using System;
using System.Collections.Generic;
using System.Text;

namespace Gmail_Icon_Notifier
{
    public static class Controller
    {
        public static AboutWindow about = new AboutWindow();
        public static Settings settings = new Settings();
        public static bool aboutOpen = false;
        public static bool settingsOpen = false;

        public static void openAbout()
        {
            try
            {
                about.Show();
            }
            catch
            {
                about = new AboutWindow();
                about.Show();
            }
            aboutOpen = true;
        }

        public static void openSettings()
        {
            try
            {
                settings.Show();
            }
            catch
            {
                settings = new Settings();
                settings.Show();
            }
            settingsOpen = true;
        }

        public static void closeAbout()
        {
            about.Close();
            aboutOpen = false;
        }

        public static void closeSettings()
        {
            settings.Close();
            settingsOpen = false;
        }
    }
}
