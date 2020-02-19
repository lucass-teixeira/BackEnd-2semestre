using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.Filmes.WebApi.Domains;
using senai.Filmes.WebApi.Interfaces;
using senai.Filmes.WebApi.Repositories;

namespace senai.Filmes.WebApi.Controllers
{
    [Produces("aplication/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class FilmesController : ControllerBase
    {
        private IFilmesRepository _filmesRepository { get; set; }

        public FilmesController()
        {
            _filmesRepository = new FilmesRepository();
        }

        //Quando eu faço um get no postman é chamado esse metodo
        [HttpGet]
        public IEnumerable<FilmeDomain> Get()
        {
            //Retorna para o metodo ListarFilme
            return _filmesRepository.ListarFilme();
        }

    }
}