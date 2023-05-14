using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace test_discord_bot.src.commands
{

	public class Money
	{
		public static void Execute(SocketMessage message)
		{	
 	 		string msg = 
	 	 		"💰 Сегодня курс\n"+
	 	 		"```fix\n"+
	 	 		"1 Доллар $ = СТОЛЬКО рубль ₽\n"+
	 	 		"1 Евро € = СТОЛЬКО рубль ₽\n"+
	 	 		"1 Грывня ₴ = СТОЛЬКО рубль ₽\n"+
		 		"1 Тэнгэ ₸ = СТОЛЬКО рубль ₽\n"+
    	 		"```";

	        message.Channel.SendMessageAsync(msg);
		}
	} 
}