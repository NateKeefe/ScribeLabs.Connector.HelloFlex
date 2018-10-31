namespace ScribeLabs.Connector.HelloFlex
{
    using Simple.Connector.Framework;
    using Simple.Connector.Framework.Http;

    [SimpleConnector(
        ConnectorSettings.ConnectorTypeId,
        ConnectorSettings.Name,
        ConnectorSettings.Description,
        typeof(HelloFlexConnector),
        ConnectorSettings.SupportsCloud,
        ConnectorSettings.ConnectorVersion)]
    public class HelloFlexConnector : HttpConnectorBase<HelloFlexConnectionInfo>
    {
        public HelloFlexConnector()
            : base(ConnectorSettings.ConnectorTypeId, "Scribe Labs", "http://www.scribesoft.com", "f6168f22-2fac-49c8-a4c1-dd3965ce7ae1")
        {
        }
    }
}
