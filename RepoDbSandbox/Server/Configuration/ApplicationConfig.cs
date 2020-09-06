using Microsoft.Extensions.Logging;

namespace RepoDbSandbox.Server.Configuration
{
    public class ApplicationConfig
    {
        public LoggingConfig Logging { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
        public string ServiceBusConnectionString { get; set; }
        public string AllowedHosts { get; set; }
    }
    public class LoggingConfig
    {
        public LogLevel LogLevel { get; set; }
    }
    public class ConnectionStrings
    {
        public string BedRockConnection { get; set; }
    }
}
