using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BrowserInstance.RequestHandler = new DefaultRequestHandler();
            BrowserInstance.MenuHandler = new DefaultMenuHandler();
            BrowserInstance.IsBrowserInitializedChanged += BrowserInstance_IsBrowserInitializedChanged;
        }

        private void BrowserInstance_IsBrowserInitializedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (BrowserInstance.IsBrowserInitialized)
            {
                BrowserInstance.LoadUrl(TestUrl.TestLink);
                BrowserInstance.Reload();
            }
        }

        private void Executed_Open(object sender, ExecutedRoutedEventArgs e)
        {
            BrowserInstance.WebBrowser.ShowDevTools();
        }
    }
}
