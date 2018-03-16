using System;
using System.Diagnostics;

namespace ApocalypseLauncher.HELPERS
{
    class FrmMainAboutLinks
    {

        #region Support links
        internal static void metroLinkAwesomium_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.awesomium.com/");
        }

        internal static void metroLinkModernUI_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nuget.org/packages/MetroModernUI/");
        }

        internal static void metroLinkNSJSON_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nuget.org/packages/Newtonsoft.Json/");
        }
        #endregion
    }
}
