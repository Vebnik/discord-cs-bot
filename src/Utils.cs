using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test_discord_bot.src
{
    public class Utils
    {
        public class AConfigurationClass
        {
            public string? Token;
        }

        public static AConfigurationClass? ConfigParse(string envPath)
        {
            return JsonConvert.DeserializeObject<Utils.AConfigurationClass>(File.ReadAllText("env.json"));
        }
    }
}