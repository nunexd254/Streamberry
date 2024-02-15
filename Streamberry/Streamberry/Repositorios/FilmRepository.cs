using Microsoft.EntityFrameworkCore;
using Streamberry.Data;
using Streamberry.Models;
using Streamberry.Repositorios.Interfaces;

namespace Streamberry.Repositorios
{
    public class FilmRepository : IFilmRepository
    {
        private readonly SystemFilmsDBContext _dbContext;
        public FilmRepository(SystemFilmsDBContext systemFilmsDBContext) 
        { 
            _dbContext = systemFilmsDBContext;
        }
        public async Task<FilmModel> BuscarPorId(int id)
        {
            return await _dbContext.Film.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<FilmModel>> BuscarTodosFilmes()
        {
            return await _dbContext.Film.ToListAsync();
        }
        public async Task<FilmModel> Adicionar(FilmModel film)
        {
            await _dbContext.Film.AddAsync(film);
            await _dbContext.SaveChangesAsync();

            return film;
        }

        public async Task<FilmModel> Atualizar(FilmModel film, int id)
        {
            FilmModel filmPorId = await BuscarPorId(id);

            if(filmPorId == null)
            {
                throw new Exception($"Filme para o ID: {id} não foi encontrado no banco de dados.");
            }
            filmPorId.Title = film.Title;
            filmPorId.Year = film.Year; 

            _dbContext.Film.Update(filmPorId);
            await _dbContext.SaveChangesAsync();

            return filmPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            FilmModel filmPorId = await BuscarPorId(id);

            if (filmPorId == null)
            {
                throw new Exception($"Filme para o ID: {id} não foi encontrado no banco de dados.");
            }
            _dbContext.Film.Remove(filmPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

    }
}
