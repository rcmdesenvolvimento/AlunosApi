using AlunosApi.Models;
using AlunosApi.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlunosApi.Services.Implementation
{
    public class AlunoServiceImpl : IAlunoService
    {
        public Task CreateAluno(Aluno aluno)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAluno(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Aluno> GetAluno(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Aluno>> GetAlunos()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Aluno>> GetAlunosByNome(string nome)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAluno(Aluno aluno)
        {
            throw new System.NotImplementedException();
        }
    }
}
