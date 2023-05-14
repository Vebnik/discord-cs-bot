using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discord.WebSocket;


namespace test_discord_bot.src.commands
{
    public class Codewars
    {
        public static void Execute(SocketMessage message)
        {
            message.Channel.SendMessageAsync("This is Codewars command");
        }
    }
}