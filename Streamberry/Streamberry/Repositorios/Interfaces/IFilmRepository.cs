using Streamberry.Models;

namespace Streamberry.Repositorios.Interfaces
{
    public interface IFilmRepository
    {
        Task<List<FilmModel>> BuscarTodosFilmes();
        Task<FilmModel> BuscarPorId(int id);
        Task<FilmModel> Adicionar(FilmModel film);
        Task<FilmModel> Atualizar(FilmModel film, int id);
        Task<bool> Apagar(int id);
    }
}
