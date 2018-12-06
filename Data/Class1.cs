using System;

namespace Data
{
    public class Class1
    {
        public bool login (string user, string password)
        {
            bool IsValid = false;

            //  Constants
            var tenant = "viafinanciero.onmicrosoft.com ";
            var serviceUri = "https://LdapVplDemo.onmicrosoft.com/d0f883f6-1c32-4a14-a436-0a995a19c39b";
            var clientID = "b9faf13d-9258-4142-9a5a-bb9f2f335c2d";
            var userName = $"test@{tenant}";
            var password = "My$uperComplexPassw0rd1";

            //  Ceremony
            var authority = "https://login.microsoftonline.com/" + tenant;
            var authContext = new AuthenticationContext(authority);
            var credentials = new UserPasswordCredential(userName, password);
            var authResult = await authContext.AcquireTokenAsync(serviceUri, clientID, credentials);
        

            return IsValid;
        }

    }
}
