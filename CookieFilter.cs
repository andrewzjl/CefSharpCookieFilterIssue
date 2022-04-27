using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class CookieFilter : ICookieAccessFilter
    {
        /// <summary>
        /// Called on the CEF IO thread after a resource response is received.
        /// </summary>
        /// <param name="chromiumWebBrowser">The ChromiumWebBrowser control</param>
        /// <param name="browser">the browser object - may be null if originating from ServiceWorker or CefURLRequest</param>
        /// <param name="frame">the frame object - may be null if originating from ServiceWorker or CefURLRequest</param>
        /// <param name="request">the request object - cannot be modified in this callback</param>
        /// <param name="response">the response object - cannot be modified in this callback</param>
        /// <param name="cookie">the cookie object</param>
        /// <returns>
        /// Return true if the specified cookie returned with the response can be saved or false otherwise.
        /// </returns>
        /// Created By: jzeng On: 4/27/2022
        public bool CanSaveCookie(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response, Cookie cookie)
        {
            return true;
        }

        /// <summary>
        /// Called on the CEF IO thread before a resource request is sent.
        /// </summary>
        /// <param name="chromiumWebBrowser">The ChromiumWebBrowser control</param>
        /// <param name="browser">the browser object - may be null if originating from ServiceWorker or CefURLRequest</param>
        /// <param name="frame">the frame object - may be null if originating from ServiceWorker or CefURLRequest</param>
        /// <param name="request">the request object - cannot be modified in this callback</param>
        /// <param name="cookie">the cookie object</param>
        /// <returns>
        /// Return true if the specified cookie can be sent with the request or false otherwise.
        /// </returns>
        /// Created By: jzeng On: 4/27/2022
        public bool CanSendCookie(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, Cookie cookie)
        {
            return true;
        }
    }
}
