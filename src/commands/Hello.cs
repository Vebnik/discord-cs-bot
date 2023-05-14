using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace test_discord_bot.src.commands
{

	public class Hello
	{
		public static void Execute(SocketMessage message)
		{	
			string msg = $"Привет {message.Author.Username}";
	        message.Channel.SendMessageAsync(msg);
		}
	} 
}