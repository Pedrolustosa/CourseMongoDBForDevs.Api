using CourseMongoDBForDevs.Api.Domain.Entities.Enums;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

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
}
