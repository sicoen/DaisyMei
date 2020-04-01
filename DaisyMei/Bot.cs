using DSharpPlus;
using DSharpPlus.EventArgs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DaisyMei
{
    public class Bot
    {
        public DiscordClient Client { get; private set; }

        public async Task RunAsync()
        {
            var config = new DiscordConfiguration
            {

            };

            Client = new DiscordClient(config);

            Client.Ready += OnClientReady;
        }

        private Task OnClientReady(ReadyEventArgs e)
        {
            return null;
        }
    }
}
