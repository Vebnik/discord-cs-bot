using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discord.WebSocket;
using test_discord_bot.src.commands;

namespace test_discord_bot.src
{
	public class CommandsHandler {

		public void MsgLogger(SocketMessage message)
		{	
			if (!message.Author.IsBot)
			{
				Console.WriteLine($"-------------");
				Console.WriteLine($"author -> {message.Author.Username}");
				Console.WriteLine($"content -> {message.Content}");
				Console.WriteLine($"-------------");
			}
		}

		public Task Switcher(SocketMessage message)
		{
			if (!message.Content.StartsWith('$'))
				return Task.CompletedTask;

			switch (message.Content)
			{
				case "$greeting":
				{	
					Greeting.Execute(message);
					break;
				}

				case "$hello":
				{	
					Hello.Execute(message);
					break;
				}

				case "$stuffy":
				{	
					Stuffy.Execute(message);
					break;
				}

				case "$help":
				{	
					Help.Execute(message);
					break;
				}

				case "$money":
				{	
					Money.Execute(message);
					break;
				}

				case "$zamat":
				{	
					Zamat.Execute(message);
					break;
				}

				case "$codewars":
				{
					Codewars.Execute(message);
					break;
				}
			}

			return Task.CompletedTask;
		}		
	}
}