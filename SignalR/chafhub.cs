using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR
{
    public class chafhub: Hub
    {
        
            public async Task Send(string name, string message)
            {
                // Call the broadcastMessage method to update clients.
                await Clients.Others.SendAsync("broadcastMessage", name, message);
            }
        
        
        
    }
}
