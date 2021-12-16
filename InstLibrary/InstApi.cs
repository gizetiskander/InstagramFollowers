using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstLibrary
{
    public class InstApi
    {
        private const string InstApiDef = "https://api.instagram.com/v1/";
        private const string OAuthUriDef = "https://api.instagram.com/oauth/";
        private const string RealTimeApiDef = "https://api.instagram.com/v1/subscriptions/";

        public string InstUri { get; set; }

        public string OAuthUri { get; set; }

        public string RealTimeApi { get; set; }

        public string ClientID { get; set; }

        public string ClientSecret { get; set; }

        public string RedirectUri { get; set; }

        public string CallBackUri { get; set; }

        public InstApi() 
            : this(null,null,null,null, InstApiDef, OAuthUriDef, RealTimeApiDef)
        {
        }

        public InstApi(string clientId, string clientSecret)
            : this(clientId, clientSecret, null, null, InstApiDef, OAuthUriDef, RealTimeApiDef)
        {
        }

        public InstApi(string clientId, string clientSecret, string redirectUri)
          : this(clientId, clientSecret, redirectUri, null, InstApiDef, OAuthUriDef, RealTimeApiDef)
        {
        }

        public InstApi(string clientId, string clientSecret, string redirectUri, string callbackUri)
            : this(clientId, clientSecret, redirectUri, callbackUri, InstApiDef, OAuthUriDef, RealTimeApiDef)
        {
        }
        public InstApi(string instUri, string oAuthUri, string realTimeApi, string clientID, string clientSecret, string redirectUri, string callBackUri)
        {
            InstUri = instUri;
            OAuthUri = oAuthUri;
            RealTimeApi = realTimeApi;
            ClientID = clientID;
            ClientSecret = clientSecret;
            RedirectUri = redirectUri;
            CallBackUri = callBackUri;
        }
    }
}
