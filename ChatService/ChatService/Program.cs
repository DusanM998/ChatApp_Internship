using ChatService.Hubs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddSignalR();

app.MapHub<ChatHub>("/chat");

app.Run();
