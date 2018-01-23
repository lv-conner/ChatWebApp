using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace ChatWebApp
{
    [HubName("ChatHub")]
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }


        public override Task OnConnected()
        {
            Clients.All.hello(this.Context.ConnectionId);
            Clients.All.hello("connected");
            return base.OnConnected();
        }

        public override Task OnReconnected()
        {
            Clients.All.hello(this.Context.ConnectionId);
            Clients.All.hello("connected");
            return base.OnReconnected();
        }
    }
}