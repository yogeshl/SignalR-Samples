﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatApp.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.NewMessageCallback(name, message);
        }
    }
}