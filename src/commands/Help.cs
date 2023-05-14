using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace test_discord_bot.src.commands
{

	public class Help
	{
		public static void Execute(SocketMessage message)
		{	
	 	 	string msg = 
	 	 		"Мои команды\n"+
	 	 		"```fix\n"+
	 	 		"$weather ⛅ - погода в любом городе\n"+
	 	 		"$money 💸 - курс ценных бумаг\n"+
	 	 		"$skills 🖥️ - boss of the CodeWars\n"+
		 		"$puke 💨👃 - Слава не рыгун\n"+
		 		"$zamat 🔞 - хто ты сьогоднi\n"+
		 		"$stuffy 🤓 - На сколько % ты душный\n"+
    	 		"$swap 🔄  - обменяться % душноты\n"+
    	 		"$list 📃 - узнать кто есть кто\n"+
    	 		"```";

	        message.Channel.SendMessageAsync(msg);
		}
	} 
}