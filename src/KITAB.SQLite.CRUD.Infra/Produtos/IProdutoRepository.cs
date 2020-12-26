using KITAB.SQLite.CRUD.Domain.Models;

namespace KITAB.SQLite.CRUD.Infra.Produtos
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        void CriarTabelaProduto();
    }
}
