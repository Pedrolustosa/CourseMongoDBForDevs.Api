using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using Microsoft.Extensions.Configuration;
using CourseMongoDBForDevs.Api.Data.Schemas;
using MongoDB.Bson.Serialization.Serializers;
using CourseMongoDBForDevs.Api.Domain.Entities.Enums;

namespace CourseMongoDBForDevs.Api.Data
{
    /// <summary>
    /// The mongo DB.
    /// </summary>
    public class MongoDB
    {
        /// <summary>
        /// Gets the DB.
        /// </summary>
        public IMongoDatabase DB { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDB"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public MongoDB(IConfiguration configuration)
        {
            try
            {
                var client = new MongoClient(configuration["ConnectionString"]);
                DB = client.GetDatabase(configuration["MongoDBString"]);
                MapClasses();
            }
            catch (Exception ex)
            {
                throw new MongoException("Não foi possivel se conectar ao MongoDB", ex);
            }
        }

        /// <summary>
        /// Maps the classes.
        /// </summary>
        private void MapClasses()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(RestauranteSchema)))
            {
                BsonClassMap.RegisterClassMap<RestauranteSchema>(i =>
                {
                    i.AutoMap();
                    i.MapIdMember(c => c.Id);
                    i.MapMember(c => c.Cozinha).SetSerializer(new EnumSerializer<ECozinha>(BsonType.Int32));
                    i.SetIgnoreExtraElements(true);
                });
            }
        }
    }
}
