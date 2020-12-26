using KITAB.SQLite.CRUD.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace KITAB.SQLite.CRUD.Application.Notificadores
{
    public class NotificadorService : INotificadorService
    {
        private readonly List<Notificacao> _notificacoes;

        public NotificadorService()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
