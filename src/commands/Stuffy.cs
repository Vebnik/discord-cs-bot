using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace test_discord_bot.src.commands
{

	public class Stuffy
	{
		public static void Execute(SocketMessage message)
		{	
			Random rnd = new Random();
			string msg = $"`{message.Author.Username}` -> {rnd.Next(0, 100)}%";
	        message.Channel.SendMessageAsync(msg);
		}
	} 
}