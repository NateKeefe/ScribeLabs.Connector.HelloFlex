namespace ScribeLabs.Connector.HelloFlex
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    using Simple.Connector.Framework.Http;

    using Models;

    public class HelloFlexConnectionInfo : JsonHttpConnectionInfoBase<HelloFlexConnectionInfo>
    {
        public string BaseUrl { get; set; }

        public string ClientId { get; set; }

        [PasswordPropertyText(true)]
        public string ClientSecret { get; set; }

        public string AccessTokenUrl { get; set; }

        protected override Func<HelloFlexConnectionInfo, IConnectionConfiguration> ConnectionConfiguration()
        {
            var connected = this.Connection.Configure("POST", AccessTokenUrl)
                .ConnectionInfoToForm("grant_type", "client_credentials")
                .ConnectionInfoToForm("client_id", ClientId)
                .ConnectionInfoToForm("client_secret", ClientSecret)
                .FromResponseToContext<AuthResponse>("Authorization", (rA => rA.token_type + " " + rA.access_token))
                .ConnectionInfoToBaseUrl(info => BaseUrl)
                .End();
            return connected;
        }
        protected override IList<HttpQueryRegistration> ConfigureQueries()
        {
            var test = this.Queries.EnumerateResponseAs<Test, Rootobject>("test", r => r.Items.Cast<Test>());

            return new List<HttpQueryRegistration> { test };
        }

        protected override IList<HttpCallDescription> ConfigureOperations()
        {
            // For each entity that supports target operations, configure an operation.
            // Creates
            var createTest = this.Operations.Create<Test>("test");

            // Updates
            var updateTest = this.Operations.Update<Test>("test");

            return new List<HttpCallDescription> { createTest, updateTest };
        }
    }
}
