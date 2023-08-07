using Discord.WebSocket;

namespace SallyBot
{
    internal static class MainGlobal
    {
        internal static SocketGuild Server { get; set; }
        internal static DiscordSocketClient Client { get; set; }

        internal static string conS = "shit goes here innit";
        internal static ulong guildId = 69420;
    }
}
