using senai.Filmes.WebApi.Domains;
using senai.Filmes.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Repositories
{
    public class FilmesRepository : IFilmesRepository
    {
        private const string conexao = "Data Source=DEV18\\SQLEXPRESS; initial catalog=Filmes_manha; user Id=sa; pwd=sa@132";

        public List<FilmeDomain> ListarFilme()
        {
            //Cria uma lista de filme onde serao armazenados os dados
            List<FilmeDomain> filmes = new List<FilmeDomain>();

            using (SqlConnection con = new SqlConnection(conexao))
            {
                string commandText = "SELECT IdFilme, Titulo, IdGenero FROM Filmes";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand comando = new SqlCommand(commandText, con))
                {

                    rdr = comando.ExecuteReader();

                    while(rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain()
                        {
                            IdFilme = Convert.ToInt32(rdr[0]),

                            Titulo = rdr["Titulo"].ToString(),
                            
                            IdGenero = Convert.ToInt32(rdr["IdGenero"])
                        };

                        filmes.Add(filme);

                    }
                }
            }
            return filmes;

        }
    }
}
