using Microsoft.Extensions.Configuration;
using System;
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

        public string WitStyleConnectionString { get => GetCOnnectionString("WitStyleConnectionString"); }

        private string GetCOnnectionString(string name) =>
            Environment.GetEnvironmentVariable($"ConnectionStrings:{name}") ?? _configuration.GetConnectionString(name);
    }
}
