using KITAB.SQLite.CRUD.ConsoleApp.ViewModels;
using KITAB.SQLite.CRUD.Domain.Models;
using AutoMapper;

namespace KITAB.SQLite.CRUD.ConsoleApp
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
