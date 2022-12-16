using Singleton;

var configurationManager = ConfigurationManager.GetConfiguration();
configurationManager.AddConfig("SiteName", "Bugfixer");

Console.WriteLine(configurationManager.GetConfig("SiteName"));

var otherConfigurationManager = ConfigurationManager.GetConfiguration();

Console.WriteLine(otherConfigurationManager.GetConfig("SiteName"));