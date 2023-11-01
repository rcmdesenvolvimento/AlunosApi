using AlunosApi.Context;
using AlunosApi.Models;
using AlunosApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunosApi.Services.Implementation
{
    public class AlunoServiceImpl : IAlunoService
    {
        private readonly AppDbContext _appDbContext;

        public AlunoServiceImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Aluno>> GetAllAlunos()
        {
            try
            {
                return await _appDbContext.Alunos.ToArrayAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Aluno> GetAlunoById(int id)
        {
            var aluno = await _appDbContext.Alunos.FindAsync(id);
            return aluno;
        }

        public async Task<IEnumerable<Aluno>> GetAlunosByNome(string nome)
        {
            IEnumerable<Aluno> alunos;

            if (!string.IsNullOrWhiteSpace(nome))
            {
                alunos = await _appDbContext.Alunos.Where(n => n.Nome.Contains(nome)).ToListAsync();
            }
            else
            {
                alunos = await GetAllAlunos();
            }
            return alunos;
        }

        public async Task CreateAluno(Aluno aluno)
        {
            _appDbContext.Add(aluno);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAluno(Aluno aluno)
        {
            _appDbContext.Remove(aluno);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task UpdateAluno(Aluno aluno)
        {
            _appDbContext.Entry(aluno).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
        }
    }
}