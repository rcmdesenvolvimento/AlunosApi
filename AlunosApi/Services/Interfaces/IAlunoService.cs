using AlunosApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlunosApi.Services.Interfaces
{
    public interface IAlunoService
    {
        Task<IEnumerable<Aluno>> GetAllAlunos();
        Task<Aluno> GetAlunoById(int id);
        Task<IEnumerable<Aluno>> GetAlunosByNome(string nome);
        Task CreateAluno(Aluno aluno);
        Task UpdateAluno(Aluno aluno);
        Task DeleteAluno(Aluno aluno);
    }
}
