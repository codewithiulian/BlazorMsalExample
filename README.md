# BlazorMsalExample
A Blazor WebAssembly app, ASP.NET Core hosted with integrated MSAL (Azure AD SSO)

## Installation
1. Create an Azure AD Application. For this type of app, this will be a Single-page application. Set the redirect URI as https://localhost:7268/authentication/login-callback. Notice, the port can be found in your Blazor Server project, under Properties > launchSettings.json > https > applicationUrl (the https one)
2. In [Client/wwwroot](https://github.com/codewithiulian/BlazorMsalExample/tree/main/Client/wwwroot) add an appsettings.json file with the following structure:
```
"AzureAd": {
        "Authority": "https://login.microsoftonline.com/TENANT_ID_HERE",
        "ClientId": "CLIENT_ID_HERE",
        "ValidateAuthority": true
    }
```
