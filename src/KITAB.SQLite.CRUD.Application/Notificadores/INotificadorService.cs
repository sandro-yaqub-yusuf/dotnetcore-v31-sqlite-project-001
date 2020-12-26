using KITAB.SQLite.CRUD.Domain.Models;
using System.Collections.Generic;

namespace KITAB.SQLite.CRUD.Application.Notificadores
{
    public interface INotificadorService
    {
        void Handle(Notificacao notificacao);
        List<Notificacao> ObterNotificacoes();
        bool TemNotificacao();
    }
}
