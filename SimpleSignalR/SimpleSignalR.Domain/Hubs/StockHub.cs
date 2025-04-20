using Microsoft.AspNetCore.SignalR;

namespace SimpleSignalR.Domain.StockHub
{
    public class StockHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("ReceiveMessenge", $"{Context.ConnectionId} has connected");
        }

        public async Task AskStockPrice(String stock)
        {
            await Clients.All.SendAsync($"Receive: Stock: {stock}, Price: {10000}, Volume: {30000}");
        }
    }
}
