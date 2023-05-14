using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace test_discord_bot.src.commands
{
	public class Zamat
	{
		public static void Execute(SocketMessage message)
		{	
 	 		string msg = $"`{message.Author.Username}` ты сегодня ЛОХ";

	        message.Channel.SendMessageAsync(msg);
		}
	} 
}