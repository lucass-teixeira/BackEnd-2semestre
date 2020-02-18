using senai.Filmes.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório Genero
    /// </summary>
    interface IGeneroRepository
    {
        /// <summary>
        /// Lista todos os gêneros
        /// </summary>
        /// <returns>Retorna uma lista de gêneros</returns>
        List<GeneroDomain> Listar();

        /// <summary>
        /// Cadastra um novo gênero
        /// </summary>
        /// <param name="genero"></param>
        void Cadastrar(GeneroDomain genero);

        void Deletar(int id);

        void AtualizarIdCorpo(GeneroDomain genero);

        void AtualizarIdUrl(int id, GeneroDomain genero);
    }
}
