using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;


namespace test_discord_bot.src.commands
{
	public class Greeting
	{
		public static void Execute(SocketMessage message)
		{	
			string msg = $"Greeting - `{message.Author.Username}`";
	        message.Channel.SendMessageAsync(msg);
		}
	} 
}