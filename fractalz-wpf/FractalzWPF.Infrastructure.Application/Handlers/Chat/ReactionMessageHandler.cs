using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class ReactionMessageHandler : BaseChatHandler
    {
        public ReactionMessageHandler(IFactoryConnector connectors) : base(connectors) { }

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