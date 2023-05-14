using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Discord;
using Discord.WebSocket;
using test_discord_bot.src;

namespace test_discord_bot
{
	public class Program
	{

		private DiscordSocketClient? _client;
		private CommandsHandler? _commandHandler;

		public static Task Main(string[] args) => new Program().MainAsync();

		public async Task MainAsync()
		{	
			var _env = Utils.ConfigParse("env.json");
			var _config = new DiscordSocketConfig { MessageCacheSize = 100,GatewayIntents = GatewayIntents.AllUnprivileged | GatewayIntents.MessageContent};

			_commandHandler = new CommandsHandler();
			_client = new DiscordSocketClient(_config);

			await _client.LoginAsync(TokenType.Bot, _env.Token);
			await _client.StartAsync();

			_client.Log += Log;
		 	_client.MessageReceived += EventMessageReceived;
			
			await Task.Delay(-1);
		}

		private Task Log(LogMessage msg)
		{
			Console.WriteLine(msg.ToString());
			return Task.CompletedTask;
		}

		private Task EventMessageReceived(SocketMessage message)
		{	
			_commandHandler.MsgLogger(message);
			_commandHandler.Switcher(message);

			return Task.CompletedTask;
		}
	}
}