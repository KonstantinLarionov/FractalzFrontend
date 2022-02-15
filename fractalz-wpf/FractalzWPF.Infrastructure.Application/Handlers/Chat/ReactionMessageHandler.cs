using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class ReactionMessageHandler : BaseChatHandler
    {
        public ReactionMessageHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data) { }

        public SendReactionResponse Do(int idMeesage, int idUser, EmojiType emojiType)
        {
            var request = new SendReactionRequest
            {
                IdMessage = idMeesage,
                IdUser =  idUser,
                EmojiType = emojiType
            };
            var response = _connector.Send<SendReactionResponse>(request, RequestType.SendReactionMessage);
            return response;
        }
    }
}