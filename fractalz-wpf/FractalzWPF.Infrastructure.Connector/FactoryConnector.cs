﻿using System.Collections.Generic;
using System.Linq;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Connector
{
    public class FactoryConnector : IFactoryConnector
    {
        private Dictionary<ConnectorType, IConnector> _dictionary;

        public FactoryConnector()
        {
            _dictionary = new Dictionary<ConnectorType, IConnector>()
            {
                {ConnectorType.Chat, new ChatConnector()},
                {ConnectorType.Todo, new TodoConnector()},
                {ConnectorType.User, new UserConnector()},
            };
        }

        public IConnector Get(ConnectorType type) => 
            _dictionary.FirstOrDefault(x => x.Key == type).Value;
    }
}