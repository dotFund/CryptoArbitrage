using Microsoft.Extensions.Configuration;
using System.Linq;

namespace ca_gui.Properties
{
    internal sealed partial class Settings
    {
        public CoinInfo CoinNames { get; }

        public Settings()
        {
            IConfigurationSection CoinInfoSection = new ConfigurationBuilder().AddJsonFile("config.json").Build().GetSection("CoinInfo");
            this.CoinNames = new CoinInfo(CoinInfoSection);
        }
    }

    internal class CoinInfo
    {
        public string[] CoinNameArray { get; }

        public CoinInfo(IConfigurationSection section)
        {
            this.CoinNameArray = section.GetSection("CoinNames").GetChildren().Select(p => p.Value).ToArray();
        }
    }
}
