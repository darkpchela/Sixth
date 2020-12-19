using Microsoft.AspNetCore.SignalR;
using Sixth.Interfaces;
using Sixth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sixth.Services
{
    public class MainHub : Hub
    {
        private readonly INodeCrudService nodeCrudService;

        public MainHub(INodeCrudService nodeCrudService)
        {
            this.nodeCrudService = nodeCrudService;
        }

        public async override Task OnConnectedAsync()
        {
            var nodes = await nodeCrudService.GetAll();
            await Clients.Caller.SendAsync("OnConnected", nodes);
        }

        public async Task CreateNode(Node node)
        {
            var id = await nodeCrudService.Create(node);
            await Clients.All.SendAsync("OnNodeCreated", id, node);
        }
    }
}
