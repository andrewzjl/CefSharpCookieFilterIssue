using CefSharp;
using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            CefSettings cefSet = new CefSettings();
            const string DISABLE_WEB_SECURITY = "disable-web-security";
            cefSet.CefCommandLineArgs.Add(DISABLE_WEB_SECURITY, DISABLE_WEB_SECURITY);
            Cef.Initialize(cefSet);
        }
    }
}
