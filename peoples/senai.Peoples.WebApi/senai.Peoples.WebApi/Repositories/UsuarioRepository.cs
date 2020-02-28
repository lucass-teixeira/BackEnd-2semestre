using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using senai.Peoples.WebApi.Domains;

namespace senai.Peoples.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string stringConexao = "Data Source=DEV18\\SQLEXPRESS; initial catalog=Filmes_tarde; user Id=sa; pwd=sa@132";

        public UsuarioDomain BuscarPorEmailSenha(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string CommandText = "SELECT IdUsuario, Email, Senha, Permissao FROM Usuarios WHERE Email = @EMAIL AND Senha = @Senha";

                using (SqlCommand cmd = new SqlCommand(CommandText, con))
                {
                    //Define o valor dos parametros 
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    cmd.Parameters.AddWithValue("@SENHA", senha);

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        // Cria um objeto usuario
                        UsuarioDomain usuario = new UsuarioDomain();

                        // Enquanto estiver percorrendo as linhas
                        while (rdr.Read())
                        {
                            // Atribui à propriedade IdUsuario o valor da coluna IdUsuario
                            usuario.IdUsuario = Convert.ToInt32(rdr["IdUsuario"]);

                            // Atribui à propriedade Email o valor da coluna Email
                            usuario.Email = rdr["Email"].ToString();

                            // Atribui à propriedade Senha o valor da coluna Senha
                            usuario.Senha = rdr["Senha"].ToString();

                            // Atribui à propriedade Permissao o valor da coluna Permissao
                            usuario.TituloTipoUsuario = rdr["TituloTipoUsuario"].ToString();
                        }

                        // Retorna o objeto usuario
                        return usuario;
                    }
                }



            }

        }
    }
   
}
