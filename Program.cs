using Microsoft.VisualBasic;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using testBot;

var botClient = new TelegramBotClient("6104982128:AAFlG61y44DFOegDeIbslhSOSyEAK8WuU9U");
using var cts = new CancellationTokenSource();
var receiverOptions = new ReceiverOptions
{
    AllowedUpdates = Array.Empty<UpdateType>() // receive all update types

};
botClient.StartReceiving(HandleUpdateAsync,
                         HandlePollingErrorAsync,
                         receiverOptions,
                         cts.Token);

Task HandlePollingErrorAsync(ITelegramBotClient client, Exception exception, CancellationToken token)
{
    var ErrorMessage = exception switch
    {
        ApiRequestException apiRequestException
            => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
        _ => exception.ToString()
    };

    Console.WriteLine(ErrorMessage);
    return Task.CompletedTask;
}


async Task HandleUpdateAsync(ITelegramBotClient client, Update update, CancellationToken token)
{
    Console.WriteLine($"{update?.Message?.Chat.Username} | {update?.Message?.Text} | {update?.Message?.Contact?.PhoneNumber}");
    if (update?.Type == UpdateType.Message && update.Message != null)
    {
        await MessageUpdate.Mes(client, update, token);
    }
}

Console.ReadLine();