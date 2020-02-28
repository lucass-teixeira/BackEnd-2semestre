using senai.Peoples.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Peoples.WebApi.Repositories
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Valida o Usuario
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        UsuarioDomain BuscarPorEmailSenha(string email, string senha);
    }
}
