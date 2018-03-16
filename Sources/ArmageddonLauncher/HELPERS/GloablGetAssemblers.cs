using System.Reflection;

namespace ApocalypseLauncher.HELPERS
{
    public static class GloablGetAssemblers
    {
        private static readonly Assembly GetExecutingAssembly = Assembly.GetExecutingAssembly();

        #region Методы доступа к атрибутам сборки

        public static string AssemblyTitle
        {
            get
            {
                var attributes = GetExecutingAssembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length <= 0)
                    return System.IO.Path.GetFileNameWithoutExtension(GetExecutingAssembly.CodeBase);
                var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                return titleAttribute.Title != "" ? titleAttribute.Title : System.IO.Path.GetFileNameWithoutExtension(GetExecutingAssembly.CodeBase);
            }
        }

        public static string AssemblyVersion => GetExecutingAssembly.GetName().Version.ToString();

        public static string AssemblyDescription
        {
            get
            {
                var attributes = GetExecutingAssembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string AssemblyProduct
        {
            get
            {
                var attributes = GetExecutingAssembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string AssemblyCopyright
        {
            get
            {
                var attributes = GetExecutingAssembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string AssemblyCompany
        {
            get
            {
                var attributes = GetExecutingAssembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

    }
}