using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Application
{
    public interface IFactoryConnector
    {
        IConnector Get(ConnectorType type);
        string GetToken(string login, string password);
    }
}