﻿using System.Linq;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Collections.Generic;
using CourseMongoDBForDevs.Api.Data.Schemas;
using CourseMongoDBForDevs.Api.Domain.Entities;
using CourseMongoDBForDevs.Api.Domain.ValueObjects;

namespace CourseMongoDBForDevs.Api.Data.Repositories
{
    public class RestauranteRepository
    {
        public readonly IMongoCollection<RestauranteSchema> _restaurantes;

        public RestauranteRepository(MongoDB mongoDB)
        {
            _restaurantes = mongoDB.DB.GetCollection<RestauranteSchema>("restaurantes");
        }

        public void Inserir(Restaurante restaurante)
        {
            var document = new RestauranteSchema
            {
                Nome = restaurante.Nome,
                Cozinha = restaurante.Cozinha,
                Endereco = new EnderecoSchema
                {
                    Logradouro = restaurante.Endereco.Logradouro,
                    Numero = restaurante.Endereco.Numero,
                    Cidade = restaurante.Endereco.Cidade,
                    Cep = restaurante.Endereco.CEP,
                    UF = restaurante.Endereco.UF
                }
            };

            _restaurantes.InsertOne(document);
        }

        public async Task<IEnumerable<Restaurante>> ObterTodos()
        {
            var restaurantes = new List<Restaurante>();
            await _restaurantes.AsQueryable().ForEachAsync(d =>
            {
                var r = new Restaurante(d.Id.ToString(), d.Nome, d.Cozinha);
                var e = new Endereco(d.Endereco.Logradouro, d.Endereco.Numero, d.Endereco.Cidade, d.Endereco.UF, d.Endereco.Cep);
                r.AtribuirEndereco(e);
                restaurantes.Add(r);
            });
            return restaurantes;
        }

        public Restaurante ObterPorId(string id)
        {
            var document = _restaurantes.AsQueryable().FirstOrDefault(_ => _.Id == id);
            if (document == null)
                return null;
            return document.ConverterParaDomain();
        }
    }

}
