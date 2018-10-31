namespace ScribeLabs.Connector.HelloFlex
{
    /// <summary>
    /// Used for Discovery. These constants are used to fill in some of the values in the
    /// ScribeConnectorAttrribute declaration on the class that implements IConnector.
    /// Connector settings that are often or must different from other connectors.
    /// </summary>
    public class ConnectorSettings
    {
        public const string ConnectorTypeId = "36819972-a2bd-4b61-ac12-10a768361c73";
        public const string ConnectorVersion = "1.0";
        public const string Description = "HelloFlex";
        public const string Name = "Scribe Labs - HelloFlex";
        public const bool SupportsCloud = true;
        public const string CompanyName = "ScribeLabs";
        public const string AppName = "HelloFlex";
        public const string Copyright = "Copyright © 2018 ScribeLabs All rights reserved.";
    }
}
