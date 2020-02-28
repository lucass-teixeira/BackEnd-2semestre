using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Peoples.WebApi.Domains
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set;}

        //Define que o campo do email é obrigatorio
        [Required(ErrorMessage = "Informe o e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set;}

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "O campo senha precisa ter no minimo 6 caracteres e no máximo 25" )]
        public string Senha { get; set;}

        public string TituloTipoUsuario { get; set;}
    }
}
