using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.Handler;

namespace WpfApp2
{
    public class DefaultMenuHandler : ContextMenuHandler
    {
        protected override void OnBeforeContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            base.OnBeforeContextMenu(chromiumWebBrowser, browser, frame, parameters, model);

            // Add a separator in case that there are more items on the list
            if (model.Count > 0)
            {
                model.AddSeparator();
            }

            // Add a new item to the list using the AddItem method of the model
            model.AddItem(CefMenuCommand.Reload, "Reload");
        }

        protected override bool OnContextMenuCommand(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            if (commandId == CefMenuCommand.Reload)
            {
                chromiumWebBrowser.Reload();
                return true;
            }

            return base.OnContextMenuCommand(chromiumWebBrowser, browser, frame, parameters, commandId, eventFlags);
        }
    }
}
