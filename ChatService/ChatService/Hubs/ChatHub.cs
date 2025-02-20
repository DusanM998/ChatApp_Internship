using ChatService.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChatService.Hubs
{
    public class ChatHub : Hub
    {
        private readonly string _botUser;

        public ChatHub()
        {
            _botUser = "My Chat Bot";
        }

        public async Task JoingRoom(UserConnection userConnection)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, userConnection.Room);

            await Clients.Group(userConnection.Room).SendAsync("Recive Message", _botUser,
                $"{userConnection.User} has joined {userConnection.Room}");
        }
    }
}
