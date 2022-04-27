This repo is for reproducing the CefSharp cookie filter issue.

### Issue description:
If the IResourceRequestHandler.GetCookieAccessFilter returns any ICookieAccessFilter instead of null, some requests will be failed to send the cookie.

### Reproduce step:
1. start the repo
2. reload the page by RMC if the window is empty
3. if DefaultResourceRequestHandler.GetCookieAccessFilter return null, the page is shown as expected, which likes below
![image](https://user-images.githubusercontent.com/10008129/165446432-af83a2d6-cbc6-489e-88f1-0a71c94eff82.png)

4. if return any cookie filter here, the page will be shown with unexpected error because the last request will not send any cookie
![image](https://user-images.githubusercontent.com/10008129/165446562-b2e25e4e-8e2b-409b-b30d-890368c73554.png)

