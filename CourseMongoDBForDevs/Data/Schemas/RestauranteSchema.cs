using CourseMongoDBForDevs.Api.Domain.Entities.Enums;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using CourseMongoDBForDevs.Api.Domain.Entities;
using CourseMongoDBForDevs.Api.Domain.ValueObjects;

namespace CourseMongoDBForDevs.Api.Data.Schemas
{
    /// <summary>
    /// The restaurante schema.
    /// </summary>
    public class RestauranteSchema
    {
        /// <summary>
        /// Gets or Sets the id.
        /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets the nome.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Gets or Sets the cozinha.
        /// </summary>
        public ECozinha Cozinha { get; set; }
        /// <summary>
        /// Gets or Sets the endereco.
        /// </summary>
        public EnderecoSchema Endereco { get; set; }
    }

    public static class RestauranteSchemaExtensao
    {
        public static Restaurante ConverterParaDomain(this RestauranteSchema document)
        {
            var restaurante = new Restaurante(document.Id, document.Nome, document.Cozinha);
            var endereco = new Endereco(document.Endereco.Logradouro, document.Endereco.Numero, document.Endereco.Cidade, document.Endereco.UF, document.Endereco.Cep);
            restaurante.AtribuirEndereco(endereco);

            return restaurante;
        }
    }
}
