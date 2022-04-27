using CefSharp;
using CefSharp.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class DefaultResourceRequestHandler : ResourceRequestHandler
    {
        protected override CefReturnValue OnBeforeResourceLoad(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback)
        {
            // change the library login request to post method
            if (request.Url == TestUrl.TestLink && request.Method == "GET")
            {
                request.Method = "POST";
            }
            return CefReturnValue.Continue;
        }
        protected override ICookieAccessFilter GetCookieAccessFilter(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request)
        {
            return null;
            // return new CookieAccessFilter();
            // return new CookieFilter();
        }
    }
}
