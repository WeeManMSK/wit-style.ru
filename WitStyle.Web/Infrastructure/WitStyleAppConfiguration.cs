using Microsoft.Extensions.Configuration;
using WitStyle.Common;

namespace WitStyle.Web
{
    public class WitStyleAppConfiguration : IAppConfiguration
    {
        private readonly IConfiguration _configuration;

        public WitStyleAppConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string WitStyleConnectionString { get => _configuration.GetConnectionString("WitStyleConnectionString"); }
    }
}
