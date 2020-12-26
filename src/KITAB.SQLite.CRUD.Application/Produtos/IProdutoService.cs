using KITAB.SQLite.CRUD.Domain.Models;
using System.Collections.Generic;

namespace KITAB.SQLite.CRUD.Application.Produtos
{
    public interface IProdutoService
    {
        void Inserir(Produto produto);
        void Alterar(Produto produto);
        void Excluir(int id);
        Produto ObterPorId(int id);
        List<Produto> ObterTodos();
        void ExecuteSQL(string sql);
        void CriarTabelaProduto();
    }
}
